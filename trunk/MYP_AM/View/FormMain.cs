using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using zkemkeeper;
using System.Threading;
using MYPAM.Model.DataAccessObject;
using MYPAM.View;
using MYPAM.Model.Extension;
using MYPAM.View.Component;
using MYPAM.Model.Device;
using MYPAM.Model.Log;
using System.IO;

namespace MYPAM
{
    public partial class FormMain : Form
    {
        private enum ProcessState
        {
            eINITIAL = 0,
            eCONNECT_DB,
            eSTART_DEVICE,
        }
        private ProcessState m_CurrentState = ProcessState.eINITIAL;

        private List<MYP2000> m_ConnectDevice = new List<MYP2000>();

        /// <summary>
        /// 資料讀取中旗標
        /// </summary>
        private bool m_isLoading = false;

        /// <summary>
        /// 標記時間，用來計算下次更新的時間
        /// </summary>
        private DateTime dtMark = new DateTime();

        private FormEmployee m_FormEmployees = new FormEmployee();

        private FormAttendance m_FormAtt = new FormAttendance();

        private FormEmployeeSettings m_FormEmpSet = new FormEmployeeSettings();

        public FormMain()
        {
            InitializeComponent();
            
            SetupMypSetting();            
        }
        
        private void FormMain_Load(object sender, EventArgs e)
        {
        }
        
        private void FormMain_Shown(object sender, EventArgs e)
        {
            UiFunctionSetting(ProcessState.eINITIAL);

            ReadMachineInfo();

            if (Properties.Settings.Default.AutoUpdate)
                TsBtnStartLoadDevice_MouseUp(sender, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));

#if DEBUG
            testToolStripMenuItem.Visible = true;
#endif
        }

        /// <summary>
        /// UI功能鍵啟用狀態設定
        /// </summary>
        /// <param name="isConnectDb"></param>
        private void UiFunctionSetting(ProcessState State)
        {
            Invoke((MethodInvoker)delegate
            {
                switch (State)
                {
                    case ProcessState.eINITIAL:
                        tsBtnStartLoadDevice.Enabled = true;
                        tsmiExportDeviceAttence.Enabled = false;
                        tsBtnStopLoadDevice.Enabled = false;
                        tsBtnUpdateData.Enabled = false;
                        tsBtnEnableDevice.Enabled = true;
                        tsBtnDisableDevice.Enabled = true;
                        tsBtnDelDeviceAttendance.Enabled = false;
                        tsBtnAddDevice.Enabled = true;
                        tsBtnRemoveDevice.Enabled = true;
                        tsslState.Text = string.Format("按下[{0}]開始讀取設備考勤及人員資料", tsBtnStartLoadDevice.Text);
                        tTickTime.Enabled = false;
                        tGiveTime.Enabled = false;                        
                        break;

                    case ProcessState.eCONNECT_DB:
                        tsBtnStartLoadDevice.Enabled = true;
                        tsmiExportDeviceAttence.Enabled = false;
                        tsBtnStopLoadDevice.Enabled = false;
                        tsBtnUpdateData.Enabled = false;
                        tsBtnEnableDevice.Enabled = true;
                        tsBtnDisableDevice.Enabled = true;
                        tsBtnDelDeviceAttendance.Enabled = false;
                        tsBtnAddDevice.Enabled = true;
                        tsBtnRemoveDevice.Enabled = true;
                        tsslState.Text = string.Format("按下[{0}]開始讀取設備考勤及人員資料", tsBtnStartLoadDevice.Text);
                        tTickTime.Enabled = false;
                        tGiveTime.Enabled = false;                        
                        break;

                    case ProcessState.eSTART_DEVICE:
                        tsBtnEnableDevice.Enabled = tsBtnDisableDevice.Enabled = false;
                        tsBtnAddDevice.Enabled = tsBtnRemoveDevice.Enabled = false;
                        tsBtnStartLoadDevice.Enabled = false;
                        tsmiExportDeviceAttence.Enabled = true;
                        tsBtnStopLoadDevice.Enabled = true;
                        tsBtnDelDeviceAttendance.Enabled = true;
                        tsBtnUpdateData.Enabled = true;
                        
                        tsslState.Text = "";
                        //紀錄現在時間，並啟動定時更新資料計時器;//
                        dtMark = DateTime.Now;

                        if(Properties.Settings.Default.UpdateAttMethod == 0)
                        {
                            //開啟間隔更新;//
                            dtMark = DateTime.Now;
                            tTickTime.Enabled = true;
                        }
                        else
                        {
                            //開啟指定時間更新;//
                            tGiveTime.Enabled = true;
                        }                       
                        
                        break;

                    default:
                        break;
                }

                //紀錄現在狀態
                m_CurrentState = State;
            });
        }

