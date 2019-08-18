using MYPAM.Model.DataAccessObject;
using MYPAM.View.Component;
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
    public partial class FormEmployee : Form
    {
        /// <summary>
        /// 顯示資料的Data Gride View
        /// </summary>
        private DataGridView m_dgvEmployees;

        public FormEmployee()
        {
            InitializeComponent();

            m_dgvEmployees = pdgEmployees.DataList;
            m_dgvEmployees.MouseDown += this.dgvEmployees_MouseDown;

            m_dgvEmployees.RowHeadersVisible = false;
            m_dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            m_dgvEmployees.AllowUserToAddRows = false;
            m_dgvEmployees.AllowUserToDeleteRows = false;
            m_dgvEmployees.MultiSelect = false;
            m_dgvEmployees.ReadOnly = true;
            m_dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            m_dgvEmployees.TabStop = false;

            cbMonitor.DataBindings.Add("Checked", Properties.Settings.Default, "MonitorFingerPrint");
        }

        /// <summary>
        /// 更新資料
        /// </summary>
        public void ReLoad()
        {
            //當視窗有顯示及啟動即時監視功能時才更新資料;//
            if(    this.Visible ==true 
                && Properties.Settings.Default.MonitorFingerPrint == true)
            LoadEmployees();
        }

        private void PdgEmployees_ChangePage(int Page)
        {
            this.LoadEmployees(Page);
        }

        private void LoadEmployees(int LoadPage = 1)
        {
            //暫停顯示Scroll BAR，待資料整理完再一次顯示;//
            m_dgvEmployees.ScrollBars = ScrollBars.None;

            //取得員工的總筆數後計算總頁數;//
            int EmployeesNum = DaoSQL.Instance.GetEmployeesNum();
            int TotalPage = EmployeesNum % pdgEmployees.DisplayDataNumPerPage == 0 ? EmployeesNum / pdgEmployees.DisplayDataNumPerPage : ((EmployeesNum / pdgEmployees.DisplayDataNumPerPage) + 1);
            TotalPage = TotalPage == 0 ? 1 : TotalPage;
            pdgEmployees.SetTotalPage(TotalPage);

            if (LoadPage <= 0)
                LoadPage = 1;
            else if (LoadPage >= TotalPage)
                LoadPage = TotalPage;

            //設定資料;//
            int FromNo = (pdgEmployees.DisplayDataNumPerPage * (LoadPage - 1));
            int EndNo = pdgEmployees.DisplayDataNumPerPage * LoadPage;
            pdgEmployees.BindingData(DaoSQL.Instance.GetEmployees(FromNo, EndNo), LoadPage);

            //最後一個欄位設定為FILL;//
            m_dgvEmployees.Columns[m_dgvEmployees.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (m_dgvEmployees.Columns.Contains("建立時間"))
            {
                m_dgvEmployees.Columns["建立時間"].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";
            }

            lblInfo.Text = string.Format("● 每頁顯示 500 筆員工資訊, 共有 {0} 筆員工資訊", EmployeesNum);

            m_dgvEmployees.ScrollBars = ScrollBars.Both;
        }

        private void CbMonitor_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MonitorFingerPrint = cbMonitor.Checked;
            Properties.Settings.Default.Save();
        }

        private void FormEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void FormEmployee_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
                LoadEmployees();
        }

        private void dgvEmployees_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            DataGridView dgv = sender as DataGridView;
            ShowMenu(dgv, e);
        }

        private void ShowMenu(DataGridView dgv, MouseEventArgs args)
        {
            // 取得 RowIndex 
            // 方法 1：透過 HitTest()
            int RowIndex = dgv.HitTest(args.X, args.Y).RowIndex;
            // 方法 2：CurrentRow
            //int RowIndex = dgv.CurrentRow.Index;
            if (RowIndex < 0)
                return;

            dgv.CurrentCell = dgv.Rows[RowIndex].Cells[0];

            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem item = new ToolStripMenuItem("删除員工資料");
            item.Click += (sender, e) =>
            {
                string UserID = dgv.Rows[RowIndex].Cells["員工編號"].Value.ToString();
                
                if (MessageBoxEx.Show(this, string.Format("確定要刪除員工編號 {0} ?", UserID), "警告!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DaoErrMsg Msg = DaoSQL.Instance.DeleteEmployees(UserID);
                    if (Msg.isError == false)
                    {
                        dgv.Rows.RemoveAt(RowIndex);
                        MessageBoxEx.Show(this, string.Format("已刪除員工編號 {0} ?", UserID), "訊息!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }                
            };
            menu.Items.Add(item);

            // 四種指定 ContextMenuStrip 位置方式
            // 方法 1
            menu.Show(dgv, new Point(args.X, args.Y));
            // 方法 2
            //menu.Show(dgv, args.Location);
            // 方法 3
            //menu.Show(Cursor.Position);
            // 方法 4：DataGridView 也有 PointToClient() 可以使用
            //menu.Show(dgv, dgv.PointToClient(Cursor.Position));
        }

        private void TsmiDelEmployee_Click(object sender, EventArgs e)
        {
            FormDelEmployee FormDel = new FormDelEmployee();
            FormDel.ShowDialog();

            LoadEmployees();
        }
    }
}
