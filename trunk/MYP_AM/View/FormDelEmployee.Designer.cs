namespace MYPAM.View
{
    partial class FormDelEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDelEmployee));
            this.tlpSetting = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserID = new System.Windows.Forms.Label();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
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
            this.tlpSetting.Controls.Add(this.lblUserID, 1, 1);
            this.tlpSetting.Controls.Add(this.tbUserID, 2, 1);
            this.tlpSetting.Controls.Add(this.tlpButton, 2, 2);
            this.tlpSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSetting.Location = new System.Drawing.Point(0, 0);
            this.tlpSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpSetting.Name = "tlpSetting";
            this.tlpSetting.RowCount = 3;
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSetting.Size = new System.Drawing.Size(382, 130);
            this.tlpSetting.TabIndex = 1;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserID.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblUserID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserID.Location = new System.Drawing.Point(15, 12);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(64, 33);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "員工編號";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbUserID
            // 
            this.tbUserID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUserID.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.tbUserID.Location = new System.Drawing.Point(85, 16);
            this.tbUserID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUserID.MaxLength = 16;
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(282, 25);
            this.tbUserID.TabIndex = 0;
            // 
            // tlpButton
            // 
            this.tlpButton.ColumnCount = 3;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpButton.Controls.Add(this.btnDel, 1, 0);
            this.tlpButton.Controls.Add(this.btnExit, 2, 0);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton.Location = new System.Drawing.Point(85, 49);
            this.tlpButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.Size = new System.Drawing.Size(282, 77);
            this.tlpButton.TabIndex = 7;
            // 
            // btnDel
            // 
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDel.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnDel.Location = new System.Drawing.Point(64, 8);
            this.btnDel.Margin = new System.Windows.Forms.Padding(8);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(96, 61);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "刪除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnDel_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnExit.Location = new System.Drawing.Point(176, 8);
            this.btnExit.Margin = new System.Windows.Forms.Padding(8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 61);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnExit_MouseUp);
            // 
            // FormDelEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(382, 130);
            this.Controls.Add(this.tlpSetting);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDelEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "刪除員工資訊作業";
            this.tlpSetting.ResumeLayout(false);
            this.tlpSetting.PerformLayout();
            this.tlpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSetting;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
    }
}