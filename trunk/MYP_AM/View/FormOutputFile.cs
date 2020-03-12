using MYPAM.Model.DataAccessObject;
using MYPAM.Model.Extension;
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
    public partial class FormOutputFile : Form
    {
        public FormOutputFile()
        {
            InitializeComponent();

            lblSampleShow.MaximumSize = new Size(pnlSample.Width, 0);

            ReloadSamble();
        }

        public void LoadDefault()
        {
            int IDLen, SpaceLen;
            DaoSQL.Instance.GetOutFileSetting(out IDLen, out SpaceLen);
            nudIDLen.Value = IDLen;
            nudSpaceLen.Value = SpaceLen;
        }

        private void ReloadSamble()
        {
            string strID = "ABCEDFGHIJKLMNOPQRSTUVWXYZ";

            lblSampleShow.Text = strID.Substring(0, this.nudIDLen.Value.ToInt());
            string strSpace = "";
            for (int i = 0; i < nudSpaceLen.Value.ToInt(); i++)
            {
                strSpace += "□";
            }
            lblSampleShow.Text += strSpace;
        }

        private void Nud_ValueChanged(object sender, EventArgs e)
        {
            ReloadSamble();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            DaoSQL.Instance.SaveFileSetting(nudIDLen.Value.ToInt(), nudSpaceLen.Value.ToInt());
            this.Close();
        }
    }
}
