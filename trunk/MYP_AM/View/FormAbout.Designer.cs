namespace MYPAM.View
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLine2 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.tlpSupport = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmailTitle = new System.Windows.Forms.Label();
            this.lblFaxValue = new System.Windows.Forms.Label();
            this.lnkLblEmail = new System.Windows.Forms.LinkLabel();
            this.lblPhoneValue = new System.Windows.Forms.Label();
            this.lblDotPhone = new System.Windows.Forms.Label();
            this.lblDotFax = new System.Windows.Forms.Label();
            this.lblDotEmail = new System.Windows.Forms.Label();
            this.lblPhoneTitle = new System.Windows.Forms.Label();
            this.lblFaxTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSupport = new System.Windows.Forms.Label();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.tlpTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tlpInfo.SuspendLayout();
            this.tlpSupport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTop
            // 
            this.tlpTop.ColumnCount = 2;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.Controls.Add(this.pbLogo, 0, 0);
            this.tlpTop.Controls.Add(this.tlpInfo, 1, 0);
            this.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTop.Location = new System.Drawing.Point(0, 0);
            this.tlpTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.Size = new System.Drawing.Size(735, 283);
            this.tlpTop.TabIndex = 11;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::MYPAM.Properties.Resources.splash;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Location = new System.Drawing.Point(3, 4);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(379, 275);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.PbLogo_Click);
            // 
            // tlpInfo
            // 
            this.tlpInfo.AutoSize = true;
            this.tlpInfo.ColumnCount = 1;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfo.Controls.Add(this.pnlLine2, 0, 4);
            this.tlpInfo.Controls.Add(this.btnOK, 0, 5);
            this.tlpInfo.Controls.Add(this.lblCopyright, 0, 3);
            this.tlpInfo.Controls.Add(this.tlpSupport, 0, 1);
            this.tlpInfo.Controls.Add(this.lblSupport, 0, 0);
            this.tlpInfo.Controls.Add(this.pnlLine1, 0, 2);
            this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfo.Location = new System.Drawing.Point(388, 4);
            this.tlpInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 7;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tlpInfo.Size = new System.Drawing.Size(344, 275);
            this.tlpInfo.TabIndex = 2;
            // 
            // pnlLine2
            // 
            this.pnlLine2.AutoSize = true;
            this.pnlLine2.BackColor = System.Drawing.Color.Black;
            this.pnlLine2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLine2.Location = new System.Drawing.Point(3, 219);
            this.pnlLine2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLine2.Name = "pnlLine2";
            this.pnlLine2.Size = new System.Drawing.Size(338, 1);
            this.pnlLine2.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(220, 228);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 35);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopyright.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCopyright.Location = new System.Drawing.Point(3, 151);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(338, 60);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "Copyright © 木研科技有限公司 \r\n2019 All rights reserved. Design by Keynes Lu";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpSupport
            // 
            this.tlpSupport.AutoSize = true;
            this.tlpSupport.ColumnCount = 3;
            this.tlpSupport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSupport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSupport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSupport.Controls.Add(this.lblEmailTitle, 1, 3);
            this.tlpSupport.Controls.Add(this.lblFaxValue, 2, 1);
            this.tlpSupport.Controls.Add(this.lnkLblEmail, 2, 3);
            this.tlpSupport.Controls.Add(this.lblPhoneValue, 2, 0);
            this.tlpSupport.Controls.Add(this.lblDotPhone, 0, 0);
            this.tlpSupport.Controls.Add(this.lblDotFax, 0, 1);
            this.tlpSupport.Controls.Add(this.lblDotEmail, 0, 3);
            this.tlpSupport.Controls.Add(this.lblPhoneTitle, 1, 0);
            this.tlpSupport.Controls.Add(this.lblFaxTitle, 1, 1);
            this.tlpSupport.Controls.Add(this.label1, 0, 2);
            this.tlpSupport.Controls.Add(this.label2, 1, 2);
            this.tlpSupport.Controls.Add(this.label3, 2, 2);
            this.tlpSupport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSupport.Location = new System.Drawing.Point(3, 31);
            this.tlpSupport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpSupport.Name = "tlpSupport";
            this.tlpSupport.RowCount = 5;
            this.tlpSupport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSupport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSupport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSupport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSupport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSupport.Size = new System.Drawing.Size(338, 104);
            this.tlpSupport.TabIndex = 5;
            // 
            // lblEmailTitle
            // 
            this.lblEmailTitle.AutoSize = true;
            this.lblEmailTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmailTitle.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEmailTitle.Location = new System.Drawing.Point(23, 82);
            this.lblEmailTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblEmailTitle.Name = "lblEmailTitle";
            this.lblEmailTitle.Size = new System.Drawing.Size(80, 18);
            this.lblEmailTitle.TabIndex = 1;
            this.lblEmailTitle.Text = "客服信箱 :";
            this.lblEmailTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFaxValue
            // 
            this.lblFaxValue.AutoSize = true;
            this.lblFaxValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFaxValue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblFaxValue.Location = new System.Drawing.Point(109, 26);
            this.lblFaxValue.Name = "lblFaxValue";
            this.lblFaxValue.Size = new System.Drawing.Size(226, 26);
            this.lblFaxValue.TabIndex = 2;
            this.lblFaxValue.Text = "0933-722-885";
            this.lblFaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkLblEmail
            // 
            this.lnkLblEmail.AutoSize = true;
            this.lnkLblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnkLblEmail.Font = new System.Drawing.Font("Arial", 12F);
            this.lnkLblEmail.Location = new System.Drawing.Point(109, 78);
            this.lnkLblEmail.Name = "lnkLblEmail";
            this.lnkLblEmail.Size = new System.Drawing.Size(226, 26);
            this.lnkLblEmail.TabIndex = 2;
            this.lnkLblEmail.TabStop = true;
            this.lnkLblEmail.Text = "service@myp.net.tw";
            this.lnkLblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkLblEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblEmail_LinkClicked);
            // 
            // lblPhoneValue
            // 
            this.lblPhoneValue.AutoSize = true;
            this.lblPhoneValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhoneValue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPhoneValue.Location = new System.Drawing.Point(109, 0);
            this.lblPhoneValue.Name = "lblPhoneValue";
            this.lblPhoneValue.Size = new System.Drawing.Size(226, 26);
            this.lblPhoneValue.TabIndex = 0;
            this.lblPhoneValue.Text = "02-2799-3590";
            this.lblPhoneValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDotPhone
            // 
            this.lblDotPhone.AutoSize = true;
            this.lblDotPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDotPhone.Location = new System.Drawing.Point(3, 4);
            this.lblDotPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDotPhone.Name = "lblDotPhone";
            this.lblDotPhone.Size = new System.Drawing.Size(14, 18);
            this.lblDotPhone.TabIndex = 0;
            this.lblDotPhone.Text = "●";
            this.lblDotPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDotFax
            // 
            this.lblDotFax.AutoSize = true;
            this.lblDotFax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotFax.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDotFax.Location = new System.Drawing.Point(3, 30);
            this.lblDotFax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDotFax.Name = "lblDotFax";
            this.lblDotFax.Size = new System.Drawing.Size(14, 18);
            this.lblDotFax.TabIndex = 0;
            this.lblDotFax.Text = "●";
            this.lblDotFax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDotEmail
            // 
            this.lblDotEmail.AutoSize = true;
            this.lblDotEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDotEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDotEmail.Location = new System.Drawing.Point(3, 82);
            this.lblDotEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDotEmail.Name = "lblDotEmail";
            this.lblDotEmail.Size = new System.Drawing.Size(14, 18);
            this.lblDotEmail.TabIndex = 0;
            this.lblDotEmail.Text = "●";
            this.lblDotEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhoneTitle
            // 
            this.lblPhoneTitle.AutoSize = true;
            this.lblPhoneTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhoneTitle.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPhoneTitle.Location = new System.Drawing.Point(23, 4);
            this.lblPhoneTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblPhoneTitle.Name = "lblPhoneTitle";
            this.lblPhoneTitle.Size = new System.Drawing.Size(80, 18);
            this.lblPhoneTitle.TabIndex = 0;
            this.lblPhoneTitle.Text = "電話 :";
            this.lblPhoneTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFaxTitle
            // 
            this.lblFaxTitle.AutoSize = true;
            this.lblFaxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFaxTitle.Font = new System.Drawing.Font("Arial", 12F);
            this.lblFaxTitle.Location = new System.Drawing.Point(23, 30);
            this.lblFaxTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblFaxTitle.Name = "lblFaxTitle";
            this.lblFaxTitle.Size = new System.Drawing.Size(80, 18);
            this.lblFaxTitle.TabIndex = 1;
            this.lblFaxTitle.Text = "業務專線 :";
            this.lblFaxTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "●";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "傳真 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(109, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "02-2799-2556";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSupport
            // 
            this.lblSupport.AutoSize = true;
            this.lblSupport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupport.Location = new System.Drawing.Point(3, 4);
            this.lblSupport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblSupport.Name = "lblSupport";
            this.lblSupport.Size = new System.Drawing.Size(83, 19);
            this.lblSupport.TabIndex = 3;
            this.lblSupport.Text = "聯絡資訊:";
            this.lblSupport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLine1
            // 
            this.pnlLine1.AutoSize = true;
            this.pnlLine1.BackColor = System.Drawing.Color.Black;
            this.pnlLine1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLine1.Location = new System.Drawing.Point(3, 143);
            this.pnlLine1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLine1.Name = "pnlLine1";
            this.pnlLine1.Size = new System.Drawing.Size(338, 1);
            this.pnlLine1.TabIndex = 6;
            // 
            // FormAbout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(735, 283);
            this.Controls.Add(this.tlpTop);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "關於木研科技";
            this.tlpTop.ResumeLayout(false);
            this.tlpTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tlpInfo.ResumeLayout(false);
            this.tlpInfo.PerformLayout();
            this.tlpSupport.ResumeLayout(false);
            this.tlpSupport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.TableLayoutPanel tlpSupport;
        private System.Windows.Forms.Label lblEmailTitle;
        private System.Windows.Forms.LinkLabel lnkLblEmail;
        private System.Windows.Forms.Label lblPhoneValue;
        private System.Windows.Forms.Label lblDotPhone;
        private System.Windows.Forms.Label lblDotFax;
        private System.Windows.Forms.Label lblDotEmail;
        private System.Windows.Forms.Label lblPhoneTitle;
        private System.Windows.Forms.Label lblFaxTitle;
        private System.Windows.Forms.Label lblSupport;
        private System.Windows.Forms.Panel pnlLine1;
        private System.Windows.Forms.Label lblFaxValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel pnlLine2;
    }
}