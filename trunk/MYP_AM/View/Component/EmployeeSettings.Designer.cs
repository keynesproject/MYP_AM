using TextMessage.View.EventHandlers;

namespace MYPAM.View.Component
{
    partial class EmployeeSettings
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            tbUserID.KeyPress -= KeyEventHandlers.KeyNumOnly;
            tbCardNum.KeyPress -= KeyEventHandlers.KeyNumOnly;

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpSetting = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblCardNum = new System.Windows.Forms.Label();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.tbCardNum = new System.Windows.Forms.TextBox();
            this.lblPrivilege = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbEnable = new System.Windows.Forms.ComboBox();
            this.lblEnable = new System.Windows.Forms.Label();
            this.cbPrivilege = new System.Windows.Forms.ComboBox();
            this.tlpSetting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpSetting
            // 
            this.tlpSetting.AutoSize = true;
            this.tlpSetting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpSetting.ColumnCount = 4;
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpSetting.Controls.Add(this.lblUserID, 1, 1);
            this.tlpSetting.Controls.Add(this.lblCardNum, 1, 3);
            this.tlpSetting.Controls.Add(this.tbUserID, 2, 1);
            this.tlpSetting.Controls.Add(this.tbCardNum, 2, 3);
            this.tlpSetting.Controls.Add(this.lblPrivilege, 1, 4);
            this.tlpSetting.Controls.Add(this.lblName, 1, 2);
            this.tlpSetting.Controls.Add(this.tbName, 2, 2);
            this.tlpSetting.Controls.Add(this.tableLayoutPanel1, 2, 4);
            this.tlpSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSetting.Location = new System.Drawing.Point(0, 0);
            this.tlpSetting.Name = "tlpSetting";
            this.tlpSetting.RowCount = 6;
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpSetting.Size = new System.Drawing.Size(526, 152);
            this.tlpSetting.TabIndex = 0;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserID.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblUserID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserID.Location = new System.Drawing.Point(11, 11);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(3);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(64, 27);
            this.lblUserID.TabIndex = 4;
            this.lblUserID.Text = "員工編號";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCardNum
            // 
            this.lblCardNum.AutoSize = true;
            this.lblCardNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCardNum.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblCardNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCardNum.Location = new System.Drawing.Point(11, 77);
            this.lblCardNum.Margin = new System.Windows.Forms.Padding(3);
            this.lblCardNum.Name = "lblCardNum";
            this.lblCardNum.Size = new System.Drawing.Size(64, 27);
            this.lblCardNum.TabIndex = 6;
            this.lblCardNum.Text = "卡       號";
            this.lblCardNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbUserID
            // 
            this.tbUserID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUserID.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.tbUserID.Location = new System.Drawing.Point(81, 12);
            this.tbUserID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUserID.MaxLength = 6;
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(434, 25);
            this.tbUserID.TabIndex = 0;
            // 
            // tbCardNum
            // 
            this.tbCardNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCardNum.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.tbCardNum.Location = new System.Drawing.Point(81, 78);
            this.tbCardNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCardNum.MaxLength = 10;
            this.tbCardNum.Name = "tbCardNum";
            this.tbCardNum.Size = new System.Drawing.Size(434, 25);
            this.tbCardNum.TabIndex = 2;
            // 
            // lblPrivilege
            // 
            this.lblPrivilege.AutoSize = true;
            this.lblPrivilege.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrivilege.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblPrivilege.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrivilege.Location = new System.Drawing.Point(11, 110);
            this.lblPrivilege.Margin = new System.Windows.Forms.Padding(3);
            this.lblPrivilege.Name = "lblPrivilege";
            this.lblPrivilege.Size = new System.Drawing.Size(64, 31);
            this.lblPrivilege.TabIndex = 7;
            this.lblPrivilege.Text = "權       限";
            this.lblPrivilege.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Location = new System.Drawing.Point(11, 44);
            this.lblName.Margin = new System.Windows.Forms.Padding(3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 27);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "姓       名";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.tbName.Location = new System.Drawing.Point(81, 45);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbName.MaxLength = 128;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(434, 25);
            this.tbName.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.Controls.Add(this.cbEnable, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEnable, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbPrivilege, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(81, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 31);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // cbEnable
            // 
            this.cbEnable.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbEnable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEnable.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.cbEnable.FormattingEnabled = true;
            this.cbEnable.Items.AddRange(new object[] {
            "啟用",
            "禁用"});
            this.cbEnable.Location = new System.Drawing.Point(254, 3);
            this.cbEnable.Name = "cbEnable";
            this.cbEnable.Size = new System.Drawing.Size(93, 25);
            this.cbEnable.TabIndex = 8;
            this.cbEnable.Visible = false;
            // 
            // lblEnable
            // 
            this.lblEnable.AutoSize = true;
            this.lblEnable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnable.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblEnable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEnable.Location = new System.Drawing.Point(184, 3);
            this.lblEnable.Margin = new System.Windows.Forms.Padding(3);
            this.lblEnable.Name = "lblEnable";
            this.lblEnable.Size = new System.Drawing.Size(64, 25);
            this.lblEnable.TabIndex = 7;
            this.lblEnable.Text = "啟       用";
            this.lblEnable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEnable.Visible = false;
            // 
            // cbPrivilege
            // 
            this.cbPrivilege.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbPrivilege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrivilege.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.cbPrivilege.FormattingEnabled = true;
            this.cbPrivilege.Items.AddRange(new object[] {
            "0:一般用戶",
            "1:登記員",
            "2:管理員",
            "3:超級管理員"});
            this.cbPrivilege.Location = new System.Drawing.Point(3, 3);
            this.cbPrivilege.Name = "cbPrivilege";
            this.cbPrivilege.Size = new System.Drawing.Size(93, 25);
            this.cbPrivilege.TabIndex = 3;
            this.cbPrivilege.SelectedIndexChanged += new System.EventHandler(this.CbPrivilege_SelectedIndexChanged);
            // 
            // EmployeeSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tlpSetting);
            this.Name = "EmployeeSettings";
            this.Size = new System.Drawing.Size(526, 152);
            this.tlpSetting.ResumeLayout(false);
            this.tlpSetting.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSetting;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblCardNum;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.TextBox tbCardNum;
        private System.Windows.Forms.Label lblPrivilege;
        private System.Windows.Forms.ComboBox cbPrivilege;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbEnable;
        private System.Windows.Forms.Label lblEnable;
    }
}
