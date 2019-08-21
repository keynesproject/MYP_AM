namespace MYPAM.View
{
    partial class FormOption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOption));
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAfternoon = new System.Windows.Forms.Label();
            this.lblMorning = new System.Windows.Forms.Label();
            this.tlpSetting = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMorning = new System.Windows.Forms.TableLayoutPanel();
            this.nudMorningHour = new System.Windows.Forms.NumericUpDown();
            this.nudMorningMinute = new System.Windows.Forms.NumericUpDown();
            this.lblMorningDot = new System.Windows.Forms.Label();
            this.tlpAfternoon = new System.Windows.Forms.TableLayoutPanel();
            this.nudAfternoonHour = new System.Windows.Forms.NumericUpDown();
            this.nudAfternoonMinute = new System.Windows.Forms.NumericUpDown();
            this.lblAfternoonDot = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnSearchBackup = new System.Windows.Forms.Button();
            this.tlpButton.SuspendLayout();
            this.tlpSetting.SuspendLayout();
            this.tlpMorning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMorningHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMorningMinute)).BeginInit();
            this.tlpAfternoon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAfternoonHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAfternoonMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpButton
            // 
            this.tlpButton.ColumnCount = 3;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpButton.Controls.Add(this.btnOK, 1, 0);
            this.tlpButton.Controls.Add(this.btnExit, 2, 0);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton.Location = new System.Drawing.Point(155, 135);
            this.tlpButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.Size = new System.Drawing.Size(297, 57);
            this.tlpButton.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnOK.Location = new System.Drawing.Point(121, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 51);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "儲存";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnExit.Location = new System.Drawing.Point(210, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 51);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblAfternoon
            // 
            this.lblAfternoon.AutoSize = true;
            this.lblAfternoon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAfternoon.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblAfternoon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAfternoon.Location = new System.Drawing.Point(15, 59);
            this.lblAfternoon.Name = "lblAfternoon";
            this.lblAfternoon.Size = new System.Drawing.Size(134, 39);
            this.lblAfternoon.TabIndex = 3;
            this.lblAfternoon.Text = "下午固定更新時段 :";
            this.lblAfternoon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMorning
            // 
            this.lblMorning.AutoSize = true;
            this.lblMorning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMorning.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblMorning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMorning.Location = new System.Drawing.Point(15, 20);
            this.lblMorning.Name = "lblMorning";
            this.lblMorning.Size = new System.Drawing.Size(134, 39);
            this.lblMorning.TabIndex = 1;
            this.lblMorning.Text = "上午固定更新時段 :";
            this.lblMorning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpSetting
            // 
            this.tlpSetting.ColumnCount = 4;
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSetting.Controls.Add(this.lblMorning, 1, 1);
            this.tlpSetting.Controls.Add(this.lblAfternoon, 1, 2);
            this.tlpSetting.Controls.Add(this.tlpButton, 2, 4);
            this.tlpSetting.Controls.Add(this.tlpMorning, 2, 1);
            this.tlpSetting.Controls.Add(this.tlpAfternoon, 2, 2);
            this.tlpSetting.Controls.Add(this.lblPath, 1, 3);
            this.tlpSetting.Controls.Add(this.tbPath, 2, 3);
            this.tlpSetting.Controls.Add(this.btnSearchBackup, 3, 3);
            this.tlpSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSetting.Location = new System.Drawing.Point(0, 0);
            this.tlpSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpSetting.Name = "tlpSetting";
            this.tlpSetting.RowCount = 5;
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSetting.Size = new System.Drawing.Size(487, 196);
            this.tlpSetting.TabIndex = 1;
            // 
            // tlpMorning
            // 
            this.tlpMorning.AutoSize = true;
            this.tlpMorning.ColumnCount = 3;
            this.tlpMorning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMorning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMorning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMorning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMorning.Controls.Add(this.nudMorningHour, 0, 0);
            this.tlpMorning.Controls.Add(this.nudMorningMinute, 2, 0);
            this.tlpMorning.Controls.Add(this.lblMorningDot, 1, 0);
            this.tlpMorning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMorning.Location = new System.Drawing.Point(155, 23);
            this.tlpMorning.Name = "tlpMorning";
            this.tlpMorning.RowCount = 1;
            this.tlpMorning.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMorning.Size = new System.Drawing.Size(297, 33);
            this.tlpMorning.TabIndex = 8;
            // 
            // nudMorningHour
            // 
            this.nudMorningHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudMorningHour.Font = new System.Drawing.Font("Arial", 10F);
            this.nudMorningHour.Location = new System.Drawing.Point(3, 5);
            this.nudMorningHour.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nudMorningHour.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nudMorningHour.Name = "nudMorningHour";
            this.nudMorningHour.Size = new System.Drawing.Size(132, 23);
            this.nudMorningHour.TabIndex = 7;
            this.nudMorningHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMorningHour.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudMorningMinute
            // 
            this.nudMorningMinute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudMorningMinute.Font = new System.Drawing.Font("Arial", 10F);
            this.nudMorningMinute.Location = new System.Drawing.Point(161, 5);
            this.nudMorningMinute.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nudMorningMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMorningMinute.Name = "nudMorningMinute";
            this.nudMorningMinute.Size = new System.Drawing.Size(133, 23);
            this.nudMorningMinute.TabIndex = 8;
            this.nudMorningMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMorningMinute.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblMorningDot
            // 
            this.lblMorningDot.AutoSize = true;
            this.lblMorningDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMorningDot.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMorningDot.Location = new System.Drawing.Point(141, 0);
            this.lblMorningDot.Name = "lblMorningDot";
            this.lblMorningDot.Size = new System.Drawing.Size(14, 33);
            this.lblMorningDot.TabIndex = 9;
            this.lblMorningDot.Text = " : ";
            this.lblMorningDot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpAfternoon
            // 
            this.tlpAfternoon.AutoSize = true;
            this.tlpAfternoon.ColumnCount = 3;
            this.tlpAfternoon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAfternoon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAfternoon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAfternoon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAfternoon.Controls.Add(this.nudAfternoonHour, 0, 0);
            this.tlpAfternoon.Controls.Add(this.nudAfternoonMinute, 2, 0);
            this.tlpAfternoon.Controls.Add(this.lblAfternoonDot, 1, 0);
            this.tlpAfternoon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAfternoon.Location = new System.Drawing.Point(155, 62);
            this.tlpAfternoon.Name = "tlpAfternoon";
            this.tlpAfternoon.RowCount = 1;
            this.tlpAfternoon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAfternoon.Size = new System.Drawing.Size(297, 33);
            this.tlpAfternoon.TabIndex = 9;
            // 
            // nudAfternoonHour
            // 
            this.nudAfternoonHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAfternoonHour.Font = new System.Drawing.Font("Arial", 10F);
            this.nudAfternoonHour.Location = new System.Drawing.Point(3, 5);
            this.nudAfternoonHour.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nudAfternoonHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudAfternoonHour.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudAfternoonHour.Name = "nudAfternoonHour";
            this.nudAfternoonHour.Size = new System.Drawing.Size(132, 23);
            this.nudAfternoonHour.TabIndex = 7;
            this.nudAfternoonHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAfternoonHour.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            // 
            // nudAfternoonMinute
            // 
            this.nudAfternoonMinute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAfternoonMinute.Font = new System.Drawing.Font("Arial", 10F);
            this.nudAfternoonMinute.Location = new System.Drawing.Point(161, 5);
            this.nudAfternoonMinute.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nudAfternoonMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudAfternoonMinute.Name = "nudAfternoonMinute";
            this.nudAfternoonMinute.Size = new System.Drawing.Size(133, 23);
            this.nudAfternoonMinute.TabIndex = 8;
            this.nudAfternoonMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAfternoonMinute.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblAfternoonDot
            // 
            this.lblAfternoonDot.AutoSize = true;
            this.lblAfternoonDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAfternoonDot.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfternoonDot.Location = new System.Drawing.Point(141, 0);
            this.lblAfternoonDot.Name = "lblAfternoonDot";
            this.lblAfternoonDot.Size = new System.Drawing.Size(14, 33);
            this.lblAfternoonDot.TabIndex = 9;
            this.lblAfternoonDot.Text = " : ";
            this.lblAfternoonDot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPath.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPath.Location = new System.Drawing.Point(15, 98);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(134, 33);
            this.lblPath.TabIndex = 10;
            this.lblPath.Text = "考勤檔案輸出路徑：";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPath
            // 
            this.tbPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPath.Font = new System.Drawing.Font("Arial", 9F);
            this.tbPath.Location = new System.Drawing.Point(155, 105);
            this.tbPath.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.tbPath.MaxLength = 512;
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(297, 21);
            this.tbPath.TabIndex = 11;
            // 
            // btnSearchBackup
            // 
            this.btnSearchBackup.AutoSize = true;
            this.btnSearchBackup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchBackup.Location = new System.Drawing.Point(458, 102);
            this.btnSearchBackup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearchBackup.Name = "btnSearchBackup";
            this.btnSearchBackup.Size = new System.Drawing.Size(26, 25);
            this.btnSearchBackup.TabIndex = 12;
            this.btnSearchBackup.Text = "...";
            this.btnSearchBackup.UseVisualStyleBackColor = true;
            this.btnSearchBackup.Click += new System.EventHandler(this.BtnSearchBackup_Click);
            // 
            // FormOption
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(487, 196);
            this.Controls.Add(this.tlpSetting);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "功能設定";
            this.tlpButton.ResumeLayout(false);
            this.tlpSetting.ResumeLayout(false);
            this.tlpSetting.PerformLayout();
            this.tlpMorning.ResumeLayout(false);
            this.tlpMorning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMorningHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMorningMinute)).EndInit();
            this.tlpAfternoon.ResumeLayout(false);
            this.tlpAfternoon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAfternoonHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAfternoonMinute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAfternoon;
        private System.Windows.Forms.Label lblMorning;
        private System.Windows.Forms.TableLayoutPanel tlpSetting;
        private System.Windows.Forms.TableLayoutPanel tlpMorning;
        private System.Windows.Forms.NumericUpDown nudMorningHour;
        private System.Windows.Forms.NumericUpDown nudMorningMinute;
        private System.Windows.Forms.Label lblMorningDot;
        private System.Windows.Forms.TableLayoutPanel tlpAfternoon;
        private System.Windows.Forms.NumericUpDown nudAfternoonHour;
        private System.Windows.Forms.NumericUpDown nudAfternoonMinute;
        private System.Windows.Forms.Label lblAfternoonDot;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnSearchBackup;
    }
}