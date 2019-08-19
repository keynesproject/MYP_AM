namespace MYPAM.View
{
    partial class FormFingerPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFingerPrint));
            this.tlpSetting = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMachineNo = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMachineNo = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tlpAckServerIP = new System.Windows.Forms.TableLayoutPanel();
            this.lblDotIP3 = new System.Windows.Forms.Label();
            this.lblDotIP2 = new System.Windows.Forms.Label();
            this.tbIP1 = new System.Windows.Forms.TextBox();
            this.tbIP2 = new System.Windows.Forms.TextBox();
            this.tbIP3 = new System.Windows.Forms.TextBox();
            this.tbIP4 = new System.Windows.Forms.TextBox();
            this.lblDotIP1 = new System.Windows.Forms.Label();
            this.lblEnable = new System.Windows.Forms.Label();
            this.cbEnable = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.tlpSetting.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.tlpAckServerIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpSetting
            // 
            this.tlpSetting.ColumnCount = 4;
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpSetting.Controls.Add(this.lblName, 1, 1);
            this.tlpSetting.Controls.Add(this.lblMachineNo, 1, 3);
            this.tlpSetting.Controls.Add(this.lblIP, 1, 4);
            this.tlpSetting.Controls.Add(this.lblPort, 1, 5);
            this.tlpSetting.Controls.Add(this.tbName, 2, 1);
            this.tlpSetting.Controls.Add(this.tbMachineNo, 2, 3);
            this.tlpSetting.Controls.Add(this.tbPort, 2, 5);
            this.tlpSetting.Controls.Add(this.tlpButton, 2, 7);
            this.tlpSetting.Controls.Add(this.tlpAckServerIP, 2, 4);
            this.tlpSetting.Controls.Add(this.lblEnable, 1, 6);
            this.tlpSetting.Controls.Add(this.cbEnable, 2, 6);
            this.tlpSetting.Controls.Add(this.lblLocation, 1, 2);
            this.tlpSetting.Controls.Add(this.tbLocation, 2, 2);
            this.tlpSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSetting.Location = new System.Drawing.Point(0, 0);
            this.tlpSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpSetting.Name = "tlpSetting";
            this.tlpSetting.RowCount = 8;
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSetting.Size = new System.Drawing.Size(415, 294);
            this.tlpSetting.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Location = new System.Drawing.Point(15, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 33);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "名稱";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMachineNo
            // 
            this.lblMachineNo.AutoSize = true;
            this.lblMachineNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMachineNo.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblMachineNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMachineNo.Location = new System.Drawing.Point(15, 78);
            this.lblMachineNo.Name = "lblMachineNo";
            this.lblMachineNo.Size = new System.Drawing.Size(64, 33);
            this.lblMachineNo.TabIndex = 1;
            this.lblMachineNo.Text = "設備編號";
            this.lblMachineNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIP.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblIP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIP.Location = new System.Drawing.Point(15, 111);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(64, 36);
            this.lblIP.TabIndex = 2;
            this.lblIP.Text = "IP地址";
            this.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPort.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblPort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPort.Location = new System.Drawing.Point(15, 147);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(64, 33);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "端口";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.tbName.Location = new System.Drawing.Point(85, 16);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbName.MaxLength = 128;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(315, 25);
            this.tbName.TabIndex = 0;
            this.tbName.Click += new System.EventHandler(this.Control_Enter);
            this.tbName.Enter += new System.EventHandler(this.Control_Enter);
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NextControl);
            // 
            // tbMachineNo
            // 
            this.tbMachineNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMachineNo.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.tbMachineNo.Location = new System.Drawing.Point(85, 82);
            this.tbMachineNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMachineNo.MaxLength = 3;
            this.tbMachineNo.Name = "tbMachineNo";
            this.tbMachineNo.ReadOnly = true;
            this.tbMachineNo.Size = new System.Drawing.Size(315, 25);
            this.tbMachineNo.TabIndex = 2;
            this.tbMachineNo.Text = "1";
            this.tbMachineNo.Click += new System.EventHandler(this.Control_Enter);
            this.tbMachineNo.Enter += new System.EventHandler(this.Control_Enter);
            this.tbMachineNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyNumOnly);
            this.tbMachineNo.Leave += new System.EventHandler(this.CheckedNumber);
            // 
            // tbPort
            // 
            this.tbPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPort.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.tbPort.Location = new System.Drawing.Point(85, 151);
            this.tbPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPort.MaxLength = 5;
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(315, 25);
            this.tbPort.TabIndex = 4;
            this.tbPort.Text = "4370";
            this.tbPort.Click += new System.EventHandler(this.Control_Enter);
            this.tbPort.Enter += new System.EventHandler(this.Control_Enter);
            this.tbPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyNumOnly);
            this.tbPort.Leave += new System.EventHandler(this.CheckedPort);
            // 
            // tlpButton
            // 
            this.tlpButton.ColumnCount = 3;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButton.Controls.Add(this.btnNew, 1, 0);
            this.tlpButton.Controls.Add(this.btnExit, 2, 0);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton.Location = new System.Drawing.Point(85, 213);
            this.tlpButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.Size = new System.Drawing.Size(315, 77);
            this.tlpButton.TabIndex = 6;
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnNew.Location = new System.Drawing.Point(117, 12);
            this.btnNew.Margin = new System.Windows.Forms.Padding(12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(81, 53);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "新增";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnExit.Location = new System.Drawing.Point(222, 12);
            this.btnExit.Margin = new System.Windows.Forms.Padding(12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 53);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // tlpAckServerIP
            // 
            this.tlpAckServerIP.ColumnCount = 7;
            this.tlpAckServerIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAckServerIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpAckServerIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAckServerIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpAckServerIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAckServerIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpAckServerIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAckServerIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAckServerIP.Controls.Add(this.lblDotIP3, 5, 0);
            this.tlpAckServerIP.Controls.Add(this.lblDotIP2, 3, 0);
            this.tlpAckServerIP.Controls.Add(this.tbIP1, 0, 0);
            this.tlpAckServerIP.Controls.Add(this.tbIP2, 2, 0);
            this.tlpAckServerIP.Controls.Add(this.tbIP3, 4, 0);
            this.tlpAckServerIP.Controls.Add(this.tbIP4, 6, 0);
            this.tlpAckServerIP.Controls.Add(this.lblDotIP1, 1, 0);
            this.tlpAckServerIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAckServerIP.Location = new System.Drawing.Point(85, 115);
            this.tlpAckServerIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpAckServerIP.Name = "tlpAckServerIP";
            this.tlpAckServerIP.RowCount = 1;
            this.tlpAckServerIP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAckServerIP.Size = new System.Drawing.Size(315, 28);
            this.tlpAckServerIP.TabIndex = 3;
            // 
            // lblDotIP3
            // 
            this.lblDotIP3.AutoSize = true;
            this.lblDotIP3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotIP3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDotIP3.Location = new System.Drawing.Point(231, 0);
            this.lblDotIP3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblDotIP3.Name = "lblDotIP3";
            this.lblDotIP3.Size = new System.Drawing.Size(15, 25);
            this.lblDotIP3.TabIndex = 6;
            this.lblDotIP3.Text = ".";
            this.lblDotIP3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblDotIP2
            // 
            this.lblDotIP2.AutoSize = true;
            this.lblDotIP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotIP2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDotIP2.Location = new System.Drawing.Point(149, 0);
            this.lblDotIP2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblDotIP2.Name = "lblDotIP2";
            this.lblDotIP2.Size = new System.Drawing.Size(15, 25);
            this.lblDotIP2.TabIndex = 5;
            this.lblDotIP2.Text = ".";
            this.lblDotIP2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tbIP1
            // 
            this.tbIP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbIP1.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbIP1.Location = new System.Drawing.Point(0, 0);
            this.tbIP1.Margin = new System.Windows.Forms.Padding(0);
            this.tbIP1.MaxLength = 3;
            this.tbIP1.Name = "tbIP1";
            this.tbIP1.ShortcutsEnabled = false;
            this.tbIP1.Size = new System.Drawing.Size(67, 25);
            this.tbIP1.TabIndex = 0;
            this.tbIP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbIP1.Click += new System.EventHandler(this.Control_Enter);
            this.tbIP1.Enter += new System.EventHandler(this.Control_Enter);
            this.tbIP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyNumOnly);
            this.tbIP1.Leave += new System.EventHandler(this.CheckedIp1Address);
            // 
            // tbIP2
            // 
            this.tbIP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbIP2.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbIP2.Location = new System.Drawing.Point(82, 0);
            this.tbIP2.Margin = new System.Windows.Forms.Padding(0);
            this.tbIP2.MaxLength = 3;
            this.tbIP2.Name = "tbIP2";
            this.tbIP2.ShortcutsEnabled = false;
            this.tbIP2.Size = new System.Drawing.Size(67, 25);
            this.tbIP2.TabIndex = 1;
            this.tbIP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbIP2.Click += new System.EventHandler(this.Control_Enter);
            this.tbIP2.Enter += new System.EventHandler(this.Control_Enter);
            this.tbIP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyNumOnly);
            this.tbIP2.Leave += new System.EventHandler(this.CheckedIpAddress);
            // 
            // tbIP3
            // 
            this.tbIP3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbIP3.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbIP3.Location = new System.Drawing.Point(164, 0);
            this.tbIP3.Margin = new System.Windows.Forms.Padding(0);
            this.tbIP3.MaxLength = 3;
            this.tbIP3.Name = "tbIP3";
            this.tbIP3.ShortcutsEnabled = false;
            this.tbIP3.Size = new System.Drawing.Size(67, 25);
            this.tbIP3.TabIndex = 2;
            this.tbIP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbIP3.Click += new System.EventHandler(this.Control_Enter);
            this.tbIP3.Enter += new System.EventHandler(this.Control_Enter);
            this.tbIP3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyNumOnly);
            this.tbIP3.Leave += new System.EventHandler(this.CheckedIpAddress);
            // 
            // tbIP4
            // 
            this.tbIP4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbIP4.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbIP4.Location = new System.Drawing.Point(246, 0);
            this.tbIP4.Margin = new System.Windows.Forms.Padding(0);
            this.tbIP4.MaxLength = 3;
            this.tbIP4.Name = "tbIP4";
            this.tbIP4.ShortcutsEnabled = false;
            this.tbIP4.Size = new System.Drawing.Size(69, 25);
            this.tbIP4.TabIndex = 3;
            this.tbIP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbIP4.Click += new System.EventHandler(this.Control_Enter);
            this.tbIP4.Enter += new System.EventHandler(this.Control_Enter);
            this.tbIP4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyNumOnly);
            this.tbIP4.Leave += new System.EventHandler(this.CheckedIpAddress);
            // 
            // lblDotIP1
            // 
            this.lblDotIP1.AutoSize = true;
            this.lblDotIP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotIP1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDotIP1.Location = new System.Drawing.Point(67, 0);
            this.lblDotIP1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblDotIP1.Name = "lblDotIP1";
            this.lblDotIP1.Size = new System.Drawing.Size(15, 25);
            this.lblDotIP1.TabIndex = 4;
            this.lblDotIP1.Text = ".";
            this.lblDotIP1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblEnable
            // 
            this.lblEnable.AutoSize = true;
            this.lblEnable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnable.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblEnable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEnable.Location = new System.Drawing.Point(15, 180);
            this.lblEnable.Name = "lblEnable";
            this.lblEnable.Size = new System.Drawing.Size(64, 29);
            this.lblEnable.TabIndex = 5;
            this.lblEnable.Text = "啟用";
            this.lblEnable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbEnable
            // 
            this.cbEnable.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbEnable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEnable.FormattingEnabled = true;
            this.cbEnable.Items.AddRange(new object[] {
            "開啟",
            "關閉"});
            this.cbEnable.Location = new System.Drawing.Point(85, 183);
            this.cbEnable.Name = "cbEnable";
            this.cbEnable.Size = new System.Drawing.Size(86, 23);
            this.cbEnable.TabIndex = 5;
            this.cbEnable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NextControl);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocation.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLocation.Location = new System.Drawing.Point(15, 45);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(64, 33);
            this.lblLocation.TabIndex = 6;
            this.lblLocation.Text = "地點代碼";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbLocation
            // 
            this.tbLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLocation.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.tbLocation.Location = new System.Drawing.Point(85, 49);
            this.tbLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLocation.MaxLength = 2;
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(315, 25);
            this.tbLocation.TabIndex = 1;
            // 
            // FormFingerPrint
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(415, 294);
            this.Controls.Add(this.tlpSetting);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFingerPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增設備設定";
            this.tlpSetting.ResumeLayout(false);
            this.tlpSetting.PerformLayout();
            this.tlpButton.ResumeLayout(false);
            this.tlpAckServerIP.ResumeLayout(false);
            this.tlpAckServerIP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSetting;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMachineNo;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMachineNo;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TableLayoutPanel tlpAckServerIP;
        private System.Windows.Forms.Label lblDotIP3;
        private System.Windows.Forms.Label lblDotIP2;
        private System.Windows.Forms.TextBox tbIP1;
        private System.Windows.Forms.TextBox tbIP2;
        private System.Windows.Forms.TextBox tbIP3;
        private System.Windows.Forms.TextBox tbIP4;
        private System.Windows.Forms.Label lblDotIP1;
        private System.Windows.Forms.Label lblEnable;
        private System.Windows.Forms.ComboBox cbEnable;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox tbLocation;
    }
}