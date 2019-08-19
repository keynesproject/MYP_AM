using MYPAM.Model.DataAccessObject;
using MYPAM.Model.Log;
using MYPAM.View.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MYPAM.Model.Device
{
    public class MYP2000
    {
        /// <summary>
        /// Create Standalone SDK class dynamicly.
        /// </summary>
        private zkemkeeper.CZKEMClass m_axCZKEM1 = new zkemkeeper.CZKEMClass();

        /// <summary>
        /// 設備基本資訊
        /// </summary>
        private DaoFingerPrint m_daoFP = new DaoFingerPrint();

        /// <summary>
        /// 設備基本資訊
        /// </summary>
        public DaoFingerPrint DeviceInfo
        {
            get { return m_daoFP; }
        }

        /// <summary>
        /// 設備是否啟動
        /// </summary>
        public bool Enable
        {
            get { return m_daoFP.Enable; }
            set { m_daoFP.Enable = value; }
        }
               
        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="daoFP"></param>
        public MYP2000(DaoFingerPrint daoFP)
        {
            m_daoFP = daoFP;
            m_daoFP.MachineNo = 1;
        }

        /// <summary>
        /// 連接設備
        /// </summary>
        public void Connect()
        {
            //這裝置不啟用，所以不予連線;//
            if (this.Enable == false)
                return;

            if (m_daoFP.IP.Trim() == "" || m_daoFP.Port.ToString().Trim() == "")
            {
                //MessageBox.Show("IP及埠號不可以為空!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                m_daoFP.Connect = DaoFingerPrint.eConnectState.eCON_UNABLE;
                return;
            }            

            bool bIsConnected = m_axCZKEM1.Connect_Net(m_daoFP.IP, m_daoFP.Port);
            if (bIsConnected == true)
            {
                //Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
                m_axCZKEM1.RegEvent(m_daoFP.MachineNo, 65535);
            }
            else
            {
                int idwErrorCode = 0;
                m_axCZKEM1.GetLastError(ref idwErrorCode);
                //MessageBox.Show(string.Format("無法連線至[{0}],錯誤代碼={1}", DeviceInfo.Name, idwErrorCode.ToString()), "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                m_daoFP.Connect = DaoFingerPrint.eConnectState.eCON_UNABLE;
                return;
            }
            
            m_daoFP.Connect = DaoFingerPrint.eConnectState.eCON_CONNECTED;
        }

        /// <summary>
        /// 關閉設備連線
        /// </summary>
        public void Disconnect()
        {
            m_axCZKEM1.Disconnect();
            this.DeviceInfo.Connect = DaoFingerPrint.eConnectState.eCON_DISCONNECT;
        }

        /// <summary>
        /// 讀取員工資訊
        /// </summary>
        /// <returns></returns>
        public List<DaoUserInfo> LoadUserInfo()
        {
            //不處於連現狀態就不予處理;//
            if (m_daoFP.Connect != DaoFingerPrint.eConnectState.eCON_CONNECTED)
                return new List<DaoUserInfo>();

            int iEnrollNumber = 0;
            string sName = "";
            string sPassword = "";
            int iPrivilege = 0;
            bool bEnabled = false;
            string sCardNum = "";

            m_axCZKEM1.EnableDevice(m_daoFP.MachineNo, false);
            //read all the user information to the memory
            m_axCZKEM1.ReadAllUserID(m_daoFP.MachineNo);
            m_axCZKEM1.EnableDevice(m_daoFP.MachineNo, true);

            List<DaoUserInfo> lUserInfo = new List<DaoUserInfo>();
            //get all the users' information from the memory
            while (m_axCZKEM1.GetAllUserInfo(
                m_daoFP.MachineNo,
                ref iEnrollNumber,
                ref sName,
                ref sPassword,
                ref iPrivilege,
                ref bEnabled))
            {
                DaoUserInfo Info = new DaoUserInfo();

                Info.UserID = iEnrollNumber;
                Info.Name = sName;
                m_axCZKEM1.GetStrCardNumber(out sCardNum);
                Info.CardNum = sCardNum;

                lUserInfo.Add(Info);
            }

            return lUserInfo;
        }

        /// <summary>
        /// 刪除考勤紀錄
        /// </summary>
        /// <returns></returns>
        public bool DeleteAttendance()
        {
            //不處於刪除狀態就不予處理;//
            if (m_daoFP.Connect != DaoFingerPrint.eConnectState.eCON_CLEAR_ATT)
                return false;

            int idwErrorCode = 0;

            m_axCZKEM1.EnableDevice(m_daoFP.MachineNo, false);//disable the device
            if (m_axCZKEM1.ClearGLog(m_daoFP.MachineNo))
            {
                //the data in the device should be refreshed
                m_axCZKEM1.RefreshData(m_daoFP.MachineNo);
                //MessageBox.Show("All att Logs have been cleared from teiminal!", "Success");
            }
            else
            {
                m_axCZKEM1.GetLastError(ref idwErrorCode);
                //MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
            
            //enable the device
            m_axCZKEM1.EnableDevice(m_daoFP.MachineNo, true);

            return idwErrorCode == 0 ? true : false;
        }

        /// <summary>
        /// 取得考勤數量
        /// </summary>
        /// <returns></returns>
        public int GetAttendanceCount()
        {
            if (m_daoFP.Connect != DaoFingerPrint.eConnectState.eCON_CONNECTED)
                return 0;

            int iValue = 0;

            //Here we use the function "GetDeviceStatus" to get the record's count.The parameter "Status" is 6.
            if (m_axCZKEM1.GetDeviceStatus(m_daoFP.MachineNo, 6, ref iValue)) 
                return iValue;

            return 0;
        }

        /// <summary>
        /// 讀取考勤紀錄
        /// </summary>
        /// <param name="Index">指定要開始讀取的位置，會從此位置開始抓取資料到結尾</param>
        /// <returns></returns>
        public List<DaoAttendance> LoadAttendance(int Index = 0)
        {
            List<DaoAttendance> lAttInfo = new List<DaoAttendance>();

            //不處於連現狀態就不予處理;//
            if (m_daoFP.Connect != DaoFingerPrint.eConnectState.eCON_CONNECTED )
                return lAttInfo;

            int iEnrollNumber = 0;
            int iVerifyMode = 0;
            int iInOutMode = 0;
            int iYear = 0;
            int iMonth = 0;
            int iDay = 0;
            int iHour = 0;
            int iMinute = 0;
            int iSecond = 0;
            int iWorkcode = 0;
            int iReserved = 0;
            string sCardNum = "";
            int idwErrorCode = 0;

            m_axCZKEM1.EnableDevice(m_daoFP.MachineNo, false);//disable the device
            
            if (m_axCZKEM1.ReadGeneralLogData(m_daoFP.MachineNo))//read all the attendance records to the memory
            {
                //資料已讀取到本機，重新開啟設備;//
                m_axCZKEM1.EnableDevice(m_daoFP.MachineNo, true);

                int ReadCount = 0;

                while (m_axCZKEM1.GetGeneralExtLogData(
                    m_daoFP.MachineNo,
                    ref iEnrollNumber,
                    ref iVerifyMode,
                    ref iInOutMode,
                    ref iYear,
                    ref iMonth,
                    ref iDay,
                    ref iHour,
                    ref iMinute,
                    ref iSecond,
                    ref iWorkcode,
                    ref iReserved))
                {
                    if (ReadCount >= Index)
                    {
                        DaoAttendance Info = new DaoAttendance();
                        Info.UserID = iEnrollNumber;
                        //Info.UserName;   //從Employees表格取得;//
                        //Info.CardNumber; //從Employees表格取得;//
                        Info.Location = m_daoFP.Location;
                        string Date = string.Format("{0}-{1:00}-{2:00} {3:00}:{4:00}:{5:00}", iYear, iMonth, iDay, iHour, iMinute, iSecond);
                        Info.RecordTime = DateTime.ParseExact(Date, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                        lAttInfo.Add(Info);
                    }

                    ReadCount++;
                }
            }
            else
            {
                m_axCZKEM1.GetLastError(ref idwErrorCode);

                if (idwErrorCode != 0)
                {
                    //MessageBox.Show("Reading data from terminal failed,ErrorCode: " + idwErrorCode.ToString(), "Error");
                }
                else
                {
                    //MessageBox.Show("No data from terminal returns!", "Error");
                }

                m_axCZKEM1.EnableDevice(m_daoFP.MachineNo, true);
            }

            return lAttInfo;
        }        
    }
}
