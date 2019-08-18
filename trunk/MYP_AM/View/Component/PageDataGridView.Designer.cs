namespace TextMessage.View.Components
{
    partial class PageDataGridView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPageCheange = new System.Windows.Forms.TableLayoutPanel();
            this.tbCurrentPage = new System.Windows.Forms.TextBox();
            this.lblTotalPage = new System.Windows.Forms.Label();
            this.btnArrowFirst = new System.Windows.Forms.Button();
            this.btnArrowLeft = new System.Windows.Forms.Button();
            this.btnArrowRight = new System.Windows.Forms.Button();
            this.btnArrowLast = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.tlpBase.SuspendLayout();
            this.tlpPageCheange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBase.Controls.Add(this.tlpPageCheange, 0, 1);
            this.tlpBase.Controls.Add(this.dgvData, 0, 0);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 2;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpBase.Size = new System.Drawing.Size(546, 389);
            this.tlpBase.TabIndex = 0;
            // 
            // tlpPageCheange
            // 
            this.tlpPageCheange.ColumnCount = 8;
            this.tlpPageCheange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPageCheange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpPageCheange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpPageCheange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpPageCheange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpPageCheange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpPageCheange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpPageCheange.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPageCheange.Controls.Add(this.tbCurrentPage, 3, 0);
            this.tlpPageCheange.Controls.Add(this.lblTotalPage, 4, 0);
            this.tlpPageCheange.Controls.Add(this.btnArrowFirst, 1, 0);
            this.tlpPageCheange.Controls.Add(this.btnArrowLeft, 2, 0);
            this.tlpPageCheange.Controls.Add(this.btnArrowRight, 5, 0);
            this.tlpPageCheange.Controls.Add(this.btnArrowLast, 6, 0);
            this.tlpPageCheange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPageCheange.Location = new System.Drawing.Point(3, 362);
            this.tlpPageCheange.Name = "tlpPageCheange";
            this.tlpPageCheange.RowCount = 1;
            this.tlpPageCheange.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPageCheange.Size = new System.Drawing.Size(540, 24);
            this.tlpPageCheange.TabIndex = 9;
            // 
            // tbCurrentPage
            // 
            this.tbCurrentPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCurrentPage.Font = new System.Drawing.Font("Arial", 12F);
            this.tbCurrentPage.Location = new System.Drawing.Point(210, 0);
            this.tbCurrentPage.Margin = new System.Windows.Forms.Padding(0);
            this.tbCurrentPage.MaxLength = 3;
            this.tbCurrentPage.Name = "tbCurrentPage";
            this.tbCurrentPage.ShortcutsEnabled = false;
            this.tbCurrentPage.Size = new System.Drawing.Size(50, 26);
            this.tbCurrentPage.TabIndex = 2;
            this.tbCurrentPage.Text = "1";
            this.tbCurrentPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCurrentPage.WordWrap = false;
            this.tbCurrentPage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCurrentPage_KeyDown);
            this.tbCurrentPage.Leave += new System.EventHandler(this.tbCurrentPage_Leave);
            // 
            // lblTotalPage
            // 
            this.lblTotalPage.AutoSize = true;
            this.lblTotalPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPage.Location = new System.Drawing.Point(263, 0);
            this.lblTotalPage.Name = "lblTotalPage";
            this.lblTotalPage.Size = new System.Drawing.Size(64, 24);
            this.lblTotalPage.TabIndex = 5;
            this.lblTotalPage.Text = "of 1";
            this.lblTotalPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnArrowFirst
            // 
            this.btnArrowFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArrowFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArrowFirst.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnArrowFirst.Location = new System.Drawing.Point(140, 0);
            this.btnArrowFirst.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnArrowFirst.Name = "btnArrowFirst";
            this.btnArrowFirst.Size = new System.Drawing.Size(30, 24);
            this.btnArrowFirst.TabIndex = 0;
            this.btnArrowFirst.Text = "|<";
            this.btnArrowFirst.UseVisualStyleBackColor = true;
            this.btnArrowFirst.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnArrowFirst_MouseUp);
            // 
            // btnArrowLeft
            // 
            this.btnArrowLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArrowLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArrowLeft.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnArrowLeft.Location = new System.Drawing.Point(175, 0);
            this.btnArrowLeft.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnArrowLeft.Name = "btnArrowLeft";
            this.btnArrowLeft.Size = new System.Drawing.Size(30, 24);
            this.btnArrowLeft.TabIndex = 1;
            this.btnArrowLeft.Text = "<";
            this.btnArrowLeft.UseVisualStyleBackColor = true;
            this.btnArrowLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnArrowLeft_MouseUp);
            // 
            // btnArrowRight
            // 
            this.btnArrowRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArrowRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArrowRight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnArrowRight.Location = new System.Drawing.Point(335, 0);
            this.btnArrowRight.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnArrowRight.Name = "btnArrowRight";
            this.btnArrowRight.Size = new System.Drawing.Size(30, 24);
            this.btnArrowRight.TabIndex = 3;
            this.btnArrowRight.Text = ">";
            this.btnArrowRight.UseVisualStyleBackColor = true;
            this.btnArrowRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnArrowRight_MouseUp);
            // 
            // btnArrowLast
            // 
            this.btnArrowLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArrowLast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArrowLast.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnArrowLast.Location = new System.Drawing.Point(370, 0);
            this.btnArrowLast.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnArrowLast.Name = "btnArrowLast";
            this.btnArrowLast.Size = new System.Drawing.Size(30, 24);
            this.btnArrowLast.TabIndex = 4;
            this.btnArrowLast.Text = ">|";
            this.btnArrowLast.UseVisualStyleBackColor = true;
            this.btnArrowLast.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnArrowLast_MouseUp);
            // 
            // dgvData
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Margin = new System.Windows.Forms.Padding(0);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(546, 359);
            this.dgvData.TabIndex = 8;
            // 
            // PageDataGridView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tlpBase);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PageDataGridView";
            this.Size = new System.Drawing.Size(546, 389);
            this.Load += new System.EventHandler(this.PageDataGridView_Load);
            this.tlpBase.ResumeLayout(false);
            this.tlpPageCheange.ResumeLayout(false);
            this.tlpPageCheange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TableLayoutPanel tlpPageCheange;
        private System.Windows.Forms.TextBox tbCurrentPage;
        private System.Windows.Forms.Label lblTotalPage;
        private System.Windows.Forms.Button btnArrowFirst;
        private System.Windows.Forms.Button btnArrowLeft;
        private System.Windows.Forms.Button btnArrowRight;
        private System.Windows.Forms.Button btnArrowLast;
    }
}
