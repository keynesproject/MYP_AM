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
    public partial class FormDeleteAttendance : Form
    {
        public FormDeleteAttendance()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if(!tbConfirm.Text.Equals("Delete"))
            {
                MessageBoxEx.Show(this, "請輸入驗證碼Delete後,\r\n才能進行考勤資料刪除!", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbConfirm.Focus();
                tbConfirm.SelectAll();
                return;
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TbConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                this.BtnOK_Click(sender, e);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Control成為焦點事件，全選字串
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Control_Enter(object sender, EventArgs e)
        {
            TextBox TB = sender as TextBox;
            TB.SelectAll();
        }
    }
}
