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
    public partial class FormDelEmployee : Form
    {
        public FormDelEmployee()
        {
            InitializeComponent();
        }

        private void BtnDel_MouseUp(object sender, MouseEventArgs e)
        {
            //先檢查欄位資訊;//
            if (string.IsNullOrEmpty(tbUserID.Text))
            {
                MessageBoxEx.Show(this, string.Format("{0} 欄位為必填!", lblUserID.Text), "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUserID.Focus();
                return;
            }

            //檢查此Serial是否存在;//
            if (DaoSQL.Instance.SearchEmployees(tbUserID.Text) == false)
            {
                MessageBoxEx.Show(this, "此員工編號不存在!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUserID.Focus();
                tbUserID.SelectAll();
                return;
            }

            //顯示是否真的要刪除此員工資訊訊息;//
            if (MessageBoxEx.Show(this, string.Format("確定要刪除員工編號 {0} ?", tbUserID.Text), "警告!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DaoErrMsg Msg = DaoSQL.Instance.DeleteEmployees(tbUserID.Text);
                if (Msg.isError == false)
                {
                    MessageBoxEx.Show(this, string.Format("已刪除員工編號 {0} ?", tbUserID.Text), "訊息!!", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
            }

            tbUserID.Focus();
            tbUserID.SelectAll();
        }

        private void BtnExit_MouseUp(object sender, MouseEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