        /// <summary>
        /// 讀取設備列表資訊
        /// </summary>
        private void ReadMachineInfo()
        {
            int SelectIndex = dgvDevice.SelectedRows.Count <= 0 ? 0 : dgvDevice.SelectedRows[0].Index;

            List<DaoTimeClock> TimeClock = DaoSQL.Instance.GetMachineInfo();

            m_ConnectDevice.Clear();
            foreach(DaoTimeClock daoFP in TimeClock)
            {
                m_ConnectDevice.Add(new MYP2000(daoFP));
            }

            this.dgvDevice.DataSource = TimeClock;

            if (dgvDevice.SelectedRows.Count <= 0)
                return;

            if (SelectIndex >= dgvDevice.Rows.Count)
                SelectIndex = dgvDevice.Rows.Count - 1;
            else if (dgvDevice.Rows.Count <= 1)
                SelectIndex = 0;

            dgvDevice.Rows[SelectIndex].Selected = true;            
        }
        
        /// <summary>
        /// 開啟設定功能畫面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiOption_Click(object sender, EventArgs e)
        {
            if (m_CurrentState == ProcessState.eINITIAL || m_CurrentState == ProcessState.eCONNECT_DB)
            {
                FormOption Option = new FormOption();
                Option.ShowDialog();
            }
            else
            {
                MessageBoxEx.Show(this, "設備連線時無法進行功能設定!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        #region 應用程式關閉功能

        /// <summary>
        /// 應用程式關閉
        /// </summary>
        private void ApplicationClose()
        {
            DaoSQL.Instance.CloseDatabase();

            this.Close();
        }

        /// <summary>
        /// 主選單離開按鈕按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiExit_Click(object sender, EventArgs e)
        {
            ApplicationClose();
        }

        /// <summary>
        /// 退出系統圖示按鈕放開事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtnExit_MouseUp(object sender, MouseEventArgs e)
        {
            ApplicationClose();
        }
        
        #endregion 應用程式關閉功能

        #region MYP設定功能
        
        /// <summary>
        /// 開啟或關閉MYP設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiMYP_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.IsOpenMypSetting == false)
            {
                //表示要開啟MYP輸入密碼視窗;//
                FormMypPW FormPW = new FormMypPW();
                DialogResult Ret = FormPW.ShowDialog();
                if (Ret == DialogResult.OK)
                    Properties.Settings.Default.IsOpenMypSetting = true;
                else
                    return;
            }
            else
            {
                //表示要關閉MYP設定;//
                Properties.Settings.Default.IsOpenMypSetting = false;
            }

            //設定MYP設定樣式;//
            SetupMypSetting();
            Properties.Settings.Default.Save();
        }

        private void SetupMypSetting()
        {
            if(Properties.Settings.Default.IsOpenMypSetting == true)
            {
                tsmiMYP.Text = "關閉MYP設定";
                tsmiOutFormat.Visible = true;
                tsBtnAddDevice.Visible = true;
                tsBtnRemoveDevice.Visible = true;
                tsBtnEditDevice.Visible = true;
                tsSeparator4.Visible = true;
            }
            else
            {
                tsmiMYP.Text = "MYP設定";
                tsmiOutFormat.Visible = false;
                tsBtnAddDevice.Visible = false;
                tsBtnRemoveDevice.Visible = false;
                tsBtnEditDevice.Visible = false;
                tsSeparator4.Visible = false;
            }
        }

        /// <summary>
        /// 新增設備按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtnAddDevice_MouseUp(object sender, MouseEventArgs e)
        {
            FormTimeClock FormTC = new FormTimeClock();
            if (FormTC.ShowDialog() == DialogResult.Yes)
                ReadMachineInfo();
        }

        /// <summary>
        /// 編輯設備按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtnEditDevice_MouseUp(object sender, MouseEventArgs e)
        {
            //判斷是否有選擇設備;//
            if (dgvDevice.SelectedRows.Count <= 0)
            {
                MessageBoxEx.Show(this, "請先選擇設備!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FormTimeClock FormTC = new FormTimeClock();
            FormTC.LoadDevice(dgvDevice.SelectedRows[0].Cells["columnID"].Value.ToInt());
            if (FormTC.ShowDialog() == DialogResult.Yes)
                ReadMachineInfo();
        }

        /// <summary>
        /// 移除設備按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtnRemoveDevice_MouseUp(object sender, MouseEventArgs e)
        {
            if (dgvDevice.SelectedRows.Count <= 0)
            {
                MessageBoxEx.Show(this, "請先選擇設備!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string DeviceName = dgvDevice.Rows[dgvDevice.SelectedRows[0].Index].Cells["columnName"].Value.ToString();
            DialogResult Ret = MessageBoxEx.Show(this, string.Format("是否要刪除設備[{0}]?", DeviceName), "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(Ret == DialogResult.Yes)
            {
                //取得選取列的ID資訊;//
                int ID = dgvDevice.Rows[dgvDevice.SelectedRows[0].Index].Cells["columnID"].Value.ToInt();                
                DaoErrMsg Msg = DaoSQL.Instance.DeleteMachine(ID);
                if (Msg.isError == false)
                {
                    MessageBoxEx.Show(this, string.Format("[{0}]已刪除!", DeviceName), "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReadMachineInfo();
                }
                else
                {
                    MessageBoxEx.Show(this, string.Format("無法刪除[{0}]!\r\n{1}", DeviceName, Msg.ErrorMsg), "訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion MYP設定功能

        #region 啟用/停用設備

        /// <summary>
        /// 啟用設備 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtnEnableDevice_MouseUp(object sender, MouseEventArgs e)
        {
            OnOffMachine(true);
        }

        /// <summary>
        /// 停用設備
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtnDisableDevice_MouseUp(object sender, MouseEventArgs e)
        {
            OnOffMachine(false);
        }

        private void OnOffMachine(bool isEnable)
        {
            if (dgvDevice.SelectedRows.Count <= 0)
            {
                MessageBoxEx.Show(this, "請先選擇設備!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int ID = dgvDevice.Rows[dgvDevice.SelectedRows[0].Index].Cells["columnID"].Value.ToInt();
            foreach (var Device in m_ConnectDevice)
            {                
                if (Device.DeviceInfo.ID == ID)
                {
                    DaoErrMsg Msg = DaoSQL.Instance.OnOffMachine(ID, isEnable);
                    if (Msg.isError == false)
                    {
                        Device.Enable = isEnable;
                    }
                    else
                    {
                        MessageBoxEx.Show(this, string.Format("無法{0}[{1}]!\r\n{2}", isEnable == true ? "啟用" : "停用", Device.DeviceInfo.Name, Msg.ErrorMsg), "訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                }
            }

            dgvDevice.Refresh();
        }

        #endregion 啟用/停用設備

        /// <summary>
        /// 刪除設備出勤紀錄
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtnDelDeviceAttendance_MouseUp(object sender, MouseEventArgs e)
        {
            bool hadAttInfoDel = false;
            FormDeleteAttendance FormDA = new FormDeleteAttendance();
            DialogResult Ret = FormDA.ShowDialog();
            if (Ret != DialogResult.OK)
                return;
            //進行考勤資料刪除;//
            this.Cursor = Cursors.AppStarting;

            foreach (MYP2000 device in m_ConnectDevice)
            {
                //若設備尚未連線，則進行連線;//
                bool bLastConnectState = true;
                if (device.DeviceInfo.Connect != DaoTimeClock.eConnectState.eCON_CONNECTED)
                {
                    bLastConnectState = false;
                    device.Connect();
                }

                if (device.DeviceInfo.Connect == DaoTimeClock.eConnectState.eCON_CONNECTED)
                {
                    device.DeviceInfo.Connect = DaoTimeClock.eConnectState.eCON_CLEAR_ATT;
                    dgvDevice.Refresh();
                    if (device.DeleteAttendance() == true)
                        hadAttInfoDel = true;

                    if (bLastConnectState == false)
                        device.Disconnect();
                    else
                        device.DeviceInfo.Connect = DaoTimeClock.eConnectState.eCON_CONNECTED;

                    dgvDevice.Refresh();
                }
            }
            this.Cursor = Cursors.Default;

            if (hadAttInfoDel == true)
                MessageBoxEx.Show(this, "設備的考勤資料已全數刪除", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBoxEx.Show(this, "設備無考勤資料刪除。\r\n!!注意 : 設備必須為[已連線]且[啟用]的狀態下，才會進行考勤資料刪除。", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 開始連線讀取訊息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtnStartLoadDevice_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.AppStarting;

            foreach(MYP2000 device in m_ConnectDevice)
            {
                device.Connect();
                dgvDevice.Refresh();  
            }
            
            this.UiFunctionSetting(ProcessState.eSTART_DEVICE);

            //只要是重新連線的第一次都重新讀取設備資訊到資料庫;//
            UpdateAttAndUser();

            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// 停止連線讀取訊息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtnStopLoadDevice_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.AppStarting;

            foreach (MYP2000 device in m_ConnectDevice)
            {
                device.Disconnect();
                dgvDevice.Refresh();
            }
            
            this.UiFunctionSetting(ProcessState.eCONNECT_DB);            

            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// 立即更新資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtnUpdateData_MouseUp(object sender, MouseEventArgs e)
        {
            if (m_isLoading == true)
            {
                MessageBoxEx.Show(this, "設備資料讀取中，請稍後..", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            UpdateAttAndUser();

            MessageBoxEx.Show(this, "員工及考勤資料更新完成!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 更新考勤及使用者資訊
        /// </summary>
        private void UpdateAttAndUser()
        {
            m_isLoading = true;

            Invoke((MethodInvoker)delegate
            {
                tsBtnUpdateData.Enabled = false;
                tsBtnStopLoadDevice.Enabled = false;

                tsslState.Text = "設備資料讀取中....";
                ssStatus.Refresh();

                this.Cursor = Cursors.AppStarting;

                int UpdateAttNum = 0;
                foreach (MYP2000 device in m_ConnectDevice)
                {
                    //讀取員工資訊;//
                    List<DaoUserInfo> UserInfo = device.LoadUserInfo();
                    if (UserInfo.Count > 0)
                    {
                        DaoSQL.Instance.SetEmployees(UserInfo);
                    }

                    //取得已讀取過的考勤數量;//
                    int ReadIndex = DaoSQL.Instance.GetReadAttendanceNum(device.DeviceInfo.ID.ToInt());

                    //設備現有的考勤數量;//
                    int fpAttNum = device.GetAttendanceCount();
                    if (ReadIndex > fpAttNum)
                    {
                        ReadIndex = 0;
                        DaoSQL.Instance.ResetReadAttendanceNum(device.DeviceInfo.ID.ToInt());
                    }

                    //讀取設備考勤資訊;//
                    List<DaoAttendance> AttInfo = device.LoadAttendance(ReadIndex);
                    if (AttInfo.Count > 0)
                    {
                        DaoSQL.Instance.SetAttendance(device.DeviceInfo.ID.ToInt(), AttInfo);
                        ExportAttendanceToTxt(AttInfo);
                    }

                    //記錄現有考勤數量;//
                    device.DeviceInfo.AttendanceCount = fpAttNum;
                    UpdateAttNum += AttInfo.Count;

                    //更新員工及考勤畫面;//
                    m_FormAtt.ReLoad();
                    m_FormEmployees.ReLoad();

                    dgvDevice.Refresh();
                }
                this.Cursor = Cursors.Default;
                tsslState.Text = string.Format("共更新 {0} 筆考勤資料.", UpdateAttNum);

                tsBtnStopLoadDevice.Enabled = true;
                tsBtnUpdateData.Enabled = true;
            });
            m_isLoading = false;
        }

        /// <summary>
        /// 輸出考勤資訊到文字檔
        /// </summary>
        /// <param name="attInfo"></param>
        private void ExportAttendanceToTxt(List<DaoAttendance> attInfo, bool isHistory = false)
        {
            string FileName = DaoConfigFile.Instance.DirAttExport + "/";

            if (isHistory == false)
                FileName = FileName + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";
            else
                FileName = FileName + "History_" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";
            FileStream fs = new FileStream(FileName, FileMode.Append);

            StreamWriter sw = new StreamWriter(fs);

            //取得匯出檔案的格式;//
            DataTable dt = DaoSQL.Instance.GetOutFileSetting();
            eOutputType outType = (eOutputType)dt.Rows[0]["Type"].ToInt();
            int outLen = dt.Rows[0]["Length"].ToInt();

            List<OutputFormat> fmt = new List<OutputFormat>();
            for (int i=1; i<7; i++)
            {
                fmt.Add(new OutputFormat(eOutputType.eString, dt.Rows[i]["Length"].ToInt(), dt.Rows[i]["Contex"].ToString()));
            }

            StringBuilder sb = new StringBuilder();
            foreach (DaoAttendance att in attInfo)
            {
                try
                {
                    sb.Init();

                    string type = outType == eOutputType.eEmployeeID ? att.sUserID : att.CardNum;
                    if (outLen <= type.Length)
                    {
                        type = type.Substring(type.Length - outLen, outLen);
                    }
                    else
                    {
                        type = type.PadLeft(outLen, '0');
                    }

                    sb.AppendFormat("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}\r\n",
                        //outType == eOutputType.eEmployeeID ? att.sUserID.PadLeft(outLen, '0') : att.CardNum.PadLeft(outLen, '0'),
                        type,
                        fmt[0].contex.PadLeft(fmt[0].length, ' '), //1:str1
                        att.RecordTime.ToString("yyyy"),           //2:year
                        fmt[1].contex.PadLeft(fmt[1].length, ' '), //3:str2
                        att.RecordTime.ToString("MM"),             //4:mounth
                        fmt[2].contex.PadLeft(fmt[2].length, ' '), //5:str3
                        att.RecordTime.ToString("dd"),             //6:day
                        fmt[3].contex.PadLeft(fmt[3].length, ' '), //7:str4
                        att.RecordTime.ToString("HH"),             //8:hour
                        fmt[4].contex.PadLeft(fmt[4].length, ' '), //9:str5
                        att.RecordTime.ToString("mm"),             //10:minute
                        fmt[5].contex.PadLeft(fmt[5].length, ' '), //11:str6
                        att.Location                               //12:location
                        );
                    sw.Write(sb);
                }
                catch (Exception ex)
                {
                    Logger.Debug(ex.Message);
                    Logger.Debug(string.Format("fmt Count:{0}", fmt));
                    Logger.Debug(string.Format("outType:{0}", outType.ToString()));
                    Logger.Debug(string.Format("UserID:{0}", att.sUserID));
                    Logger.Debug(string.Format("CardNum:{0}", att.CardNum));
                    Logger.Debug(string.Format("fmt[0]:{0}", fmt[0].contex));
                    Logger.Debug(string.Format("fmt[1]:{0}", fmt[1].contex));
                    Logger.Debug(string.Format("fmt[2]:{0}", fmt[2].contex));
                    Logger.Debug(string.Format("fmt[3]:{0}", fmt[3].contex));
                    Logger.Debug(string.Format("fmt[4]:{0}", fmt[4].contex));
                    Logger.Debug(string.Format("fmt[5]:{0}", fmt[5].contex));
                }
            }

            //清空緩衝區
            sw.Flush();
            //關閉流
            sw.Close();
            fs.Close();
        }

        /// <summary>
        /// 匯出歷史考勤資訊
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiExportHistoryAttence_Click(object sender, EventArgs e)
        {
            if (tsmiExportDeviceAttence.Enabled == false)
                return;

            List<DaoAttendance> TotalAttInfo = new List<DaoAttendance>();
            foreach (MYP2000 device in m_ConnectDevice)
            {
                //讀取設備考勤資訊;//
                List<DaoAttendance> AttInfo = device.LoadAttendance();
                if (AttInfo.Count > 0)
                {
                    foreach (DaoAttendance att in AttInfo)
                        TotalAttInfo.Add(att);
                }
            }
            
            if (TotalAttInfo.Count > 0)
            {
                ExportAttendanceToTxt(TotalAttInfo, true);
                MessageBoxEx.Show(this, string.Format("共匯出[{0}]筆考勤資訊.", TotalAttInfo.Count), "匯出考勤資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show(this, "設備無任何考勤資訊.", "匯出考勤資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 時鐘顯示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TClock_Tick(object sender, EventArgs e)
        {
            tsslTime.Text = DateTime.Now.ToString("tt HH:mm:ss");
        }

        /// <summary>
        /// 指定時間更新計時器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TGiveTime_Tick(object sender, EventArgs e)
        {
            if (   DateTime.Now.Hour == Properties.Settings.Default.DataUpdateMorning.Hour
                && DateTime.Now.Minute == Properties.Settings.Default.DataUpdateMorning.Minute)
            {
                //等待讀取資料結束;//
                while(m_isLoading)
                {
                    Thread.Sleep(1000);
                }
                UpdateAttAndUser();
            }
            else if(   DateTime.Now.Hour == Properties.Settings.Default.DataUpdateAfternoon.Hour
                    && DateTime.Now.Minute == Properties.Settings.Default.DataUpdateAfternoon.Minute)
            {
                //等待讀取資料結束;//
                while (m_isLoading)
                {
                    Thread.Sleep(1000);
                }
                UpdateAttAndUser();
            }
            //else
            //{
            //    //等待讀取資料結束;//
            //    while (m_isLoading)
            //    {
            //        Thread.Sleep(1000);
            //    }
            //    UpdateAttAndUser();
            //}
        }

        /// <summary>
        /// 定時更新計時器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tTickTime_Tick(object sender, EventArgs e)
        {
            if (m_isLoading == true)
                return;

            int SubMinute = Properties.Settings.Default.UpdateAttTimeTickMinute - (DateTime.Now - dtMark).Minutes;
            tsslState.Text = string.Format("再過{0}分鐘進行考勤機的資料下載.", SubMinute <= 0 ? 1 : SubMinute);

            //進行讀取指紋機考勤;//
            if (SubMinute <= 0)
            {
                UpdateAttAndUser();
                dtMark = DateTime.Now;
            }
        }

        private void TsBtnEmployee_MouseUp(object sender, MouseEventArgs e)
        {
            //m_FormEmployees.Show();
            //m_FormEmployees.Select();
            m_FormEmpSet.Setup(m_ConnectDevice);
            m_FormEmpSet.ShowDialog();
        }

        private void TsbtnAttendance_MouseUp(object sender, MouseEventArgs e)
        {
            m_FormAtt.Show();
            m_FormAtt.Select();
        }

        /// <summary>
        /// 關於按鍵按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsbtnAbout_MouseUp(object sender, MouseEventArgs e)
        {
            FormAbout About = new FormAbout();
            About.ShowDialog();
        }

        /// <summary>
        /// 顯示輸出格式視窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiOutFormat_Click(object sender, EventArgs e)
        {
            FormOutputFile of = new FormOutputFile();
            of.LoadDefault();
            of.ShowDialog();
        }

        private void TestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<DaoAttendance> TotalAttInfo = new List<DaoAttendance>();

            DaoAttendance temp = new DaoAttendance();
            temp.UserID = 323456;
            temp.UserName = "AAAA";
            temp.CardNum = "223456";
            temp.Location = "門口";
            temp.RecordTime = DateTime.Now;
            TotalAttInfo.Add(temp);

            ExportAttendanceToTxt(TotalAttInfo, true);
        }
    }
}
