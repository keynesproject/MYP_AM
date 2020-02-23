namespace MYPAM
{
    partial class FormMain
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiMainSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOption = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.員工資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考勤資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSeparatorSetting01 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiMYP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSeparatorSetting02 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.temiMainHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnEmployee = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAttendance = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnStartLoadDevice = new System.Windows.Forms.ToolStripButton();
            this.tsBtnStopLoadDevice = new System.Windows.Forms.ToolStripButton();
            this.tsBtnUpdateData = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnEnableDevice = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDisableDevice = new System.Windows.Forms.ToolStripButton();
            this.tsBtnDelDeviceAttendance = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnAddDevice = new System.Windows.Forms.ToolStripButton();
            this.tsBtnRemoveDevice = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnExit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAbout = new System.Windows.Forms.ToolStripButton();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tsslState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.tClock = new System.Windows.Forms.Timer(this.components);
            this.tGiveTime = new System.Windows.Forms.Timer(this.components);
            this.msMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.ssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMainSetting,
            this.temiMainHelp});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msMain.Size = new System.Drawing.Size(784, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiMainSetting
            // 
            this.tsmiMainSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOption,
            this.tsmiDatabase,
            this.tsSeparatorSetting01,
            this.tsmiMYP,
            this.tsSeparatorSetting02,
            this.tsmiExit});
            this.tsmiMainSetting.Name = "tsmiMainSetting";
            this.tsmiMainSetting.Size = new System.Drawing.Size(44, 20);
            this.tsmiMainSetting.Text = "設定";
            // 
            // tsmiOption
            // 
            this.tsmiOption.Name = "tsmiOption";
            this.tsmiOption.Size = new System.Drawing.Size(180, 22);
            this.tsmiOption.Text = "功能設定 (&S)";
            this.tsmiOption.Click += new System.EventHandler(this.TsmiOption_Click);
            // 
            // tsmiDatabase
            // 
            this.tsmiDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.員工資料ToolStripMenuItem,
            this.考勤資料ToolStripMenuItem});
            this.tsmiDatabase.Name = "tsmiDatabase";
            this.tsmiDatabase.Size = new System.Drawing.Size(180, 22);
            this.tsmiDatabase.Text = "檢視資訊 (&D)";
            // 
            // 員工資料ToolStripMenuItem
            // 
            this.員工資料ToolStripMenuItem.Name = "員工資料ToolStripMenuItem";
            this.員工資料ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.員工資料ToolStripMenuItem.Text = "員工資料 (&E)";
            this.員工資料ToolStripMenuItem.Visible = false;
            this.員工資料ToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsBtnEmployee_MouseUp);
            // 
            // 考勤資料ToolStripMenuItem
            // 
            this.考勤資料ToolStripMenuItem.Name = "考勤資料ToolStripMenuItem";
            this.考勤資料ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.考勤資料ToolStripMenuItem.Text = "考勤資料 (&A)";
            this.考勤資料ToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsbtnAttendance_MouseUp);
            // 
            // tsSeparatorSetting01
            // 
            this.tsSeparatorSetting01.Name = "tsSeparatorSetting01";
            this.tsSeparatorSetting01.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiMYP
            // 
            this.tsmiMYP.Name = "tsmiMYP";
            this.tsmiMYP.Size = new System.Drawing.Size(180, 22);
            this.tsmiMYP.Text = "MYP設定 (&O)";
            this.tsmiMYP.Click += new System.EventHandler(this.TsmiMYP_Click);
            // 
            // tsSeparatorSetting02
            // 
            this.tsSeparatorSetting02.Name = "tsSeparatorSetting02";
            this.tsSeparatorSetting02.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiExit.Text = "結束 (&X)";
            this.tsmiExit.Click += new System.EventHandler(this.TsmiExit_Click);
            // 
            // temiMainHelp
            // 
            this.temiMainHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.temiMainHelp.Name = "temiMainHelp";
            this.temiMainHelp.Size = new System.Drawing.Size(44, 20);
            this.temiMainHelp.Text = "說明";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(180, 22);
            this.tsmiAbout.Text = "關於木研科技 (&A)";
            this.tsmiAbout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsbtnAbout_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnEmployee,
            this.tsbtnAttendance,
            this.tsSeparator1,
            this.tsBtnStartLoadDevice,
            this.tsBtnStopLoadDevice,
            this.tsBtnUpdateData,
            this.tsSeparator2,
            this.tsBtnEnableDevice,
            this.tsBtnDisableDevice,
            this.tsBtnDelDeviceAttendance,
            this.tsSeparator3,
            this.tsBtnAddDevice,
            this.tsBtnRemoveDevice,
            this.tsSeparator4,
            this.tsBtnExit,
            this.tsbtnAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(784, 53);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnEmployee
            // 
            this.tsBtnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsBtnEmployee.Image = global::MYPAM.Properties.Resources.IconEmployee;
            this.tsBtnEmployee.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsBtnEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEmployee.Name = "tsBtnEmployee";
            this.tsBtnEmployee.Size = new System.Drawing.Size(60, 50);
            this.tsBtnEmployee.Text = "員工資料";
            this.tsBtnEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnEmployee.ToolTipText = "檢視員工資料";
            this.tsBtnEmployee.Visible = false;
            this.tsBtnEmployee.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsBtnEmployee_MouseUp);
            // 
            // tsbtnAttendance
            // 
            this.tsbtnAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbtnAttendance.Image = global::MYPAM.Properties.Resources.IconAttendance;
            this.tsbtnAttendance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbtnAttendance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAttendance.Name = "tsbtnAttendance";
            this.tsbtnAttendance.Size = new System.Drawing.Size(60, 50);
            this.tsbtnAttendance.Text = "考勤資料";
            this.tsbtnAttendance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnAttendance.ToolTipText = "檢視考勤資料";
            this.tsbtnAttendance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsbtnAttendance_MouseUp);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 53);
            // 
            // tsBtnStartLoadDevice
            // 
            this.tsBtnStartLoadDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsBtnStartLoadDevice.Image = global::MYPAM.Properties.Resources.IconDownload;
            this.tsBtnStartLoadDevice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsBtnStartLoadDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnStartLoadDevice.Name = "tsBtnStartLoadDevice";
            this.tsBtnStartLoadDevice.Size = new System.Drawing.Size(60, 50);
            this.tsBtnStartLoadDevice.Text = "連線下載";
            this.tsBtnStartLoadDevice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnStartLoadDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnStartLoadDevice.ToolTipText = "連線刷卡機定時讀取資訊";
            this.tsBtnStartLoadDevice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsBtnStartLoadDevice_MouseUp);
            // 
            // tsBtnStopLoadDevice
            // 
            this.tsBtnStopLoadDevice.Enabled = false;
            this.tsBtnStopLoadDevice.Image = global::MYPAM.Properties.Resources.IconStop;
            this.tsBtnStopLoadDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnStopLoadDevice.Name = "tsBtnStopLoadDevice";
            this.tsBtnStopLoadDevice.Size = new System.Drawing.Size(60, 50);
            this.tsBtnStopLoadDevice.Text = "停止連線";
            this.tsBtnStopLoadDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnStopLoadDevice.ToolTipText = "停止連線刷卡機";
            this.tsBtnStopLoadDevice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsBtnStopLoadDevice_MouseUp);
            // 
            // tsBtnUpdateData
            // 
            this.tsBtnUpdateData.Enabled = false;
            this.tsBtnUpdateData.Image = global::MYPAM.Properties.Resources.IconRefresh;
            this.tsBtnUpdateData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnUpdateData.Name = "tsBtnUpdateData";
            this.tsBtnUpdateData.Size = new System.Drawing.Size(60, 50);
            this.tsBtnUpdateData.Text = "立即更新";
            this.tsBtnUpdateData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnUpdateData.ToolTipText = "立即更新本地資料";
            this.tsBtnUpdateData.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsBtnUpdateData_MouseUp);
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 53);
            // 
            // tsBtnEnableDevice
            // 
            this.tsBtnEnableDevice.Enabled = false;
            this.tsBtnEnableDevice.Image = global::MYPAM.Properties.Resources.IconEnableDevice;
            this.tsBtnEnableDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnEnableDevice.Name = "tsBtnEnableDevice";
            this.tsBtnEnableDevice.Size = new System.Drawing.Size(60, 50);
            this.tsBtnEnableDevice.Text = "啟用設備";
            this.tsBtnEnableDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnEnableDevice.ToolTipText = "啟用刷卡機";
            this.tsBtnEnableDevice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsBtnEnableDevice_MouseUp);
            // 
            // tsBtnDisableDevice
            // 
            this.tsBtnDisableDevice.Enabled = false;
            this.tsBtnDisableDevice.Image = global::MYPAM.Properties.Resources.IconDisableDevice;
            this.tsBtnDisableDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDisableDevice.Name = "tsBtnDisableDevice";
            this.tsBtnDisableDevice.Size = new System.Drawing.Size(60, 50);
            this.tsBtnDisableDevice.Text = "禁用設備";
            this.tsBtnDisableDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnDisableDevice.ToolTipText = "禁用刷卡機";
            this.tsBtnDisableDevice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsBtnDisableDevice_MouseUp);
            // 
            // tsBtnDelDeviceAttendance
            // 
            this.tsBtnDelDeviceAttendance.Enabled = false;
            this.tsBtnDelDeviceAttendance.Image = global::MYPAM.Properties.Resources.IconClearDeviceData;
            this.tsBtnDelDeviceAttendance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelDeviceAttendance.Name = "tsBtnDelDeviceAttendance";
            this.tsBtnDelDeviceAttendance.Size = new System.Drawing.Size(60, 50);
            this.tsBtnDelDeviceAttendance.Text = "刪除考勤";
            this.tsBtnDelDeviceAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnDelDeviceAttendance.ToolTipText = "刪除刷卡機考勤資訊";
            this.tsBtnDelDeviceAttendance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsBtnDelDeviceAttendance_MouseUp);
            // 
            // tsSeparator3
            // 
            this.tsSeparator3.Name = "tsSeparator3";
            this.tsSeparator3.Size = new System.Drawing.Size(6, 53);
            // 
            // tsBtnAddDevice
            // 
            this.tsBtnAddDevice.Image = global::MYPAM.Properties.Resources.IconAddDevice;
            this.tsBtnAddDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAddDevice.Name = "tsBtnAddDevice";
            this.tsBtnAddDevice.Size = new System.Drawing.Size(60, 50);
            this.tsBtnAddDevice.Text = "新增設備";
            this.tsBtnAddDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnAddDevice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsBtnAddDevice_MouseUp);
            // 
            // tsBtnRemoveDevice
            // 
            this.tsBtnRemoveDevice.Image = global::MYPAM.Properties.Resources.IconRemoveDevice;
            this.tsBtnRemoveDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRemoveDevice.Name = "tsBtnRemoveDevice";
            this.tsBtnRemoveDevice.Size = new System.Drawing.Size(60, 50);
            this.tsBtnRemoveDevice.Text = "移除設備";
            this.tsBtnRemoveDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnRemoveDevice.ToolTipText = "移除設備";
            this.tsBtnRemoveDevice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsBtnRemoveDevice_MouseUp);
            // 
            // tsSeparator4
            // 
            this.tsSeparator4.Name = "tsSeparator4";
            this.tsSeparator4.Size = new System.Drawing.Size(6, 53);
            // 
            // tsBtnExit
            // 
            this.tsBtnExit.Image = global::MYPAM.Properties.Resources.IconPowerOff;
            this.tsBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExit.Name = "tsBtnExit";
            this.tsBtnExit.Size = new System.Drawing.Size(60, 50);
            this.tsBtnExit.Text = "退出系統";
            this.tsBtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnExit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsBtnExit_MouseUp);
            // 
            // tsbtnAbout
            // 
            this.tsbtnAbout.Image = global::MYPAM.Properties.Resources.IconInfo;
            this.tsbtnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAbout.Name = "tsbtnAbout";
            this.tsbtnAbout.Size = new System.Drawing.Size(60, 50);
            this.tsbtnAbout.Text = "關於木研";
            this.tsbtnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnAbout.ToolTipText = "關於木研科技";
            this.tsbtnAbout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TsbtnAbout_MouseUp);
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslState,
            this.tsslTime});
            this.ssStatus.Location = new System.Drawing.Point(0, 387);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.ssStatus.Size = new System.Drawing.Size(784, 25);
            this.ssStatus.TabIndex = 2;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tsslState
            // 
            this.tsslState.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslState.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.tsslState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsslState.Name = "tsslState";
            this.tsslState.Size = new System.Drawing.Size(383, 20);
            this.tsslState.Spring = true;
            this.tsslState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslTime
            // 
            this.tsslTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslTime.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.tsslTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsslTime.Name = "tsslTime";
            this.tsslTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsslTime.Size = new System.Drawing.Size(383, 20);
            this.tsslTime.Spring = true;
            this.tsslTime.Text = "上午 12:30:30";
            this.tsslTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dgvDevice.Location = new System.Drawing.Point(0, 77);
            this.dgvDevice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDevice.MultiSelect = false;
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.ReadOnly = true;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDevice.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDevice.RowHeadersVisible = false;
            this.dgvDevice.RowTemplate.Height = 24;
            this.dgvDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevice.Size = new System.Drawing.Size(784, 310);
            this.dgvDevice.TabIndex = 3;
            this.dgvDevice.TabStop = false;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
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
            // 
            // tClock
            // 
            this.tClock.Enabled = true;
            this.tClock.Tick += new System.EventHandler(this.TClock_Tick);
            // 
            // tGiveTime
            // 
            this.tGiveTime.Interval = 60000;
            this.tGiveTime.Tick += new System.EventHandler(this.TGiveTime_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.dgvDevice);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.msMain);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.Text = "木研科技-出勤管理系統 V1.0.0.2";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainSetting;
        private System.Windows.Forms.ToolStripMenuItem temiMainHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnStartLoadDevice;
        private System.Windows.Forms.ToolStripButton tsBtnStopLoadDevice;
        private System.Windows.Forms.ToolStripSeparator tsSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnAddDevice;
        private System.Windows.Forms.ToolStripMenuItem tsmiDatabase;
        private System.Windows.Forms.ToolStripSeparator tsSeparatorSetting01;
        private System.Windows.Forms.ToolStripMenuItem tsmiMYP;
        private System.Windows.Forms.ToolStripSeparator tsSeparatorSetting02;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripButton tsBtnRemoveDevice;
        private System.Windows.Forms.ToolStripSeparator tsSeparator4;
        private System.Windows.Forms.ToolStripButton tsBtnExit;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime;
        private System.Windows.Forms.DataGridView dgvDevice;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripSeparator tsSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnEnableDevice;
        private System.Windows.Forms.ToolStripButton tsBtnDisableDevice;
        private System.Windows.Forms.ToolStripMenuItem tsmiOption;
        private System.Windows.Forms.ToolStripButton tsBtnUpdateData;
        private System.Windows.Forms.ToolStripButton tsBtnDelDeviceAttendance;
        private System.Windows.Forms.ToolStripStatusLabel tsslState;
        private System.Windows.Forms.Timer tClock;
        private System.Windows.Forms.Timer tGiveTime;
        private System.Windows.Forms.ToolStripMenuItem 員工資料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考勤資料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtnAbout;
        private System.Windows.Forms.ToolStripButton tsBtnEmployee;
        private System.Windows.Forms.ToolStripButton tsbtnAttendance;
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
    }
}

