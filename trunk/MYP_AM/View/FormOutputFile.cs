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

            ResetTextboxLength();

            ReloadSamble();
        }

        public void LoadDefault()
        {
            //先讀取Default的數值;//
            nudLenEmployeeID.Value = Properties.Settings.Default.EmployeeIDLen;
            nudLenCardID.Value = Properties.Settings.Default.CardNoLen;

            DataTable dt = DaoSQL.Instance.GetOutFileSetting();

            eOutputType type = (eOutputType)dt.Rows[0]["Type"].ToInt();
            if (type == eOutputType.eEmployeeID)
            {
                rbEmployeeID.Checked = true;
                nudLenEmployeeID.Value = dt.Rows[0]["Length"].ToInt();
            }
            else
            {
                rbCardID.Checked = true;
                nudLenCardID.Value = dt.Rows[0]["Length"].ToInt();
            }            

            this.LoadContext(dt.Rows[1], nudLenStr1, tbStr1);
            this.LoadContext(dt.Rows[2], nudLenStr2, tbStr2);
            this.LoadContext(dt.Rows[3], nudLenStr3, tbStr3);
            this.LoadContext(dt.Rows[4], nudLenStr4, tbStr4);
            this.LoadContext(dt.Rows[5], nudLenStr5, tbStr5);
            this.LoadContext(dt.Rows[6], nudLenStr6, tbStr6);
        }

        private void LoadContext(DataRow dataRow, NumericUpDown nud, TextBox tb)
        {
            nud.Value = dataRow["Length"].ToInt();
            tb.Text = dataRow["Contex"].ToString();

            ResetTextboxString(nud, tb);
        }
        
        private string AddString(NumericUpDown nud, TextBox tb)
        {
            if (tb.Text == "0")
                return "";
            
            if(tb.Text.Length == 0)
                return new string('□', nud.Value.ToInt());
            
            if (tb.Text.Length < nud.Value.ToInt())
            {
                string tmp = new string('□', nud.Value.ToInt());
                return tmp.Substring(0, nud.Value.ToInt() - tb.Text.Length ) + tb.Text;
            }
            else if(tb.Text.Length == nud.Value.ToInt())
            {
                return tb.Text;
            }


            return tb.Text.Substring(0, nud.Value.ToInt());
        }
               
        private void ReloadSamble()
        {
            int titleLen = rbEmployeeID.Checked == true ? nudLenEmployeeID.Value.ToInt() : nudLenCardID.Value.ToInt();
            
            string tmp = rbEmployeeID.Checked == true ? new string('E', titleLen) : new string('C', titleLen);

            lblPrintSample.Text = string.Format("{0}+字串1+年+字串2+月+字串3+日+字串4+時+字串5+分+字串6+位置", rbEmployeeID.Checked ? rbEmployeeID.Text : rbCardID.Text);

            tmp += AddString(this.nudLenStr1, this.tbStr1);
            tmp += DateTime.Now.ToString("yyyy");
            tmp += AddString(this.nudLenStr2, this.tbStr2);
            tmp += DateTime.Now.ToString("MM");
            tmp += AddString(this.nudLenStr3, this.tbStr3);
            tmp += DateTime.Now.ToString("dd");
            tmp += AddString(this.nudLenStr4, this.tbStr4);
            tmp += DateTime.Now.ToString("HH");
            tmp += AddString(this.nudLenStr5, this.tbStr5);
            tmp += DateTime.Now.ToString("mm");
            tmp += AddString(this.nudLenStr6, this.tbStr6);
            tmp += "位置";

            lblSampleShow.Text = tmp.Replace(' ', '□');
        }

        private void ResetTextboxString(NumericUpDown nud, TextBox tb)
        {
            tb.MaxLength = nud.Value.ToInt();

            if (tb.Text.Length > nud.Value.ToInt())
                tb.Text = tb.Text.Substring(0, nud.Value.ToInt());
        }

        private void ResetTextboxLength()
        {
            ResetTextboxString(nudLenStr1, tbStr1);
            ResetTextboxString(nudLenStr2, tbStr2);
            ResetTextboxString(nudLenStr3, tbStr3);
            ResetTextboxString(nudLenStr4, tbStr4);
            ResetTextboxString(nudLenStr5, tbStr5);
            ResetTextboxString(nudLenStr6, tbStr6);
        }

        private void Nud_ValueChanged(object sender, EventArgs e)
        {
            ResetTextboxLength();

            ReloadSamble();
        }
        
        private void Tb_TextChanged(object sender, EventArgs e)
        {
            ReloadSamble();
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
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
            List<OutputFormat> format = new List<OutputFormat>
            {
                new OutputFormat(rbEmployeeID.Checked ? eOutputType.eEmployeeID:eOutputType.eCardNo, 
                                 rbEmployeeID.Checked ? nudLenEmployeeID.Value.ToInt():nudLenCardID.Value.ToInt(), 
                                 ""),
                new OutputFormat(eOutputType.eString, nudLenStr1.Value.ToInt(), tbStr1.Text),
                new OutputFormat(eOutputType.eString, nudLenStr2.Value.ToInt(), tbStr2.Text),
                new OutputFormat(eOutputType.eString, nudLenStr3.Value.ToInt(), tbStr3.Text),
                new OutputFormat(eOutputType.eString, nudLenStr4.Value.ToInt(), tbStr4.Text),
                new OutputFormat(eOutputType.eString, nudLenStr5.Value.ToInt(), tbStr5.Text),
                new OutputFormat(eOutputType.eString, nudLenStr6.Value.ToInt(), tbStr6.Text)
            };

            DaoSQL.Instance.SaveFileSetting(format);

            //將數值存進系統預設值;//
            Properties.Settings.Default.EmployeeIDLen = nudLenEmployeeID.Value.ToInt();
            Properties.Settings.Default.CardNoLen = nudLenCardID.Value.ToInt();
            Properties.Settings.Default.Save();

            this.Close();
        }
    }
}
