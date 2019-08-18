using MYPAM.Model.DataAccessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MYPAM.View
{
    public partial class FormAttendance : Form
    {
        /// <summary>
        /// 顯示資料的Data Gride View
        /// </summary>
        private DataGridView m_dgvAttendance;
        public FormAttendance()
        {
            InitializeComponent();

            m_dgvAttendance = pdgAttendance.DataList;

            m_dgvAttendance.RowHeadersVisible = false;
            m_dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            m_dgvAttendance.AllowUserToAddRows = false;
            m_dgvAttendance.AllowUserToDeleteRows = false;
            m_dgvAttendance.MultiSelect = false;
            m_dgvAttendance.ReadOnly = true;
            m_dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            m_dgvAttendance.TabStop = false;

            cbMonitor.DataBindings.Add("Checked", Properties.Settings.Default, "MonitorFingerPrint");            
        }

        /// <summary>
        /// 更新資料
        /// </summary>
        public void ReLoad()
        {
            //當視窗有顯示及啟動即時監視功能時才更新資料;//
            if (this.Visible == true
                && Properties.Settings.Default.MonitorFingerPrint == true)
                LoadAttendance();
        }

        private void PdgAttendance_ChangePage(int Page)
        {
            this.LoadAttendance(Page);
        }
        private void LoadAttendance(int LoadPage = 1)
        {
            //暫停顯示Scroll BAR，待資料整理完再一次顯示;//
            m_dgvAttendance.ScrollBars = ScrollBars.None;

            //取得員工的總筆數後計算總頁數;//
            int AttNum = DaoSQL.Instance.GetAttNum();
            int TotalPage = AttNum % pdgAttendance.DisplayDataNumPerPage == 0 ? AttNum / pdgAttendance.DisplayDataNumPerPage : ((AttNum / pdgAttendance.DisplayDataNumPerPage) + 1);
            TotalPage = TotalPage == 0 ? 1 : TotalPage;
            pdgAttendance.SetTotalPage(TotalPage);

            if (LoadPage <= 0)
                LoadPage = 1;
            else if (LoadPage >= TotalPage)
                LoadPage = TotalPage;

            //設定資料;//
            int FromNo = (pdgAttendance.DisplayDataNumPerPage * (LoadPage - 1));
            int EndNo = pdgAttendance.DisplayDataNumPerPage * LoadPage;
            pdgAttendance.BindingData(DaoSQL.Instance.GetAtt(FromNo, EndNo), LoadPage);

            //最後一個欄位設定為FILL;//
            m_dgvAttendance.Columns[m_dgvAttendance.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if(m_dgvAttendance.Columns.Contains("打卡時間"))
            {
                m_dgvAttendance.Columns["打卡時間"].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";
            }

            lblInfo.Text = string.Format("● 每頁顯示 500 筆員工考勤資訊, 共有 {0} 筆員工考勤資訊", AttNum);

            m_dgvAttendance.ScrollBars = ScrollBars.Both;
        }

        private void CbMonitor_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MonitorFingerPrint = cbMonitor.Checked;
            Properties.Settings.Default.Save();
        }

        private void FormAttendance_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void FormAttendance_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
                LoadAttendance();
        }
    }
}
