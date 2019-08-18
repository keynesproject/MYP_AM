using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

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

        internal string m_DirAttExport = @".\Attendance\";

        internal string m_FileDatabase = "MYP_AM.db";

        private string m_FileConfigLog4Net = "log4net.config";
        
        private DaoConfigFile()
        {
            if (Directory.Exists(m_DirAttExport) == false)
            {
                Directory.CreateDirectory(m_DirAttExport);
            }
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
