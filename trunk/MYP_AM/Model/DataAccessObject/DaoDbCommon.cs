using System;
using System.Data;
using System.Data.Common;
using System.Windows;
using System.Linq;
using MYPAM.Model.Extension;
using MYPAM.Model.Log;
using System.Windows.Forms;

namespace MYPAM.Model.DataAccessObject
{
    /// <summary>
    /// Data Base 查詢指令通用物件
    /// </summary>
    public class DaoDbCommon
    {
        /// <summary>
        /// 資料庫連接物件
        /// </summary>
        private DbConnection m_DbConnection = null;

        static DataTable GetProviderFactoryClasses()
        {
            // Retrieve the installed providers and factories.
            DataTable table = DbProviderFactories.GetFactoryClasses();

            // Display each row and column value.
            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn column in table.Columns)
                {
                    System.Diagnostics.Debug.WriteLine(row[column]);
                }
            }
            return table;
        }

        /// <summary>
        /// 建立資料庫物件
        /// </summary>
        internal DaoDbCommon(string DbPath, DbConnection DbConnection)
        {
            this.m_DbConnection = DbConnection;
                        
            m_DbConnection.ConnectionString = DbPath;
        }

        /// <summary>
        /// 解構式
        /// </summary>
        ~DaoDbCommon()
        {
            this.Close( true );
        }

        /// <summary>
        /// 開啟資料庫
        /// </summary>
        /// <returns>錯誤資訊</returns>
        internal DaoErrMsg Connect()
        {
            if (m_DbConnection.State != ConnectionState.Open)
            {
                try
                {
                    m_DbConnection.Open();
                }
                catch (Exception Ex)
                {
                    return new DaoErrMsg(true, Ex.Message);
                }
            }

            return new DaoErrMsg();
        }

        /// <summary>
        /// 關閉資料庫
        /// </summary>
        /// <param name="isDispose">是否馬上釋放資源</param>
        internal void Close(bool isDispose = false)
        {
            try
            {
                if (m_DbConnection.State == ConnectionState.Open)
                {
                    m_DbConnection.Close();
                }

                if (isDispose)
                {

                    m_DbConnection.Dispose();
                }
            }
            catch (Exception ex)
            {
                Logger.Debug(ex.Message);
            }
        }

        /// <summary>
        /// 用來執行INSERT、UPDATE、DELETE和其他沒有返回值得SQL命令。返回被命令影響的行數。若是用在對其他命令，則返回-1。
        /// </summary>
        /// <param name="strSchema">SQL指令碼</param>
        /// <returns>錯誤資訊</returns>
        internal DaoErrMsg ExecuteNonQuery(string strSchema, params object[] Values)
        {          
            //設定查詢SQL語法;//
            DbCommand DbCmd = DbProviderFactories.GetFactory(m_DbConnection.ToString().RemoveLastIndexof('.')).CreateCommand();
            DbCmd.CommandText = strSchema;
            DbCmd.Connection = m_DbConnection;

            for (int i = 0; i < Values.Count(); i++)
            {
                var Param = DbCmd.CreateParameter();
                Param.ParameterName = "@P" + i;
                Param.Value = Values[i];                
                DbCmd.Parameters.Add(Param);
            }

            try
            {
                DbCmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                PrintErrorLog(Ex.Message, strSchema, Values);               
                return new DaoErrMsg(true, Ex.Message);
            }
            return new DaoErrMsg();
        }

        /// <summary>
        /// 執行一個SQL命令返回結果集的第一列的第一行。經常用來執行SQL的COUNT、AVG、MIN、MAX 和 SUM 函數，這些函數都是返回單行單列的結果集。
        /// </summary>
        /// <param name="strSchema">SQL指令碼</param>
        /// <returns>錯誤資訊</returns>
        internal DaoErrMsg ExecuteScalar(string strSchema, out string strOutput, params object[] Values)
        {
            //設定查詢SQL語法;//
            DbCommand DbCmd = DbProviderFactories.GetFactory(m_DbConnection.ToString().RemoveLastIndexof('.')).CreateCommand();
            DbCmd.Connection = m_DbConnection;
            DbCmd.CommandText = strSchema;

            for (int i = 0; i < Values.Count(); i++)
            {
                IDataParameter Param = DbCmd.CreateParameter();
                Param.ParameterName = "@P" + i;
                Param.Value = Values[i];
                DbCmd.Parameters.Add(Param);
            }

            strOutput = string.Empty;

            try
            {
                Object Result = DbCmd.ExecuteScalar();
                if (Result != null)
                    strOutput = Result.ToString();
            }
            catch (Exception Ex)
            {
                PrintErrorLog(Ex.Message, strSchema, Values);
                return new DaoErrMsg(true, Ex.Message);
            }

            return new DaoErrMsg();
        }

        /// <summary>
        /// 取得Datable格式的資料
        /// </summary>
        /// <param name="strSchema">SQL指令碼</param>
        /// <param name="Dt">查詢SQL後儲存的資料表</param>
        /// <returns>錯誤資訊</returns>
        internal DaoErrMsg GetDataTable(string strSchema, out DataTable Dt, params object[] Values)
        {
            Dt = new DataTable();

            //設定查詢SQL語法;//
            DbCommand DbCmd = DbProviderFactories.GetFactory(m_DbConnection.ToString().RemoveLastIndexof('.')).CreateCommand();
            DbCmd.CommandText = strSchema;
            DbCmd.Connection = m_DbConnection;

            for (int i = 0; i < Values.Count(); i++)
            {
                var Param = DbCmd.CreateParameter();
                Param.ParameterName = "@P" + i;
                Param.Value = Values[i];
                DbCmd.Parameters.Add(Param);
            }

            DbDataAdapter DbAdapter = DbProviderFactories.GetFactory(m_DbConnection.ToString().RemoveLastIndexof('.')).CreateDataAdapter();
            DbAdapter.SelectCommand = DbCmd;
            
            try
            {
                DbAdapter.Fill(Dt);
            }
            catch (Exception Ex)
            {
                PrintErrorLog(Ex.Message, strSchema, Values);
                return new DaoErrMsg(true, Ex.Message);
            }

            return new DaoErrMsg();
        }

        /// <summary>
        /// 列印出錯誤訊息至檔案
        /// </summary>
        /// <param name="ExceptionMsg"></param>
        /// <param name="strSchema"></param>
        /// <param name="Values"></param>
        private void PrintErrorLog(string ExceptionMsg, string strSchema, params object[] Values)
        {
            string ErrorMsg = string.Format("\r\nSQL System error message:{0}\r\nSqlSchema:{1}\r\nParam: ", ExceptionMsg, strSchema);
            string OriginalSchema = string.Copy(strSchema);
            for (int i = 0; i < Values.Count(); i++)
            {
                if (Values[i] != null)
                {
                    ErrorMsg += (i.ToString() + "." + Values[i].ToString() + " ");
                    OriginalSchema = OriginalSchema.ReplaceFirstAssignString("@P" + i.ToString(), Values[i].ToString());
                }
                else
                {
                    ErrorMsg += (i.ToString() + ".NULL ");
                    OriginalSchema = OriginalSchema.ReplaceFirstAssignString("@P" + i.ToString(), "null");
                }
            }

            if (Values.Count() > 0)
            {
                ErrorMsg += string.Format("\r\nOriginal SqlSchema: {0}", OriginalSchema);
            }
            Logger.Error(ErrorMsg + "\r\nCall Stack:" + Environment.StackTrace);
#if DEBUG
            MessageBox.Show(ExceptionMsg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
        }
    }

    /// <summary>
    /// DAO 錯誤訊息物件
    /// </summary>
    internal class DaoErrMsg
    {
        internal DaoErrMsg(bool isError = false, string ErrorMsg = "")
        {
            this.isError = isError;
            this.ErrorMsg = ErrorMsg;
        }

        internal bool isError { get; set; }
        internal string ErrorMsg { get; set; }
    }

}
