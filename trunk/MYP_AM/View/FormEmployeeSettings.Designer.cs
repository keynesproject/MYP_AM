namespace MYPAM.View
{
    partial class FormEmployeeSettings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployeeSettings));
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpDevice = new System.Windows.Forms.TableLayoutPanel();
            this.cbAllEmployee = new System.Windows.Forms.CheckBox();
            this.gbDevice = new System.Windows.Forms.GroupBox();
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEnable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStrEnable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnConnect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStrConnect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAttCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttlpEmployee = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.employeeSettings1 = new MYPAM.View.Component.EmployeeSettings();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnAddEmployee = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCancelAddEmployee = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelEmployee = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnUpload = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDownload = new System.Windows.Forms.ToolStripButton();
            this.tlpBase.SuspendLayout();
            this.tlpDevice.SuspendLayout();
            this.gbDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            this.ttlpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.AutoSize = true;
            this.tlpBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpBase.ColumnCount = 3;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Controls.Add(this.panel1, 0, 0);
            this.tlpBase.Controls.Add(this.tlpDevice, 0, 0);
            this.tlpBase.Controls.Add(this.ttlpEmployee, 2, 0);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 53);
            this.tlpBase.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 1;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Size = new System.Drawing.Size(784, 509);
            this.tlpBase.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(203, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 509);
            this.panel1.TabIndex = 8;
            // 
            // tlpDevice
            // 
            this.tlpDevice.AutoSize = true;
            this.tlpDevice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpDevice.ColumnCount = 1;
            this.tlpDevice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDevice.Controls.Add(this.cbAllEmployee, 0, 0);
            this.tlpDevice.Controls.Add(this.gbDevice, 0, 1);
            this.tlpDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDevice.Location = new System.Drawing.Point(3, 3);
            this.tlpDevice.Name = "tlpDevice";
            this.tlpDevice.RowCount = 2;
            this.tlpDevice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpDevice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDevice.Size = new System.Drawing.Size(194, 503);
            this.tlpDevice.TabIndex = 9;
            // 
            // cbAllEmployee
            // 
            this.cbAllEmployee.AutoSize = true;
            this.cbAllEmployee.BackColor = System.Drawing.Color.Cornsilk;
            this.cbAllEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbAllEmployee.Checked = true;
            this.cbAllEmployee.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAllEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAllEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAllEmployee.Font = new System.Drawing.Font("Arial", 12F);
            this.cbAllEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbAllEmployee.Location = new System.Drawing.Point(3, 3);
            this.cbAllEmployee.Name = "cbAllEmployee";
            this.cbAllEmployee.Size = new System.Drawing.Size(188, 34);
            this.cbAllEmployee.TabIndex = 0;
            this.cbAllEmployee.TabStop = false;
            this.cbAllEmployee.Text = "全體員工資訊";
            this.cbAllEmployee.UseVisualStyleBackColor = false;
            this.cbAllEmployee.CheckStateChanged += new System.EventHandler(this.CbAllEmployee_CheckStateChanged);
            // 
            // gbDevice
            // 
            this.gbDevice.AutoSize = true;
            this.gbDevice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbDevice.Controls.Add(this.dgvDevice);
            this.gbDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDevice.Font = new System.Drawing.Font("Arial", 12F);
            this.gbDevice.Location = new System.Drawing.Point(3, 43);
            this.gbDevice.Name = "gbDevice";
            this.gbDevice.Size = new System.Drawing.Size(188, 457);
            this.gbDevice.TabIndex = 1;
            this.gbDevice.TabStop = false;
            this.gbDevice.Text = "考勤設備";
            // 
            // dgvDevice
            // 
            this.dgvDevice.AllowUserToAddRows = false;
            this.dgvDevice.AllowUserToDeleteRows = false;
            this.dgvDevice.AllowUserToResizeRows = false;
            this.dgvDevice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDevice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice.ColumnHeadersVisible = false;
            this.dgvDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.columnName,
            this.ColumnLocation,
            this.columnEnable,
            this.columnStrEnable,
            this.columnConnect,
            this.columnStrConnect,
            this.columnNo,
            this.columnIP,
            this.columnPort,
            this.columnAttCount});
            this.dgvDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDevice.Location = new System.Drawing.Point(3, 22);
            this.dgvDevice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDevice.MultiSelect = false;
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.ReadOnly = true;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDevice.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDevice.RowHeadersVisible = false;
            this.dgvDevice.RowTemplate.Height = 24;
            this.dgvDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevice.Size = new System.Drawing.Size(182, 432);
            this.dgvDevice.TabIndex = 4;
            this.dgvDevice.TabStop = false;
            this.dgvDevice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDevice_CellClick);
            this.dgvDevice.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvDevice_DataBindingComplete);
            // 
            // columnID
            // 
            this.columnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnID.DataPropertyName = "ID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnID.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnID.HeaderText = "ID";
            this.columnID.MaxInputLength = 4;
            this.columnID.MinimumWidth = 25;
            this.columnID.Name = "columnID";
            this.columnID.ReadOnly = true;
            this.columnID.Visible = false;
            // 
            // columnName
            // 
            this.columnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnName.DataPropertyName = "Name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.columnName.DefaultCellStyle = dataGridViewCellStyle3;
            this.columnName.HeaderText = "設備名稱";
            this.columnName.MaxInputLength = 128;
            this.columnName.MinimumWidth = 130;
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // ColumnLocation
            // 
            this.ColumnLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnLocation.DataPropertyName = "Location";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnLocation.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnLocation.FillWeight = 70F;
            this.ColumnLocation.HeaderText = "地點代碼";
            this.ColumnLocation.MaxInputLength = 2;
            this.ColumnLocation.MinimumWidth = 80;
            this.ColumnLocation.Name = "ColumnLocation";
            this.ColumnLocation.ReadOnly = true;
            this.ColumnLocation.Visible = false;
            // 
            // columnEnable
            // 
            this.columnEnable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnEnable.DataPropertyName = "Enable";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnEnable.DefaultCellStyle = dataGridViewCellStyle5;
            this.columnEnable.HeaderText = "啟用狀態";
            this.columnEnable.MaxInputLength = 128;
            this.columnEnable.MinimumWidth = 80;
            this.columnEnable.Name = "columnEnable";
            this.columnEnable.ReadOnly = true;
            this.columnEnable.Visible = false;
            // 
            // columnStrEnable
            // 
            this.columnStrEnable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnStrEnable.DataPropertyName = "strEnable";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnStrEnable.DefaultCellStyle = dataGridViewCellStyle6;
            this.columnStrEnable.HeaderText = "啟用狀態";
            this.columnStrEnable.MaxInputLength = 128;
            this.columnStrEnable.MinimumWidth = 80;
            this.columnStrEnable.Name = "columnStrEnable";
            this.columnStrEnable.ReadOnly = true;
            this.columnStrEnable.Visible = false;
            // 
            // columnConnect
            // 
            this.columnConnect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnConnect.DataPropertyName = "Connect";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnConnect.DefaultCellStyle = dataGridViewCellStyle7;
            this.columnConnect.HeaderText = "連線狀態";
            this.columnConnect.MaxInputLength = 128;
            this.columnConnect.MinimumWidth = 80;
            this.columnConnect.Name = "columnConnect";
            this.columnConnect.ReadOnly = true;
            this.columnConnect.Visible = false;
            // 
            // columnStrConnect
            // 
            this.columnStrConnect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnStrConnect.DataPropertyName = "strConnect";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnStrConnect.DefaultCellStyle = dataGridViewCellStyle8;
            this.columnStrConnect.HeaderText = "連線狀態";
            this.columnStrConnect.MaxInputLength = 128;
            this.columnStrConnect.MinimumWidth = 80;
            this.columnStrConnect.Name = "columnStrConnect";
            this.columnStrConnect.ReadOnly = true;
            this.columnStrConnect.Visible = false;
            // 
            // columnNo
            // 
            this.columnNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnNo.DataPropertyName = "MachineNo";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnNo.DefaultCellStyle = dataGridViewCellStyle9;
            this.columnNo.HeaderText = "機器號";
            this.columnNo.MaxInputLength = 4;
            this.columnNo.MinimumWidth = 70;
            this.columnNo.Name = "columnNo";
            this.columnNo.ReadOnly = true;
            this.columnNo.Visible = false;
            // 
            // columnIP
            // 
            this.columnIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnIP.DataPropertyName = "IP";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnIP.DefaultCellStyle = dataGridViewCellStyle10;
            this.columnIP.HeaderText = "IP地址";
            this.columnIP.MaxInputLength = 128;
            this.columnIP.MinimumWidth = 110;
            this.columnIP.Name = "columnIP";
            this.columnIP.ReadOnly = true;
            this.columnIP.Visible = false;
            // 
            // columnPort
            // 
            this.columnPort.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPort.DataPropertyName = "Port";
            this.columnPort.HeaderText = "埠號";
            this.columnPort.MaxInputLength = 6;
            this.columnPort.MinimumWidth = 80;
            this.columnPort.Name = "columnPort";
            this.columnPort.ReadOnly = true;
            this.columnPort.Visible = false;
            // 
            // columnAttCount
            // 
            this.columnAttCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnAttCount.DataPropertyName = "AttendanceCount";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnAttCount.DefaultCellStyle = dataGridViewCellStyle11;
            this.columnAttCount.HeaderText = "考勤紀錄";
            this.columnAttCount.MaxInputLength = 10;
            this.columnAttCount.MinimumWidth = 80;
            this.columnAttCount.Name = "columnAttCount";
            this.columnAttCount.ReadOnly = true;
            this.columnAttCount.Visible = false;
            // 
            // ttlpEmployee
            // 
            this.ttlpEmployee.AutoSize = true;
            this.ttlpEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ttlpEmployee.ColumnCount = 1;
            this.ttlpEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ttlpEmployee.Controls.Add(this.pnlLine1, 0, 1);
            this.ttlpEmployee.Controls.Add(this.dgvEmployee, 0, 0);
            this.ttlpEmployee.Controls.Add(this.employeeSettings1, 0, 2);
            this.ttlpEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ttlpEmployee.Location = new System.Drawing.Point(208, 0);
            this.ttlpEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.ttlpEmployee.Name = "ttlpEmployee";
            this.ttlpEmployee.RowCount = 3;
            this.ttlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ttlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.ttlpEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ttlpEmployee.Size = new System.Drawing.Size(576, 509);
            this.ttlpEmployee.TabIndex = 10;
            // 
            // pnlLine1
            // 
            this.pnlLine1.AutoSize = true;
            this.pnlLine1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlLine1.BackColor = System.Drawing.Color.Black;
            this.pnlLine1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLine1.Location = new System.Drawing.Point(3, 330);
            this.pnlLine1.Name = "pnlLine1";
            this.pnlLine1.Size = new System.Drawing.Size(570, 2);
            this.pnlLine1.TabIndex = 7;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(576, 327);
            this.dgvEmployee.TabIndex = 10;
            this.dgvEmployee.TabStop = false;
            this.dgvEmployee.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvEmployee_DataBindingComplete);
            this.dgvEmployee.SelectionChanged += new System.EventHandler(this.DgvEmployee_SelectionChanged);
            // 
            // employeeSettings1
            // 
            this.employeeSettings1.AutoSize = true;
            this.employeeSettings1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.employeeSettings1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeSettings1.DataLayout = true;
            this.employeeSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeSettings1.Location = new System.Drawing.Point(3, 338);
            this.employeeSettings1.Name = "employeeSettings1";
            this.employeeSettings1.Size = new System.Drawing.Size(570, 168);
            this.employeeSettings1.TabIndex = 1;
            this.employeeSettings1.Leave += new System.EventHandler(this.EmployeeSettings1_Leave);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnAddEmployee,
            this.tsBtnCancelAddEmployee,
            this.tsBtnDelEmployee,
            this.toolStripSeparator1,
            this.tsBtnUpload,
            this.tsBtnDownload});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(784, 53);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnAddEmployee
            // 
            this.tsBtnAddEmployee.Image = global::MYPAM.Properties.Resources.IconAddDevice;
            this.tsBtnAddEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAddEmployee.Name = "tsBtnAddEmployee";
            this.tsBtnAddEmployee.Size = new System.Drawing.Size(60, 50);
            this.tsBtnAddEmployee.Text = "新增員工";
            this.tsBtnAddEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnAddEmployee.ToolTipText = "新增員工資訊";
            this.tsBtnAddEmployee.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsBtnAddEmployee_MouseUp);
            // 
            // tsBtnCancelAddEmployee
            // 
            this.tsBtnCancelAddEmployee.Image = global::MYPAM.Properties.Resources.IconCross;
            this.tsBtnCancelAddEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCancelAddEmployee.Name = "tsBtnCancelAddEmployee";
            this.tsBtnCancelAddEmployee.Size = new System.Drawing.Size(60, 50);
            this.tsBtnCancelAddEmployee.Text = "取消新增";
            this.tsBtnCancelAddEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnCancelAddEmployee.ToolTipText = "取消新增員工資訊";
            this.tsBtnCancelAddEmployee.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsBtnCancelAddEmployee_MouseUp);
            // 
            // tsBtnDelEmployee
            // 
            this.tsBtnDelEmployee.Image = global::MYPAM.Properties.Resources.IconRemoveDevice;
            this.tsBtnDelEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelEmployee.Name = "tsBtnDelEmployee";
            this.tsBtnDelEmployee.Size = new System.Drawing.Size(60, 50);
            this.tsBtnDelEmployee.Text = "刪除員工";
            this.tsBtnDelEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnDelEmployee.ToolTipText = "刪除員工資訊";
            this.tsBtnDelEmployee.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsBtnDelEmployee_MouseUp);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 53);
            // 
            // tsBtnUpload
            // 
            this.tsBtnUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsBtnUpload.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnUpload.Image")));
            this.tsBtnUpload.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsBtnUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnUpload.Name = "tsBtnUpload";
            this.tsBtnUpload.Size = new System.Drawing.Size(60, 50);
            this.tsBtnUpload.Text = "上傳資訊";
            this.tsBtnUpload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnUpload.ToolTipText = "上傳員工資訊";
            this.tsBtnUpload.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsBtnUpload_MouseUp);
            // 
            // tsBtnDownload
            // 
            this.tsBtnDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsBtnDownload.Image = global::MYPAM.Properties.Resources.IconDownload;
            this.tsBtnDownload.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsBtnDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDownload.Name = "tsBtnDownload";
            this.tsBtnDownload.Size = new System.Drawing.Size(60, 50);
            this.tsBtnDownload.Text = "下載資訊";
            this.tsBtnDownload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnDownload.ToolTipText = "下載員工資訊";
            this.tsBtnDownload.Visible = false;
            this.tsBtnDownload.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsBtnDownload_MouseUp);
            // 
            // FormEmployeeSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tlpBase);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormEmployeeSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "員工維護";
            this.tlpBase.ResumeLayout(false);
            this.tlpBase.PerformLayout();
            this.tlpDevice.ResumeLayout(false);
            this.tlpDevice.PerformLayout();
            this.gbDevice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            this.ttlpEmployee.ResumeLayout(false);
            this.ttlpEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlLine1;
        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnAddEmployee;
        private System.Windows.Forms.ToolStripButton tsBtnDelEmployee;
        private System.Windows.Forms.TableLayoutPanel tlpDevice;
        private System.Windows.Forms.CheckBox cbAllEmployee;
        private System.Windows.Forms.GroupBox gbDevice;
        private Component.EmployeeSettings employeeSettings1;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnUpload;
        private System.Windows.Forms.ToolStripButton tsBtnDownload;
        private System.Windows.Forms.TableLayoutPanel ttlpEmployee;
        private System.Windows.Forms.DataGridView dgvDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEnable;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStrEnable;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnConnect;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStrConnect;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAttCount;
        private System.Windows.Forms.ToolStripButton tsBtnCancelAddEmployee;
    }
}