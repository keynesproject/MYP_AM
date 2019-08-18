using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using MYPAM.Model.Extension;

namespace MYPAM.Model.DataAccessObject
{
    internal class DaoSQL
    {
        #region Singleton物件宣告，Thread safe，並在使用時才會建立實體

        private static readonly DaoSQL m_instance = new DaoSQL();

        internal static DaoSQL Instance { get { return m_instance; } }

        private DaoSQL()
        {
        }

        #endregion Singleton物件宣告


        /// <summary>
        /// 資料庫讀取物件
        /// </summary>
        private DaoDbCommon _SQL = null;

        /// <summary>
        /// 連接使用的資料庫
        /// </summary>
        internal DaoErrMsg OpenDatabase()
        {
            DaoErrMsg Msg = new DaoErrMsg();
            try
            {
                Msg = ConnectSQLite();
                if (Msg.isError == true)
                {
                    throw new NotImplementedException(string.Format("Connect SQL Server database error. Message:{0}", Msg.ErrorMsg));
                }
            }
            catch (Exception ex)
            {
                Msg.isError = true;
                Msg.ErrorMsg = string.Format("Connect SQL Server database throw exception. Message:{0}", ex.Message);
                return Msg;
            }

            return Msg;
        }

        private DaoErrMsg ConnectSQLite()
        {
            DaoErrMsg Err = new DaoErrMsg();

            if (_SQL != null)
            {
                //表示已開啟過;//
                return Err;
            }

            //連接Sqlite;//
            string SQLiteConn = string.Format(@"Data source={0}; Password=Myp53750804; DateTimeKind=Utc", DaoConfigFile.Instance.FileDatabase);
            _SQL = new DaoDbCommon(SQLiteConn, new SQLiteConnection());
            Err = _SQL.Connect();
            if (Err.isError)
            {
                System.Diagnostics.Debug.WriteLine(Err.ErrorMsg);
                _SQL = null;
                return Err;
            }

            return Err;
        }

        /// <summary>
        /// 關閉資料庫連接
        /// </summary>
        internal void CloseDatabase()
        {
            if (_SQL == null)
                return;

            _SQL.Close();

            _SQL = null;
        }

        /// <summary>
        /// 連接MSSQL資料庫
        /// </summary>
        /// <returns></returns>
        private DaoErrMsg ConnectMSSQL(string ServerPath, string DbName, string DbID, string DbPW)
        {
            DaoErrMsg Err = new DaoErrMsg();

            if (_SQL != null)
            {
                //表示已開啟過;//
                return Err;
            }

            //建立資料庫連接字串
            ////注意：SQLExpress版本要寫成：「.\sqlexpress」
            //string strServerPath = Properties.Settings.Default.DB_SERVER_NAME;
            ////strServerPath = @"KEYNES-PC\EXPRESS";
            //string strDbName = Properties.Settings.Default.DB_NAME;
            //string strDbID = Properties.Settings.Default.DB_ID;
            //string strDbPW = Properties.Settings.Default.DB_PW;
            string strConnection = string.Format(@"server={0};database={1};uid={2};pwd={3}",
                ServerPath,
                DbName,
                DbID,
                DbPW);

            _SQL = new DaoDbCommon(strConnection, new SqlConnection());

            Err = _SQL.Connect();

            if (Err.isError)
            {
                System.Diagnostics.Debug.WriteLine(Err.ErrorMsg);
                _SQL = null;
                return Err;
            }
            
            return Err;
        }
       
        /// <summary>
        /// 照SQL語法取得Table資料
        /// </summary>
        /// <param name="Schema"></param>
        /// <returns></returns>
        private DataTable GetDataTable(string Schema, params object[] Values)
        {
            DataTable Dt;
            DaoErrMsg Err = _SQL.GetDataTable(Schema, out Dt, Values);

            if (Err.isError)
                return null;

            return Dt;
        }

        /// <summary>
        /// 取得要連接的設備訊息
        /// </summary>
        /// <returns>[ID, Name, MachineNo, IP, Port, Enable]</returns>
        internal List<DaoFingerPrint> GetMachineInfo()
        {
            string strSchema = "select * from tbMachine;";

            DataTable dt = GetDataTable(strSchema);

            dt.Columns.Add("AttendanceCount", typeof(int));
            dt.Columns.Add("Connect", typeof(bool));
            dt.Columns.Add("strConnect", typeof(string));
            dt.Columns.Add("strEnable", typeof(string));

            return dt.ToList<DaoFingerPrint>().ToList();
        }

