using MYPAM.Model.DataAccessObject;
using MYPAM.Model.Log;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MYPAM
{
    static class Program
    {
        //用於防止程式多開;//
        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        private const int WS_SHOWNORMAL = 1;

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Get the running instance.   
            Process instance = RunningInstance();
            if (instance == null)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.DoEvents();

                Logger.Info("MYP_AM application booting.");

                //程式啟動時，預設MYP設定為關閉;//
                Properties.Settings.Default.IsOpenMypSetting = false;
                Properties.Settings.Default.Save();

                //開啟資料庫;//
                DaoSQL.Instance.OpenDatabase();

                while (true)
                {
                    DialogResult Ret = DialogResult.Cancel;

                    //顯示主畫面;//
                    FormMain formMain = new FormMain();
                    formMain.BringToFront();
                    Ret = formMain.ShowDialog();

                    //釋放主畫面資源;//
                    formMain.Close();
                    formMain.Dispose();

                    break;
                }
            }
            else
            {
                //There is another instance of this process.
                HandleRunningInstance(instance);
            }

            Logger.Info("MYP_AM application close.");

            //強制關閉，避免因thread或是timer尚在啟動，造成程式無法關閉;//
            Environment.Exit(Environment.ExitCode);
        }

        public static Process RunningInstance()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            //Loop through the running processes in with the same name
            foreach (Process process in processes)
            {
                //Ignore the current process   
                if (process.Id != current.Id)
                {
                    //Make sure that the process is running from the exe file.
                    if (Assembly.GetExecutingAssembly().Location.Replace("/", "\\") == current.MainModule.FileName)
                    {
                        //Return the other process instance.   
                        return process;
                    }
                }
            }

            //No other instance was found, return null. 
            return null;
        }

        public static void HandleRunningInstance(Process instance)
        {
            //Make sure the window is not minimized or maximized   
            ShowWindowAsync(instance.MainWindowHandle, WS_SHOWNORMAL);

            //Set the real intance to foreground window
            SetForegroundWindow(instance.MainWindowHandle);
        }
    }
}
