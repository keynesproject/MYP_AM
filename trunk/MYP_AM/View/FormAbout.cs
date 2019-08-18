using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MYPAM.View
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void PbLogo_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://www.myp.net.tw/");
            }
            catch
            {
                //表示沒有預設的開啟網址應程式，不予動作;//
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LnkLblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("mailto:" + lnkLblEmail.Text);
            }
            catch (Exception)
            {

            }
        }
    }
}
