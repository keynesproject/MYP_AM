namespace MYPAM.View
{
    partial class FormMypPW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMypPW));
            this.tlpSetting = new System.Windows.Forms.TableLayoutPanel();
            this.lblPW = new System.Windows.Forms.Label();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.tlpSetting.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpSetting
            // 
            this.tlpSetting.ColumnCount = 4;
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpSetting.Controls.Add(this.lblPW, 1, 1);
            this.tlpSetting.Controls.Add(this.tbPW, 2, 1);
            this.tlpSetting.Controls.Add(this.tlpButton, 2, 2);
            this.tlpSetting.Controls.Add(this.lblMsg, 2, 0);
            this.tlpSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSetting.Location = new System.Drawing.Point(0, 0);
            this.tlpSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpSetting.Name = "tlpSetting";
            this.tlpSetting.RowCount = 3;
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSetting.Size = new System.Drawing.Size(367, 174);
            this.tlpSetting.TabIndex = 1;
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPW.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblPW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPW.Location = new System.Drawing.Point(15, 52);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(36, 33);
            this.lblPW.TabIndex = 3;
            this.lblPW.Text = "密碼";
            this.lblPW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPW
            // 
            this.tbPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPW.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.tbPW.Location = new System.Drawing.Point(57, 56);
            this.tbPW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPW.MaxLength = 128;
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '*';
            this.tbPW.Size = new System.Drawing.Size(295, 25);
            this.tbPW.TabIndex = 0;
            this.tbPW.Click += new System.EventHandler(this.Control_Enter);
            this.tbPW.Enter += new System.EventHandler(this.Control_Enter);
            this.tbPW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPW_KeyPress);
            // 
            // tlpButton
            // 
            this.tlpButton.ColumnCount = 3;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpButton.Controls.Add(this.btnOK, 1, 0);
            this.tlpButton.Controls.Add(this.btnExit, 2, 0);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton.Location = new System.Drawing.Point(57, 89);
            this.tlpButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.Size = new System.Drawing.Size(295, 81);
            this.tlpButton.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnOK.Location = new System.Drawing.Point(110, 12);
            this.btnOK.Margin = new System.Windows.Forms.Padding(12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(74, 57);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "確定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnExit.Location = new System.Drawing.Point(208, 12);
            this.btnExit.Margin = new System.Windows.Forms.Padding(12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 57);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMsg.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMsg.Location = new System.Drawing.Point(57, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(295, 52);
            this.lblMsg.TabIndex = 5;
            this.lblMsg.Text = "請輸入正確密碼來開啟MYP設定功能。";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMypPW
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(367, 174);
            this.Controls.Add(this.tlpSetting);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMypPW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MYP設定開啟密碼";
            this.tlpSetting.ResumeLayout(false);
            this.tlpSetting.PerformLayout();
            this.tlpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSetting;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMsg;
    }
}