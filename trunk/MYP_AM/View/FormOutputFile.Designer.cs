namespace MYPAM.View
{
    partial class FormOutputFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOutputFile));
            this.tlpSetting = new System.Windows.Forms.TableLayoutPanel();
            this.lblIDLen = new System.Windows.Forms.Label();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tlpIDLen = new System.Windows.Forms.TableLayoutPanel();
            this.nudIDLen = new System.Windows.Forms.NumericUpDown();
            this.lblCodeID = new System.Windows.Forms.Label();
            this.lblSample = new System.Windows.Forms.Label();
            this.lblSpaceLen = new System.Windows.Forms.Label();
            this.tlpSpaceLen = new System.Windows.Forms.TableLayoutPanel();
            this.nudSpaceLen = new System.Windows.Forms.NumericUpDown();
            this.lblCodeSpaceLen = new System.Windows.Forms.Label();
            this.pnlSample = new System.Windows.Forms.Panel();
            this.lblSampleShow = new System.Windows.Forms.Label();
            this.tlpSetting.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.tlpIDLen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIDLen)).BeginInit();
            this.tlpSpaceLen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpaceLen)).BeginInit();
            this.pnlSample.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpSetting
            // 
            this.tlpSetting.ColumnCount = 4;
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpSetting.Controls.Add(this.tlpButton, 2, 4);
            this.tlpSetting.Controls.Add(this.lblSample, 1, 3);
            this.tlpSetting.Controls.Add(this.pnlSample, 2, 3);
            this.tlpSetting.Controls.Add(this.tlpIDLen, 2, 1);
            this.tlpSetting.Controls.Add(this.tlpSpaceLen, 2, 2);
            this.tlpSetting.Controls.Add(this.lblSpaceLen, 1, 2);
            this.tlpSetting.Controls.Add(this.lblIDLen, 1, 1);
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
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSetting.Size = new System.Drawing.Size(354, 249);
            this.tlpSetting.TabIndex = 2;
            // 
            // lblIDLen
            // 
            this.lblIDLen.AutoSize = true;
            this.lblIDLen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIDLen.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblIDLen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIDLen.Location = new System.Drawing.Point(15, 20);
            this.lblIDLen.Name = "lblIDLen";
            this.lblIDLen.Size = new System.Drawing.Size(64, 39);
            this.lblIDLen.TabIndex = 1;
            this.lblIDLen.Text = "員編長度";
            this.lblIDLen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tlpButton.Location = new System.Drawing.Point(85, 183);
            this.tlpButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.Size = new System.Drawing.Size(254, 62);
            this.tlpButton.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnOK.Location = new System.Drawing.Point(104, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(70, 56);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "儲存";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnExit.Location = new System.Drawing.Point(180, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 56);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // tlpIDLen
            // 
            this.tlpIDLen.AutoSize = true;
            this.tlpIDLen.ColumnCount = 3;
            this.tlpIDLen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpIDLen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpIDLen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpIDLen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpIDLen.Controls.Add(this.nudIDLen, 0, 0);
            this.tlpIDLen.Controls.Add(this.lblCodeID, 2, 0);
            this.tlpIDLen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpIDLen.Location = new System.Drawing.Point(85, 23);
            this.tlpIDLen.Name = "tlpIDLen";
            this.tlpIDLen.RowCount = 1;
            this.tlpIDLen.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpIDLen.Size = new System.Drawing.Size(254, 33);
            this.tlpIDLen.TabIndex = 8;
            // 
            // nudIDLen
            // 
            this.nudIDLen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudIDLen.Font = new System.Drawing.Font("Arial", 10F);
            this.nudIDLen.Location = new System.Drawing.Point(3, 5);
            this.nudIDLen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nudIDLen.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.nudIDLen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIDLen.Name = "nudIDLen";
            this.nudIDLen.Size = new System.Drawing.Size(111, 23);
            this.nudIDLen.TabIndex = 2;
            this.nudIDLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudIDLen.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudIDLen.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            // 
            // lblCodeID
            // 
            this.lblCodeID.AutoSize = true;
            this.lblCodeID.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCodeID.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblCodeID.Location = new System.Drawing.Point(140, 0);
            this.lblCodeID.Name = "lblCodeID";
            this.lblCodeID.Size = new System.Drawing.Size(22, 33);
            this.lblCodeID.TabIndex = 9;
            this.lblCodeID.Text = "碼";
            this.lblCodeID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSample
            // 
            this.lblSample.AutoSize = true;
            this.lblSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSample.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblSample.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSample.Location = new System.Drawing.Point(15, 98);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(64, 81);
            this.lblSample.TabIndex = 10;
            this.lblSample.Text = "輸出樣式";
            this.lblSample.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSpaceLen
            // 
            this.lblSpaceLen.AutoSize = true;
            this.lblSpaceLen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpaceLen.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblSpaceLen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSpaceLen.Location = new System.Drawing.Point(15, 59);
            this.lblSpaceLen.Name = "lblSpaceLen";
            this.lblSpaceLen.Size = new System.Drawing.Size(64, 39);
            this.lblSpaceLen.TabIndex = 13;
            this.lblSpaceLen.Text = "空格長度";
            this.lblSpaceLen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpSpaceLen
            // 
            this.tlpSpaceLen.AutoSize = true;
            this.tlpSpaceLen.ColumnCount = 3;
            this.tlpSpaceLen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSpaceLen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSpaceLen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSpaceLen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSpaceLen.Controls.Add(this.nudSpaceLen, 0, 0);
            this.tlpSpaceLen.Controls.Add(this.lblCodeSpaceLen, 2, 0);
            this.tlpSpaceLen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSpaceLen.Location = new System.Drawing.Point(85, 62);
            this.tlpSpaceLen.Name = "tlpSpaceLen";
            this.tlpSpaceLen.RowCount = 1;
            this.tlpSpaceLen.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSpaceLen.Size = new System.Drawing.Size(254, 33);
            this.tlpSpaceLen.TabIndex = 14;
            // 
            // nudSpaceLen
            // 
            this.nudSpaceLen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSpaceLen.Font = new System.Drawing.Font("Arial", 10F);
            this.nudSpaceLen.Location = new System.Drawing.Point(3, 5);
            this.nudSpaceLen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nudSpaceLen.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudSpaceLen.Name = "nudSpaceLen";
            this.nudSpaceLen.Size = new System.Drawing.Size(111, 23);
            this.nudSpaceLen.TabIndex = 1;
            this.nudSpaceLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSpaceLen.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.nudSpaceLen.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            // 
            // lblCodeSpaceLen
            // 
            this.lblCodeSpaceLen.AutoSize = true;
            this.lblCodeSpaceLen.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCodeSpaceLen.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblCodeSpaceLen.Location = new System.Drawing.Point(140, 0);
            this.lblCodeSpaceLen.Name = "lblCodeSpaceLen";
            this.lblCodeSpaceLen.Size = new System.Drawing.Size(22, 33);
            this.lblCodeSpaceLen.TabIndex = 10;
            this.lblCodeSpaceLen.Text = "碼";
            this.lblCodeSpaceLen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSample
            // 
            this.pnlSample.AutoSize = true;
            this.pnlSample.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSample.Controls.Add(this.lblSampleShow);
            this.pnlSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSample.Location = new System.Drawing.Point(85, 101);
            this.pnlSample.MinimumSize = new System.Drawing.Size(100, 75);
            this.pnlSample.Name = "pnlSample";
            this.pnlSample.Size = new System.Drawing.Size(254, 75);
            this.pnlSample.TabIndex = 15;
            // 
            // lblSampleShow
            // 
            this.lblSampleShow.AutoSize = true;
            this.lblSampleShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSampleShow.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSampleShow.ForeColor = System.Drawing.Color.Blue;
            this.lblSampleShow.Location = new System.Drawing.Point(0, 0);
            this.lblSampleShow.Name = "lblSampleShow";
            this.lblSampleShow.Size = new System.Drawing.Size(62, 18);
            this.lblSampleShow.TabIndex = 0;
            this.lblSampleShow.Text = "Sample";
            this.lblSampleShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormOutputFile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(354, 249);
            this.Controls.Add(this.tlpSetting);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOutputFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "考勤輸出格式設定";
            this.tlpSetting.ResumeLayout(false);
            this.tlpSetting.PerformLayout();
            this.tlpButton.ResumeLayout(false);
            this.tlpIDLen.ResumeLayout(false);
            this.tlpIDLen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIDLen)).EndInit();
            this.tlpSpaceLen.ResumeLayout(false);
            this.tlpSpaceLen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpaceLen)).EndInit();
            this.pnlSample.ResumeLayout(false);
            this.pnlSample.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSetting;
        private System.Windows.Forms.Label lblIDLen;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TableLayoutPanel tlpIDLen;
        private System.Windows.Forms.NumericUpDown nudIDLen;
        private System.Windows.Forms.Label lblCodeID;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.Label lblSpaceLen;
        private System.Windows.Forms.TableLayoutPanel tlpSpaceLen;
        private System.Windows.Forms.NumericUpDown nudSpaceLen;
        private System.Windows.Forms.Label lblCodeSpaceLen;
        private System.Windows.Forms.Panel pnlSample;
        private System.Windows.Forms.Label lblSampleShow;
    }
}