        internal bool isExistMachine(string IP, int Port)
        {
            string strSchema = string.Format("SELECT count(*) FROM tbMachine WHERE IP=@P0 and Port={0}", Port);

            string Count = string.Empty;
            _SQL.ExecuteScalar(strSchema, out Count, IP);

            if (Count.ToInt() > 0)
                return true;

            return false;
        }

        /// <summary>
        /// 新增設備連接資訊
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="No"></param>
        /// <param name="IP"></param>
        /// <param name="Port"></param>
        /// <returns></returns>
        internal DaoErrMsg AddNewMachine(string Name, int No, string IP, int Port, bool isEnable)
        {
            string strSchema = string.Format(@"INSERT OR REPLACE INTO tbMachine(ID, Name, MachineNo, IP, Port, Enable)
                                              VALUES((select ID from tbMachine where IP=@P0 and Port={0}),
                                                 @P1,
                                                 {1},
                                                 @P2,
                                                 {0},
                                                 {2});",
                                              Port, No, isEnable == true ? 1 : 0);

            //string strSchema = string.Format(@"IF NOT EXISTS (SELECT * FROM tbMACHINE 
            //                                                  WHERE IP=@P0 and port={0}  )
            //                                   INSERT INTO tbMACHINE(Name, MachineNo, IP, Port, Enable)
            //                                                  values(@P1, {1}, @P2, {0}, {2});",
            //                                   Port, No, isEnable == true ? 1 : 0);
            
            return _SQL.ExecuteNonQuery(strSchema, IP, Name, IP);
        }

        /// <summary>
        /// 刪除指定的設備
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        internal DaoErrMsg DeleteMachine(int ID)
        {
            string strSchema = string.Format("DELETE FROM tbMachine WHERE ID = {0}", ID);

            return _SQL.ExecuteNonQuery(strSchema);
        }

        internal bool SearchEmployees(string UserID)
        {
            string strSchema = string.Format("SELECT * FROM tbEmployees WHERE UserID='{0}'", UserID);

            DataTable dt = GetDataTable(strSchema);

            if (dt.Rows.Count <= 0)
                return false;

            return true;
        }

        /// <summary>
        /// 刪除指定員工資料
        /// </summary>
        /// <param name="UserID"></param>
        internal DaoErrMsg DeleteEmployees(string UserID)
        {
            string strSchema = string.Format("DELETE FROM tbEmployees WHERE UserID='{0}'", UserID);

            return _SQL.ExecuteNonQuery(strSchema);
        }

        /// <summary>
        /// 啟用或關閉設備
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="isEnable"></param>
        /// <returns></returns>
        internal DaoErrMsg OnOffMachine(int ID, bool isEnable)
        {
            string strSchema = string.Format(@"UPDATE tbMachine
                                               SET Enable={1}
                                               WHERE ID = {0} ",
                                               ID, isEnable == true ? 1 : 0);

            return _SQL.ExecuteNonQuery(strSchema);
        }

        /// <summary>
        /// 設定員工資訊
        /// </summary>
        /// <param name="Employees"></param>
        /// <returns></returns>
        internal DaoErrMsg SetEmployees(List<DaoUserInfo> Employees)
        {
            DaoErrMsg Msg = new DaoErrMsg();

            StringBuilder sbSchema = new StringBuilder();
            int Count = 0;
            foreach (DaoUserInfo Info in Employees)
            {
                sbSchema.AppendFormat(@"INSERT OR REPLACE INTO tbEmployees(ID, UserID, Name, CardNum, RecordTime)
                                        VALUES((select ID from tbEmployees where UserID = '{0}'),
                                           '{0}',
                                           '{1}',
                                           '{2}',
                                           dateTime()
                                        );",
                                        Info.UserID, Info.Name, Info.CardNum);
                Count++;
                if (Count == 40)
                {
                    Msg = _SQL.ExecuteNonQuery(sbSchema.ToString());
                    Count = 0;
                    sbSchema.Init();
                }
            }

            if(Count != 0)
                return _SQL.ExecuteNonQuery(sbSchema.ToString());

            return Msg;
        }

        /// <summary>
        /// 取得總員工數
        /// </summary>
        /// <returns></returns>
        internal int GetEmployeesNum()
        {
            string strSchema = "SELECT COUNT(UserID) FROM tbEmployees";

            string Count = string.Empty;
            _SQL.ExecuteScalar(strSchema, out Count);

            return Count.ToInt();
        }

