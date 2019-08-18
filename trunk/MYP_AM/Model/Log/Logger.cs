using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MYPAM.Model.DataAccessObject;

namespace MYPAM.Model.Log
{
    class Logger
    {
        #region Singleton物件宣告

        private static readonly Logger m_instance = new Logger();

        internal static Logger Instance { get { return m_instance; } }

        //private static class LoggerHolder
        //{
        //    internal static readonly Logger Instance = new Logger();

        //    static LoggerHolder() { }
        //}

        //internal static Logger Instance
        //{
        //    get
        //    {
        //        return LoggerHolder.Instance;
        //    }
        //}

        #endregion

        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        Logger()
        {
            XmlConfigurator.Configure(new System.IO.FileInfo(DaoConfigFile.Instance.FileLog4Net));            
        }

        /// <summary>
        /// 偵錯訊息
        /// </summary>
        /// <param name="Msg"></param>
        public static void Debug(string Msg)
        {
            Log.Debug(Msg);
        }

        /// <summary>
        /// 訊息
        /// </summary>
        /// <param name="Msg"></param>
        public static void Info(string Msg)
        {
            Log.Info(Msg);
        }

        /// <summary>
        /// 警告訊息
        /// </summary>
        /// <param name="Msg"></param>
        public static void Warn(string Msg)
        {
            Log.Warn(Msg);
        }

        /// <summary>
        /// 錯誤訊息
        /// </summary>
        /// <param name="Msg"></param>
        public static void Error(string Msg)
        {
            Log.Error(Msg);
        }

        /// <summary>
        /// 嚴重錯誤訊息
        /// </summary>
        /// <param name="Msg"></param>
        public static void Fatal(string Msg)
        {
            Log.Fatal(Msg);
        }
    }
}
