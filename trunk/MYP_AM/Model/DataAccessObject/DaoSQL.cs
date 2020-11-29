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

        /// <summary>
        /// 開啟ForeignKeys功能
        /// </summary>
        private void OpenForeignKeys()
        {
            string strSchema = "PRAGMA foreign_keys = ON; PRAGMA automatic_index=off;";
            _SQL.ExecuteNonQuery(strSchema);
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

            //第一次開啟DB時，要開啟ForeignKeys功能;//
            OpenForeignKeys();

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

        internal bool GetRtbMachineEmployee(int machineID, int employeeID)
        {
            //先檢查此關係資料存不存在，不存在則建立，存在則回傳資料;//
            string strSchema = string.Format("SELECT * FROM rtbMachineEmployee WHERE Employee={0} and Machine={1}", employeeID, machineID);

            DataTable dt = GetDataTable(strSchema);

            if (dt.Rows.Count > 0)
                return dt.Rows[0]["Enable"].ToInt() > 0 ? true : false;

            strSchema = string.Format("INSERT INTO rtbMachineEmployee(Machine, Employee) VALUES({0}, {1})", machineID, employeeID);
            _SQL.ExecuteNonQuery(strSchema);

            return true;
        }

        /// <summary>
        /// 更新設備的人員啟用或禁用資訊
        /// </summary>
        /// <param name="employeeID"></param>
        /// <param name="machineID"></param>
        /// <param name="v"></param>
        internal void UpdateRtbMachineEmployee(int employeeID, int machineID, bool enable)
        {
            string strSchema = string.Format("UPDATE rtbMachineEmployee SET [Enable]={0} WHERE Machine={1} AND Employee={2}",
                                             enable, machineID, employeeID);

            _SQL.ExecuteNonQuery(strSchema);
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
        internal List<DaoTimeClock> GetMachineInfo()
        {
            string strSchema = "select * from tbMachine;";

            DataTable dt = GetDataTable(strSchema);

            dt.Columns.Add("AttendanceCount", typeof(int));
            dt.Columns.Add("Connect", typeof(bool));
            dt.Columns.Add("strConnect", typeof(string));
            dt.Columns.Add("strEnable", typeof(string));

            return dt.ToList<DaoTimeClock>().ToList();
        }

        internal List<DaoTimeClock> GetMachineInfo(int ID)
        {
            string strSchema = string.Format("select * from tbMachine WHERE ID={0};", ID);

            DataTable dt = GetDataTable(strSchema);

            dt.Columns.Add("AttendanceCount", typeof(int));
            dt.Columns.Add("Connect", typeof(bool));
            dt.Columns.Add("strConnect", typeof(string));
            dt.Columns.Add("strEnable", typeof(string));

            return dt.ToList<DaoTimeClock>().ToList();
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
        internal DaoErrMsg AddNewMachine(string Name, string Location, int No, string IP, int Port, bool isEnable, int type)
        {
            string strSchema = string.Format(@"INSERT OR REPLACE INTO tbMachine(ID, Name, MachineNo, Location, IP, Port, Enable, Type)
                                              VALUES((select ID from tbMachine where IP=@P0 and Port={0}),
                                                 @P1,
                                                 {1},
                                                 '{2}',
                                                 @P2,
                                                 {0},
                                                 {3},
                                                 {4});",
                                              Port, No, Location, isEnable == true ? 1 : 0, type);

            return _SQL.ExecuteNonQuery(strSchema, IP, Name, IP);
        }

        /// <summary>
        /// 儲存設備連接資訊
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="No"></param>
        /// <param name="IP"></param>
        /// <param name="Port"></param>
        /// <returns></returns>
        internal DaoErrMsg SaveMachine(int ID, string Name, string Location, int No, string IP, int Port, bool isEnable, int type)
        {
            string strSchema = string.Format(@"INSERT OR REPLACE INTO tbMachine(ID, Name, MachineNo, Location, IP, Port, Enable, Type)
                                              VALUES(
                                                 {0},
                                                 @P0,
                                                 {1},
                                                 '{2}',
                                                 @P1,
                                                 {3},
                                                 {4},
                                                 {5});",
                                              ID, No, Location, Port, isEnable == true ? 1 : 0, type);

            return _SQL.ExecuteNonQuery(strSchema, Name, IP);
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
        /// 刪除指定員工資料
        /// </summary>
        /// <param name="ID"></param>
        internal DaoErrMsg DeleteEmployees(int ID)
        {
            string strSchema = string.Format("DELETE FROM tbEmployees WHERE ID={0}", ID);

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
                sbSchema.AppendFormat(@"INSERT OR REPLACE INTO tbEmployees(ID, UserID, Name, CardNum, Privilege, RecordTime)
                                        VALUES((select ID from tbEmployees where UserID = '{0}'),
                                           '{0}',
                                           '{1}',
                                           '{2}',
                                           {3},
                                           dateTime());",
                                        Info.UserID, Info.Name, Info.CardNum, Info.Privilege);
                sbSchema.AppendLine();
                Count++;
                if (Count == 40)
                {
                    Msg = _SQL.ExecuteNonQuery(sbSchema.ToString());
                    Count = 0;
                    sbSchema.Init();
                }
            }

            if (Count != 0)
                return _SQL.ExecuteNonQuery(sbSchema.ToString());

            return Msg;
        }

        /// <summary>
        /// 檢查tbEmployees是否有存在此ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        internal bool CheckExistEmployeesID(int ID)
        {
            string strSchema = "SELECT count(*) FROM tbEmployees WHERE ID=" + ID;

            string count = string.Empty;
            _SQL.ExecuteScalar(strSchema, out count);

            return count.ToInt() > 0 ? true : false;
        }

        /// <summary>
        /// 檢查UserID是否存在
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        internal bool CheckExistUserID(string userID)
        {
            string strSchema = string.Format("SELECT count(*) FROM tbEmployees WHERE UserID='{0}'", userID);

            string count = string.Empty;
            _SQL.ExecuteScalar(strSchema, out count);

            return count.ToInt() > 0 ? true : false;
        }

        /// <summary>
        /// 檢查ID與UserID是否在同一列資料中
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        internal bool CheckEmployeesIdAndUserID(int id, string userID)
        {
            string strSchema = string.Format("SELECT count(*) FROM tbEmployees WHERE ID={0} AND UserID='{1}'", id, userID);

            string count = string.Empty;
            _SQL.ExecuteScalar(strSchema, out count);

            return count.ToInt() > 0 ? true : false;
        }

        /// <summary>
        /// 設定員工資訊INSERT OR REPLACE
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="name"></param>
        /// <param name="cardNum"></param>
        /// <param name="privilege"></param>
        /// <returns></returns>
        internal DaoErrMsg SetEmployee(string userID, string name, string cardNum, int privilege)
        {
            string strSchema = string.Format(@"INSERT OR REPLACE INTO tbEmployees(ID, UserID, Name, CardNum, Privilege, RecordTime)
                                               VALUES((select ID from tbEmployees where UserID = '{0}'),
                                                  '{0}',
                                                  '{1}',
                                                  '{2}',
                                                  {3},
                                                  dateTime());",
                                                  userID, name, cardNum, privilege);

            return _SQL.ExecuteNonQuery(strSchema);
        }

        /// <summary>
        /// 更新員工資訊
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="userID"></param>
        /// <param name="name"></param>
        /// <param name="cardNum"></param>
        /// <param name="privilege"></param>
        internal void UpdateEmployee(int ID, string userID, string name, string cardNum, int privilege)
        {
            //string strSchema = string.Format(@"UPDATE tbMachine SET[ReadIndex]=0 WHERE[ID] = '{0}';", DeviceID);
            string strSchema = string.Format(@"UPDATE tbEmployees SET [UserID]='{1}', [Name]='{2}', [CardNum]='{3}', [Privilege]={4} WHERE ID={0};",
                                               ID, userID, name, cardNum, privilege);

            _SQL.ExecuteNonQuery(strSchema);
        }

        /// <summary>
        /// 新增一筆員工資訊
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="name"></param>
        /// <param name="cardNum"></param>
        /// <param name="privilege"></param>
        /// <returns></returns>
        internal DaoErrMsg InsertEmployee(string userID, string name, string cardNum, int privilege)
        {
            string strSchema = string.Format(@"INSERT INTO tbEmployees( UserID, Name, CardNum, Privilege, RecordTime)
                                               VALUES('{0}', '{1}', '{2}', {3}, dateTime());",
                                               userID, name, cardNum, privilege);

            return _SQL.ExecuteNonQuery(strSchema);
        }

        /// <summary>
        /// 新增一筆員工資訊
        /// </summary>
        /// <returns>序號</returns>
        internal DataTable NewEmployee()
        {
            string strSchema = @"INSERT INTO tbEmployees( UserID, Name, CardNum, RecordTime)
                                                  VALUES('', '', '0000000000', dateTime());
                                 SELECT * FROM tbEmployees WHERE ID=(SELECT MAX(ID) FROM tbEmployees);";

            return GetDataTable(strSchema);
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
                strSchema = string.Format(@"SELECT [ID] as '序號',
		                                           [UserID] as '員工編號',
		                                           [Name] as '姓名',
		                                           [CardNum] as '卡號',
                                                   [Privilege] as '權限',
                                                   [Enable],
		                                           [RecordTime] as '建立時間' 
                                            FROM [tbEmployees]
                                            limit {0}, {1};",
                                            FromNo, EndNo);
            }
            else
            {
                strSchema = @"SELECT [ID] as '序號',
                                     [UserID] as '員工編號',
                                     [Name] as '姓名',
                                     [CardNum] as '卡號',
                                     [Privilege] as '權限',
                                     [Enable],
                                     [RecordTime] as '建立時間'
                              FROM [tbEmployees];";
            }

            return GetDataTable(strSchema);
        }

        internal DataTable GetAllEmployees()
        {
            string strSchema = "SELECT ID, CASt(UserID as int) as UserID, Name, CardNum, Privilege, Enable, RecordTime FROM tbEmployees";
            return GetDataTable(strSchema);
        }

        internal DataTable GetEmployee(int ID)
        {
            string strSchem = string.Format(@"SELECT [UserID], [Name], [CardNum], [Privilege]
                                              FROM tbEmployees
                                              WHERE ID = {0};", ID);

            return GetDataTable(strSchem);
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
            string strSchema = string.Format(@"UPDATE tbMachine SET [ReadIndex]=0 WHERE[ID] = '{0}';", DeviceID);

            _SQL.ExecuteNonQuery(strSchema);
        }

        /// <summary>
        /// 設定打卡考勤資訊
        /// </summary>
        /// <param name="DeviceID">裝置ID</param>
        /// <param name="AttInfo">打卡資訊</param>
        internal void SetAttendance(int DeviceID, List<DaoAttendance> AttInfo)
        {
            StringBuilder sbSchema = new StringBuilder();
            int Count = 0;
            foreach (DaoAttendance Info in AttInfo)
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
                sbSchema.AppendLine();
                Count++;
                if (Count == 40)
                {
                    _SQL.ExecuteNonQuery(sbSchema.ToString());
                    Count = 0;
                    sbSchema.Init();
                }
            }

            if (Count != 0)
                _SQL.ExecuteNonQuery(sbSchema.ToString());

            sbSchema.Init();
            sbSchema.AppendFormat("update tbMachine set ReadIndex = ReadIndex + {0} where ID = {1};", AttInfo.Count, DeviceID);
            _SQL.ExecuteNonQuery(sbSchema.ToString());
        }

        /// <summary>
        /// 取得全部打卡考勤資訊
        /// </summary>
        /// <returns></returns>
        internal List<DaoAttendance> GetAttendance()
        {
            string strSchema = "select cast(UserID as int) as UserID, Name as UserName, CardNum, Location, RecordTime from tbRecords;";

            DataTable dt = GetDataTable(strSchema);

            dt.Columns.Add("sUserID", typeof(string));

            return dt.ToList<DaoAttendance>().ToList();
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
        
        /// <summary>
        /// 取得匯出檔案的格式
        /// </summary>
        /// <returns></returns>
        internal DataTable GetOutFileSetting()
        {
            return GetDataTable("SELECT * from tbOutputFormat");
        }

        /// <summary>
        /// 儲存匯出檔案的格式
        /// </summary>
        /// <param name="format"></param>
        internal void SaveFileSetting(List<OutputFormat> format)
        {
            if (format.Count != 7)
                return;
            
            for(int i=0; i<format.Count;i++)
            {
                string strSchema = string.Format("UPDATE tbOutputFormat SET Type={0}, Length={1}, Contex=\"{2}\" WHERE ID={3}",
                                                  (int)format[i].type,
                                                  format[i].length,
                                                  format[i].contex,
                                                  i + 1);

                _SQL.ExecuteNonQuery(strSchema);
            }
        }
    }

    public enum eOutputType
    {
        eEmployeeID = 1,
        eCardNo,
        eString
    }

    public class OutputFormat
    {
        public OutputFormat() { }

        public OutputFormat(eOutputType type, int length, string contex)
        {
            this.type = type;
            this.length = length;
            this.contex = contex;
        }

        public eOutputType type { get; set; }
        public int length { get; set; }
        public string contex { get; set; }
    }
}