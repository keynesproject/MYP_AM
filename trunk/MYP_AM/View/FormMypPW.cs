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
    public partial class FormMypPW : Form
    {
        public FormMypPW()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if(tbPW.Text.Equals(Properties.Resources.PW_MYP_SETTING))
            {
                //輸入密碼成功;//
                MessageBoxEx.Show(this, "密碼正確，開啟MYP設定功能", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //輸入密碼失敗;//
                MessageBoxEx.Show(this, "密碼錯誤", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPW.Focus();
                tbPW.SelectAll();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void TbPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                this.BtnOK_Click(sender, e);
            }
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
