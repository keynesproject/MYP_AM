using MYPAM.Model.DataAccessObject;
using MYPAM.Model.Extension;
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
        private zkemkeeper.CZKEMClass _axCZKEM1 = new zkemkeeper.CZKEMClass();

        /// <summary>
        /// 設備基本資訊
        /// </summary>
        private DaoTimeClock m_daoTC = new DaoTimeClock();

        /// <summary>
        /// 設備基本資訊
        /// </summary>
        public DaoTimeClock DeviceInfo
        {
            get { return m_daoTC; }
        }

        /// <summary>
        /// 設備是否啟動
        /// </summary>
        public bool Enable
        {
            get { return m_daoTC.Enable; }
            set { m_daoTC.Enable = value; }
        }
        
        public bool isConnected()
        {
            return m_daoTC.Connect == DaoTimeClock.eConnectState.eCON_CONNECTED ? true : false;
        }

        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="daoTC"></param>
        public MYP2000(DaoTimeClock daoTC)
        {
            m_daoTC = daoTC;
            m_daoTC.MachineNo = 1;
        }

        /// <summary>
        /// 連接設備
        /// </summary>
        public void Connect()
        {
            //這裝置不啟用，所以不予連線;//
            if (this.Enable == false)
                return;

            if (m_daoTC.IP.Trim() == "" || m_daoTC.Port.ToString().Trim() == "")
            {
                //MessageBox.Show("IP及埠號不可以為空!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                m_daoTC.Connect = DaoTimeClock.eConnectState.eCON_UNABLE;
                return;
            }            

            bool bIsConnected = _axCZKEM1.Connect_Net(m_daoTC.IP, m_daoTC.Port);
            if (bIsConnected == true)
            {
                //Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
                _axCZKEM1.RegEvent(m_daoTC.MachineNo, 65535);
            }
            else
            {
                int idwErrorCode = 0;
                _axCZKEM1.GetLastError(ref idwErrorCode);
                //MessageBox.Show(string.Format("無法連線至[{0}],錯誤代碼={1}", DeviceInfo.Name, idwErrorCode.ToString()), "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                m_daoTC.Connect = DaoTimeClock.eConnectState.eCON_UNABLE;
                return;
            }
            
            m_daoTC.Connect = DaoTimeClock.eConnectState.eCON_CONNECTED;
        }

        /// <summary>
        /// 關閉設備連線
        /// </summary>
        public void Disconnect()
        {
            _axCZKEM1.Disconnect();
            this.DeviceInfo.Connect = DaoTimeClock.eConnectState.eCON_DISCONNECT;
        }

        /// <summary>
        /// 讀取員工資訊
        /// </summary>
        /// <returns></returns>
        public List<DaoUserInfo> LoadUserInfo()
        {
            //不處於連現狀態就不予處理;//
            if (m_daoTC.Connect != DaoTimeClock.eConnectState.eCON_CONNECTED)
                return new List<DaoUserInfo>();

            int iEnrollNumber = 0;
            string sEnrollNumber = "";
            string sName = "";
            string sPassword = "";
            int iPrivilege = 0;
            bool bEnabled = false;
            string sCardNum = "";

            _axCZKEM1.EnableDevice(m_daoTC.MachineNo, false);
            //read all the user information to the memory
            _axCZKEM1.ReadAllUserID(m_daoTC.MachineNo);
            _axCZKEM1.EnableDevice(m_daoTC.MachineNo, true);

            List<DaoUserInfo> lUserInfo = new List<DaoUserInfo>();
            //get all the users' information from the memory

            //判斷舊款或新款裝置，分別讀取不同的API;//
            if (m_daoTC.Type == 0)
            {
                while (_axCZKEM1.GetAllUserInfo(
                    m_daoTC.MachineNo,
                    ref iEnrollNumber,
                    ref sName,
                    ref sPassword,
                    ref iPrivilege,
                    ref bEnabled))
                {
                    DaoUserInfo Info = new DaoUserInfo();

                    Info.UserID = iEnrollNumber;
                    Info.Name = sName;
                    _axCZKEM1.GetStrCardNumber(out sCardNum);
                    Info.CardNum = sCardNum.PadLeft(10, '0');
                    Info.Privilege = iPrivilege;
                    Info.Enable = bEnabled;

                    lUserInfo.Add(Info);
                }
            }
            else
            {
                while (_axCZKEM1.SSR_GetAllUserInfo(
                    m_daoTC.MachineNo,
                    out sEnrollNumber,
                    out sName,
                    out sPassword,
                    out iPrivilege,
                    out bEnabled))
                {
                    DaoUserInfo Info = new DaoUserInfo();

                    Info.UserID = sEnrollNumber.ToLong();
                    Info.Name = sName;
                    _axCZKEM1.GetStrCardNumber(out sCardNum);
                    Info.CardNum = sCardNum.PadLeft(10, '0');
                    Info.Privilege = iPrivilege;
                    Info.Enable = bEnabled;

                    lUserInfo.Add(Info);
                }
            }

            return lUserInfo;
        }

        private bool DeleteAllUserInfo()
        {
            if (m_daoTC.Connect != DaoTimeClock.eConnectState.eCON_CONNECTED)
                return false;

            _axCZKEM1.EnableDevice(m_daoTC.MachineNo, false);

            int idwErrorCode = 0;

            int iDataFlag = 5;

            if (_axCZKEM1.ClearData(m_daoTC.MachineNo, iDataFlag))
            {
                //the data in the device should be refreshed
                _axCZKEM1.RefreshData(m_daoTC.MachineNo);
                //MessageBox.Show("Clear all the UserInfo data!", "Success");
            }
            else
            {
                _axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }

            _axCZKEM1.EnableDevice(m_daoTC.MachineNo, true);

            return true;
        }

        public bool UploadUserInfo(List<DaoUserInfo> lUserInfo)
        {
            if (m_daoTC.Connect != DaoTimeClock.eConnectState.eCON_CONNECTED)
                return false;

            //先刪除考勤機上的人員資訊;//
            if (DeleteAllUserInfo() == false)
                return false;

            _axCZKEM1.EnableDevice(m_daoTC.MachineNo, false);

            //再上傳人員資訊;//
            foreach (DaoUserInfo userInfo in lUserInfo)
            {
                //Before you using function SetUserInfo,set the card number to make sure you can upload it to the device
                _axCZKEM1.SetStrCardNumber(userInfo.CardNum);

                //upload the user's information(card number included)
                if (_axCZKEM1.SetUserInfo(m_daoTC.MachineNo, userInfo.UserID.ToInt(), userInfo.Name, "", userInfo.Privilege, userInfo.Enable))
                {
                    //MessageBox.Show("SetUserInfo,UserID:" + userInfo.UserID.ToString() + " Privilege:" + userInfo.Privilege.ToString() + " Cardnumber:" + userInfo.CardNum + " Enabled:" + userInfo.Enable, "Success");
                }
                else
                {
                    int idwErrorCode = 0;
                    _axCZKEM1.GetLastError(ref idwErrorCode);
                    MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");

                    //the data in the device should be refreshed
                    _axCZKEM1.RefreshData(m_daoTC.MachineNo);
                    _axCZKEM1.EnableDevice(m_daoTC.MachineNo, true);
                    return false;
                }
            }

            //the data in the device should be refreshed
            _axCZKEM1.RefreshData(m_daoTC.MachineNo);
            _axCZKEM1.EnableDevice(m_daoTC.MachineNo, true);

            return true;
        }

        /// <summary>
        /// 刪除考勤紀錄
        /// </summary>
        /// <returns></returns>
        public bool DeleteAttendance()
        {
            //不處於刪除狀態就不予處理;//
            if (m_daoTC.Connect != DaoTimeClock.eConnectState.eCON_CLEAR_ATT)
                return false;

            int idwErrorCode = 0;

            _axCZKEM1.EnableDevice(m_daoTC.MachineNo, false);//disable the device
            if (_axCZKEM1.ClearGLog(m_daoTC.MachineNo))
            {
                //the data in the device should be refreshed
                _axCZKEM1.RefreshData(m_daoTC.MachineNo);
                //MessageBox.Show("All att Logs have been cleared from teiminal!", "Success");
            }
            else
            {
                _axCZKEM1.GetLastError(ref idwErrorCode);
                //MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
            
            //enable the device
            _axCZKEM1.EnableDevice(m_daoTC.MachineNo, true);

            return idwErrorCode == 0 ? true : false;
        }

        /// <summary>
        /// 取得考勤數量
        /// </summary>
        /// <returns></returns>
        public int GetAttendanceCount()
        {
            if (m_daoTC.Connect != DaoTimeClock.eConnectState.eCON_CONNECTED)
                return 0;

            int iValue = 0;

            //Here we use the function "GetDeviceStatus" to get the record's count.The parameter "Status" is 6.
            if (_axCZKEM1.GetDeviceStatus(m_daoTC.MachineNo, 6, ref iValue)) 
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
            if (m_daoTC.Connect != DaoTimeClock.eConnectState.eCON_CONNECTED )
                return lAttInfo;

            int iEnrollNumber = 0;
            string sEnrollNumber = "";
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

            _axCZKEM1.EnableDevice(m_daoTC.MachineNo, false);//disable the device

            _axCZKEM1.GetProductCode(m_daoTC.MachineNo, out sCardNum);

            if (_axCZKEM1.ReadGeneralLogData(m_daoTC.MachineNo))//read all the attendance records to the memory
            {
                //資料已讀取到本機，重新開啟設備;//
                _axCZKEM1.EnableDevice(m_daoTC.MachineNo, true);

                int ReadCount = 0;

                if(m_daoTC.Type == 0 )
                {
                    while (_axCZKEM1.GetGeneralExtLogData(
                        m_daoTC.MachineNo,
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
                            Info.Location = m_daoTC.Location;
                            string Date = string.Format("{0}-{1:00}-{2:00} {3:00}:{4:00}:{5:00}", iYear, iMonth, iDay, iHour, iMinute, iSecond);
                            Info.RecordTime = DateTime.ParseExact(Date, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                            lAttInfo.Add(Info);
                        }

                        ReadCount++;
                    }
                }
                else
                {
                    while (_axCZKEM1.SSR_GetGeneralLogData(
                            m_daoTC.MachineNo,
                            out sEnrollNumber,
                            out iVerifyMode,
                            out iInOutMode,
                            out iYear,
                            out iMonth,
                            out iDay,
                            out iHour,
                            out iMinute,
                            out iSecond,
                            ref iWorkcode))
                    {
                        if (ReadCount >= Index)
                        {
                            DaoAttendance Info = new DaoAttendance();
                            Info.UserID = sEnrollNumber.ToInt();
                            //Info.UserName;   //從Employees表格取得;//
                            //Info.CardNumber; //從Employees表格取得;//
                            Info.Location = m_daoTC.Location;
                            string Date = string.Format("{0}-{1:00}-{2:00} {3:00}:{4:00}:{5:00}", iYear, iMonth, iDay, iHour, iMinute, iSecond);
                            Info.RecordTime = DateTime.ParseExact(Date, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                            lAttInfo.Add(Info);
                        }

                        ReadCount++;
                    }
                }
            }
            else
            {
                _axCZKEM1.GetLastError(ref idwErrorCode);

                if (idwErrorCode != 0)
                {
                    //MessageBox.Show("Reading data from terminal failed,ErrorCode: " + idwErrorCode.ToString(), "Error");
                }
                else
                {
                    //MessageBox.Show("No data from terminal returns!", "Error");
                }

                _axCZKEM1.EnableDevice(m_daoTC.MachineNo, true);
            }

            return lAttInfo;
        }        
    }
}