        /// <summary>
        /// 取得員工資訊
        /// </summary>
        /// <returns></returns>
        internal DataTable GetEmployees(int FromNo = -1, int EndNo = -1)
        {
            string strSchema;
            if (FromNo >= 0 && EndNo >= 0)
            {
                strSchema = string.Format(@"SELECT --[ID] as '序號',
		                                           [UserID] as '員工編號',
		                                           [Name] as '姓名',
		                                           [CardNum] as '卡號',
		                                           [RecordTime] as '建立時間' 
                                            FROM [tbEmployees]
                                            limit {0}, {1}",
                                            FromNo, EndNo);
            }
            else
            {
                strSchema = @"SELECT --[ID] as '序號',
                                     [UserID] as '員工編號',
                                     [Name] as '姓名',
                                     [CardNum] as '卡號',
                                     [RecordTime] as '建立時間'
                              FROM [tbEmployees];";
            }

            return GetDataTable(strSchema);
        }
        
        /// <summary>
        /// 取得目前已讀取的考勤數量
        /// </summary>
        /// <param name="DeviceID"></param>
        /// <returns></returns>
        internal int GetReadAttendanceNum(int DeviceID)
        {
            string strSchema = string.Format("SELECT ReadIndex FROM tbMachine where ID = {0}", DeviceID);

            string Count = string.Empty;
            _SQL.ExecuteScalar(strSchema, out Count);

            return Count.ToInt();
        }
        
        /// <summary>
        /// 初始化已讀取的考勤數量
        /// </summary>
        /// <param name="DeviceID"></param>
        internal void ResetReadAttendanceNum(int DeviceID)
        {
            string strSchema = string.Format(@"UPDATE tbMachine SET[ReadIndex]=0 WHERE[ID] = '{0}';", DeviceID);

            _SQL.ExecuteNonQuery(strSchema);
        }

        internal void SetAttendance(int DeviceID, List<DaoAttendance> AttInfo)
        {
            StringBuilder sbSchema = new StringBuilder();
            int Count = 0;
            foreach(DaoAttendance Info in AttInfo)
            {
                sbSchema.AppendFormat(@"INSERT INTO tbRecords([UserID], [RecordTime], [Name], [CardNum], [Location])
                                                     values('{0}', 
                                                            '{1}',
                                                            (select Name FROM tbEmployees WHERE UserID='{0}'), 
                                                            (select CardNum FROM tbEmployees WHERE UserID='{0}'),
                                                            '{2}');",
                                                            Info.UserID,
                                                            Info.RecordTime.ToString("yyyy-MM-dd HH:mm:ss"),
                                                            Info.Location);

                Count++;
                if (Count == 40)
                {
                    _SQL.ExecuteNonQuery(sbSchema.ToString());
                    Count = 0;
                    sbSchema.Init();
                }
            }

            if(Count != 0)
                _SQL.ExecuteNonQuery(sbSchema.ToString());

            sbSchema.Init();
            sbSchema.AppendFormat("update tbMachine set ReadIndex = ReadIndex + {0} where ID = {1};", AttInfo.Count, DeviceID);
            _SQL.ExecuteNonQuery(sbSchema.ToString());
        }

        /// <summary>
        /// 取的總考勤資料總數
        /// </summary>
        /// <returns></returns>
        internal int GetAttNum()
        {
            string strSchema = "SELECT COUNT(ID) FROM tbRecords";

            string Count = string.Empty;
            _SQL.ExecuteScalar(strSchema, out Count);

            return Count.ToInt();
        }

        /// <summary>
        /// 取得考勤資料
        /// </summary>
        /// <param name="fromNo"></param>
        /// <param name="endNo"></param>
        /// <returns></returns>
        internal DataTable GetAtt(int FromNo, int EndNo)
        {
            string strSchema;
            if (FromNo >= 0 && EndNo >= 0)
            {
                strSchema = string.Format(@"SELECT [ID] as '序號',
	                                               [UserID] as '員工編號',
	                                               [Name] as '姓名',
	                                               [CardNum] as '卡號',	                                               
                                                   [Location] as '地點',
                                                   [RecordTime] as '打卡時間'
                                            FROM [tbRecords]
                                            ORDER BY RecordTime DESC
                                            limit {0}, {1}",
                                            FromNo, EndNo);
            }
            else
            {
                strSchema = @"SELECT [ID] as '序號',
	                                 [UserID] as '員工編號',
	                                 [Name] as '姓名',
	                                 [CardNum] as '卡號',
                                     [Location] as '地點',
	                                 [RecordTime] as '打卡時間'                                     
                                 FROM tbRecords
                                 ORDER BY RecordTime DESC;";
            }
            DataTable dt = GetDataTable(strSchema);
            return dt;
        }
    }
}