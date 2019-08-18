namespace MYPAM.View
{
    partial class FormAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttendance));
            this.pdgAttendance = new TextMessage.View.Components.PageDataGridView();
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cbMonitor = new System.Windows.Forms.CheckBox();
            this.tlpBase.SuspendLayout();
            this.tlpTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdgAttendance
            // 
            this.pdgAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdgAttendance.Location = new System.Drawing.Point(0, 30);
            this.pdgAttendance.Margin = new System.Windows.Forms.Padding(0);
            this.pdgAttendance.Name = "pdgAttendance";
            this.pdgAttendance.Size = new System.Drawing.Size(684, 532);
            this.pdgAttendance.TabIndex = 0;
            this.pdgAttendance.ChangePage += new TextMessage.View.Components.PageDataGridView.ChangePageDelegate(this.PdgAttendance_ChangePage);
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBase.Controls.Add(this.pdgAttendance, 0, 1);
            this.tlpBase.Controls.Add(this.tlpTop, 0, 0);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 2;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Size = new System.Drawing.Size(684, 562);
            this.tlpBase.TabIndex = 1;
            // 
            // tlpTop
            // 
            this.tlpTop.ColumnCount = 2;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpTop.Controls.Add(this.lblInfo, 0, 0);
            this.tlpTop.Controls.Add(this.cbMonitor, 1, 0);
            this.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTop.Location = new System.Drawing.Point(0, 0);
            this.tlpTop.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.Size = new System.Drawing.Size(684, 30);
            this.tlpTop.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.lblInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInfo.Location = new System.Drawing.Point(3, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(578, 30);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "● 每頁顯示 500 筆員工考勤資訊";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbMonitor
            // 
            this.cbMonitor.AutoSize = true;
            this.cbMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMonitor.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.cbMonitor.Location = new System.Drawing.Point(587, 3);
            this.cbMonitor.Name = "cbMonitor";
            this.cbMonitor.Size = new System.Drawing.Size(94, 24);
            this.cbMonitor.TabIndex = 6;
            this.cbMonitor.Text = "即時監控";
            this.cbMonitor.UseVisualStyleBackColor = true;
            this.cbMonitor.CheckedChanged += new System.EventHandler(this.CbMonitor_CheckedChanged);
            // 
            // FormAttendance
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(684, 562);
            this.Controls.Add(this.tlpBase);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "FormAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "考勤資料";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAttendance_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.FormAttendance_VisibleChanged);
            this.tlpBase.ResumeLayout(false);
            this.tlpTop.ResumeLayout(false);
            this.tlpTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextMessage.View.Components.PageDataGridView pdgAttendance;
        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private System.Windows.Forms.CheckBox cbMonitor;
    }
}