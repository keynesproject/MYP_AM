using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MYPAM.Model.DataAccessObject
{
    internal class DaoConfigFile
    {
        #region Singleton物件宣告

        private static readonly DaoConfigFile m_instance = new DaoConfigFile();

        internal static DaoConfigFile Instance { get { return m_instance; } }

        #endregion
        
        /// <summary>
        /// 資料夾目錄
        /// </summary>
        internal string m_DirBase = @".\Data\";

        private string m_DirConfig = "Config";

        private string m_DirAttExport = @"./Attendance/";

        internal string m_FileDatabase = "MYP_AM.db";

        private string m_FileConfigLog4Net = "log4net.config";
        
        private DaoConfigFile()
        {
            DirAttExport = Properties.Settings.Default.ExportAttPath;            
        }

        /// <summary>
        /// Config的主路徑
        /// </summary>
        internal string DirConfig
        {
            get { return m_DirBase + m_DirConfig + "\\"; }
        }

        internal string DirConfigWithoutBase
        {
            get { return "\\" + m_DirConfig + "\\"; }
        }

        internal string FileLog4Net
        {
            get { return DirConfig + m_FileConfigLog4Net; }
        }

        /// <summary>
        /// 資料庫
        /// </summary>
        internal string FileDatabase
        {
            get { return DirConfig + m_FileDatabase; }
        }

        internal string DirAttExport
        {
            get
            {
                return m_DirAttExport;
            }

            set
            {                
                try
                {
                    if (Directory.Exists(value) == false)
                    {
                        Directory.CreateDirectory(value);
                    }

                    if(value.IndexOf("./")==0)
                    {
                        m_DirAttExport = Directory.GetCurrentDirectory() + "/" + value.Replace("./", "");
                    }
                    else
                    {
                        m_DirAttExport = value;
                    }
                    Properties.Settings.Default.ExportAttPath = m_DirAttExport;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #region Log 資料
        private string m_DirLog = "Log";

        internal string DirLog
        {
            get { return m_DirBase + m_DirLog + "\\"; }
        }

        internal string DirLogWithoutBase
        {
            get { return "\\" + m_DirLog + "\\"; }
        }

        #endregion Log 資料
    }
}
