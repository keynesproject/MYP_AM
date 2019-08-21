using MYPAM.Model.DataAccessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MYPAM.View
{
    public partial class FormOption : Form
    {
        public FormOption()
        {
            InitializeComponent();

            //讀取預設值;//
            nudMorningHour.Value = Properties.Settings.Default.DataUpdateMorning.Hour;
            nudMorningMinute.Value = Properties.Settings.Default.DataUpdateMorning.Minute;
            nudAfternoonHour.Value = Properties.Settings.Default.DataUpdateAfternoon.Hour;
            nudAfternoonMinute.Value = Properties.Settings.Default.DataUpdateAfternoon.Minute;

            tbPath.Text = DaoConfigFile.Instance.DirAttExport;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            string dateToday = DateTime.Now.ToString("yyyy-MM-dd ");
            Properties.Settings.Default.DataUpdateMorning = DateTime.Parse( string.Format("{0} {1:00}:{2:00}:00",
                dateToday,
                nudMorningHour.Value,
                nudMorningMinute.Value));

            Properties.Settings.Default.DataUpdateAfternoon = DateTime.Parse(string.Format("{0} {1:00}:{2:00}:00",
                dateToday,
                nudAfternoonHour.Value,
                nudAfternoonMinute.Value));
            
            DaoConfigFile.Instance.DirAttExport = tbPath.Text;

            Properties.Settings.Default.Save();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void BtnSearchBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Path = new FolderBrowserDialog();

            if (Path.ShowDialog() == DialogResult.OK)
            {
                if (this.tbPath.Text.Length > 0)
                    this.tbPath.Text = Path.SelectedPath;
                else
                    this.tbPath.Text = Directory.GetCurrentDirectory();
            }
        }
    }
}
