using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MYPAM.Model.Extension;
using TextMessage.View.EventHandlers;

namespace TextMessage.View.Components
{
    /// <summary>
    /// 有換頁介面的DataGridView，當有換頁按鈕按下時，會通知外部說需要更新資料，
    /// 再由外部塞入指定的資料進來，本身並不記錄任何資料
    /// </summary>
    public partial class PageDataGridView : UserControl
    {
        #region 委派 delegate 事件

        /// <summary>
        /// 頁數切換更動通知Delegate
        /// </summary>
        /// <param name="Page">現在的頁數</param>
        /// <param name="PerPageDataNum">每頁顯示的資料數量上限</param>
        public delegate void ChangePageDelegate(int Page);

        /// <summary>
        /// 頁數切換更動通知事件
        /// </summary>
        public event ChangePageDelegate ChangePage;

        #endregion

        /// <summary>
        /// 設定總頁數
        /// </summary>
        private int m_TotalPage = 1;

        /// <summary>
        /// 現在所在的頁數
        /// </summary>
        private int m_CurrentPage = 1;

        /// <summary>
        /// 每頁所要顯示的資料數量
        /// </summary>
        private int m_DisplayDataNumPerPage = 100;

        /// <summary>
        /// 取得每頁顯示的數量
        /// </summary>
        public int DisplayDataNumPerPage
        {
            get { return m_DisplayDataNumPerPage; }
            private set { m_DisplayDataNumPerPage = value; }
        }

        /// <summary>
        /// 取得顯示列表
        /// </summary>
        public DataGridView DataList
        {
            get { return this.dgvData; }
        }

        /// <summary>
        /// 建構式
        /// </summary>
        public PageDataGridView()
        {
            InitializeComponent();
            
            tbCurrentPage.KeyPress += KeyEventHandlers.KeyNumOnly;
        }
        
        private void PageDataGridView_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 設定總頁數
        /// </summary>
        /// <param name="TotalPage"></param>
        public void SetTotalPage(int TotalPage)
        {
            if (TotalPage <= 0)
                TotalPage = 1;

            m_TotalPage = TotalPage;
            
            lblTotalPage.Text = "of  " + TotalPage;

            if (m_TotalPage == 1)
            {
                btnArrowFirst.Visible = false;
                btnArrowLeft.Visible = false;
                btnArrowRight.Visible = false;
                btnArrowLast.Visible = false;
                btnArrowFirst.Enabled = false;
                btnArrowLeft.Enabled = false;
                btnArrowRight.Enabled = false;
                btnArrowLast.Enabled = false;
                btnArrowFirst.Visible = true;
                btnArrowLeft.Visible = true;
                btnArrowRight.Visible = true;
                btnArrowLast.Visible = true;
            }                
        }

        /// <summary>
        /// 切換頁數
        /// </summary>
        /// <param name="CurrentPage"></param>
        private void SetCurrentPage(int CurrentPage, bool isNotify = true)
        {
            //先隱藏按鍵，等設定完狀態後在顯示，為了防止畫面閃爍用的;//
            btnArrowFirst.Visible = false;
            btnArrowLeft.Visible = false;
            btnArrowRight.Visible = false;
            btnArrowLast.Visible = false;

            if (m_TotalPage == 1)
            {
                m_CurrentPage = 1;

                btnArrowFirst.Enabled = false;
                btnArrowLeft.Enabled = false;
                btnArrowRight.Enabled = false;
                btnArrowLast.Enabled = false;
            }
            else if (CurrentPage >= m_TotalPage)
            {
                //表示切換至最後一頁;//
                m_CurrentPage = m_TotalPage;

                //關閉最後一頁及下一頁按鈕;//
                btnArrowFirst.Enabled = true;
                btnArrowLeft.Enabled = true;
                btnArrowRight.Enabled = false;
                btnArrowLast.Enabled = false;
            }
            else if (CurrentPage <= 1)
            {
                //表示切換至第一頁;//
                m_CurrentPage = 1;

                //關閉第一頁及前一頁按鈕;//
                btnArrowFirst.Enabled = false;
                btnArrowLeft.Enabled = false;
                btnArrowRight.Enabled = true;
                btnArrowLast.Enabled = true;
            }
            else
            {
                //表示切換到中間的頁數;//
                m_CurrentPage = CurrentPage;

                btnArrowFirst.Enabled = true;
                btnArrowLeft.Enabled = true;
                btnArrowRight.Enabled = true;
                btnArrowLast.Enabled = true;
            }

            //切換頁數通知;//
            if (isNotify == true)
            {
                ChangePage?.Invoke(m_CurrentPage);
            }

            //顯示現在的頁數;//
            tbCurrentPage.Text = m_CurrentPage.ToString();

            //按鍵設定完狀態後顯示，為了防止畫面閃爍用的;//
            btnArrowFirst.Visible = true;
            btnArrowLeft.Visible = true;
            btnArrowRight.Visible = true;
            btnArrowLast.Visible = true;
        }

        /// <summary>
        /// 榜定要顯示的資料
        /// </summary>
        /// <param name="Dt"></param>
        public void BindingData(DataTable Dt, int Page)
        {
            if (Dt.Rows.Count >= m_DisplayDataNumPerPage)
            {
                DataTable DisplayData = Dt.Clone();
                for (int i = 0; i < m_DisplayDataNumPerPage; i++)
                {
                    DisplayData.ImportRow(Dt.Rows[i]);
                }

                this.dgvData.DataSource = DisplayData;
            }
            else
            {
                //將資料榜定到Data Grid顯示;//
                this.dgvData.DataSource = Dt;
            }

            this.SetCurrentPage(Page, false);
        }

        /// <summary>
        /// 切換至第一頁按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArrowFirst_MouseUp(object sender, MouseEventArgs e)
        {
            this.SetCurrentPage(1);
        }

        /// <summary>
        /// 前一頁按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArrowLeft_MouseUp(object sender, MouseEventArgs e)
        {
            this.SetCurrentPage(m_CurrentPage - 1);
        }

        /// <summary>
        /// 下一頁按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArrowRight_MouseUp(object sender, MouseEventArgs e)
        {
            this.SetCurrentPage(m_CurrentPage + 1);
        }

        /// <summary>
        /// 最後一頁按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArrowLast_MouseUp(object sender, MouseEventArgs e)
        {
            this.SetCurrentPage(m_TotalPage);
        }

        /// <summary>
        /// 頁數TEXT BOX按鍵按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCurrentPage_KeyDown(object sender, KeyEventArgs e)
        {
            //判斷是否是Enter;//
            if (e.KeyCode == Keys.Enter)
            {
                //切換至指定頁數;//
                this.SetCurrentPage(tbCurrentPage.Text.ToInt());

                tbCurrentPage.SelectAll();
            }
        }

        /// <summary>
        /// 頁數TEXT BOX焦點離開事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCurrentPage_Leave(object sender, EventArgs e)
        {
            if (m_CurrentPage != tbCurrentPage.Text.ToInt())
            {
                //切換至指定頁數;//
                this.SetCurrentPage(tbCurrentPage.Text.ToInt());
            }
        }
    }
}
