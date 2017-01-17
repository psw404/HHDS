namespace MyPCAN_USB
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cmbBaudrate = new System.Windows.Forms.ComboBox();
            this.cmbHardWare = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslCANStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSend_Sum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslRece_Sum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSendMsgeStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSendMsgStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslRunStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTimeShow = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDataSave = new System.Windows.Forms.Button();
            this.btnDataShow = new System.Windows.Forms.Button();
            this.btnSetParamaters = new System.Windows.Forms.Button();
            this.btnShowCurve = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEngineVelocity = new System.Windows.Forms.Label();
            this.lblHighPressure = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSlipPump = new System.Windows.Forms.Label();
            this.lablel6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCarVelocity = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbDrawChoose = new System.Windows.Forms.ComboBox();
            this.btnEndDraw = new System.Windows.Forms.Button();
            this.btnStartDraw = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSlipPumpReleaseSign = new System.Windows.Forms.Button();
            this.btnReleaseSign = new System.Windows.Forms.Button();
            this.btnRecycleSign = new System.Windows.Forms.Button();
            this.btnPumpMotorReleaseSign = new System.Windows.Forms.Button();
            this.btnPumpCtrSign = new System.Windows.Forms.Button();
            this.btnMotorCtrSign = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbRecycleSign_on = new System.Windows.Forms.RadioButton();
            this.rdbRecycleSign_Off = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbReleaseSign_on = new System.Windows.Forms.RadioButton();
            this.rdbReleaseSign_off = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdbSlipPumpReleaseSign_on = new System.Windows.Forms.RadioButton();
            this.rdbSlipPumpReleaseSign_off = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdbPumpMotorReleaseSign_on = new System.Windows.Forms.RadioButton();
            this.rdbPumpMotorReleaseSign_off = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPumpCtrSign = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtMotorCtrSign = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timeDispalyMsg = new System.Windows.Forms.Timer(this.components);
            this.TimeShow = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.cmbBaudrate);
            this.groupBox1.Controls.Add(this.cmbHardWare);
            this.groupBox1.Location = new System.Drawing.Point(3, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(311, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CAN卡配置";
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(187, 63);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(187, 23);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 29);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cmbBaudrate
            // 
            this.cmbBaudrate.FormattingEnabled = true;
            this.cmbBaudrate.Items.AddRange(new object[] {
            "1 MBit/sec",
            "800 kBit/s",
            "500 kBit/sec",
            "250 kBit/sec",
            "125 kBit/sec",
            "100 kBit/sec"});
            this.cmbBaudrate.Location = new System.Drawing.Point(8, 66);
            this.cmbBaudrate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbBaudrate.Name = "cmbBaudrate";
            this.cmbBaudrate.Size = new System.Drawing.Size(169, 23);
            this.cmbBaudrate.TabIndex = 0;
            this.cmbBaudrate.SelectedIndexChanged += new System.EventHandler(this.cmbBaudrate_SelectedIndexChanged);
            // 
            // cmbHardWare
            // 
            this.cmbHardWare.FormattingEnabled = true;
            this.cmbHardWare.Location = new System.Drawing.Point(8, 25);
            this.cmbHardWare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbHardWare.Name = "cmbHardWare";
            this.cmbHardWare.Size = new System.Drawing.Size(169, 23);
            this.cmbHardWare.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslCANStatus,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel1,
            this.tsslSend_Sum,
            this.toolStripStatusLabel3,
            this.tsslRece_Sum,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel2,
            this.tsslSendMsgeStatus,
            this.toolStripStatusLabel4,
            this.tsslSendMsgStatus,
            this.toolStripStatusLabel5,
            this.tsslRunStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 814);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1592, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "状态：";
            // 
            // tsslCANStatus
            // 
            this.tsslCANStatus.Name = "tsslCANStatus";
            this.tsslCANStatus.Size = new System.Drawing.Size(102, 20);
            this.tsslCANStatus.Text = "CAN卡未打开";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabel7.Text = "||";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel1.Text = "数据发送：";
            // 
            // tsslSend_Sum
            // 
            this.tsslSend_Sum.Name = "tsslSend_Sum";
            this.tsslSend_Sum.Size = new System.Drawing.Size(18, 20);
            this.tsslSend_Sum.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel3.Text = "数据接收：";
            // 
            // tsslRece_Sum
            // 
            this.tsslRece_Sum.Name = "tsslRece_Sum";
            this.tsslRece_Sum.Size = new System.Drawing.Size(18, 20);
            this.tsslRece_Sum.Text = "0";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabel6.Text = "||";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(88, 20);
            this.toolStripStatusLabel2.Text = "接收状态：";
            // 
            // tsslSendMsgeStatus
            // 
            this.tsslSendMsgeStatus.Name = "tsslSendMsgeStatus";
            this.tsslSendMsgeStatus.Size = new System.Drawing.Size(54, 20);
            this.tsslSendMsgeStatus.Text = "未接收";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel4.Text = "发送状态：";
            // 
            // tsslSendMsgStatus
            // 
            this.tsslSendMsgStatus.Name = "tsslSendMsgStatus";
            this.tsslSendMsgStatus.Size = new System.Drawing.Size(54, 20);
            this.tsslSendMsgStatus.Text = "未发送";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabel5.Text = "||";
            // 
            // tsslRunStatus
            // 
            this.tsslRunStatus.Name = "tsslRunStatus";
            this.tsslRunStatus.Size = new System.Drawing.Size(99, 20);
            this.tsslRunStatus.Text = "软件运行正常";
            // 
            // lblTimeShow
            // 
            this.lblTimeShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeShow.Location = new System.Drawing.Point(1451, 811);
            this.lblTimeShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeShow.Name = "lblTimeShow";
            this.lblTimeShow.Size = new System.Drawing.Size(141, 28);
            this.lblTimeShow.TabIndex = 2;
            this.lblTimeShow.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDataSave);
            this.groupBox2.Controls.Add(this.btnDataShow);
            this.groupBox2.Controls.Add(this.btnSetParamaters);
            this.groupBox2.Controls.Add(this.btnShowCurve);
            this.groupBox2.Location = new System.Drawing.Point(3, 147);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(311, 246);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "常用操作";
            // 
            // btnDataSave
            // 
            this.btnDataSave.Enabled = false;
            this.btnDataSave.Location = new System.Drawing.Point(9, 25);
            this.btnDataSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDataSave.Name = "btnDataSave";
            this.btnDataSave.Size = new System.Drawing.Size(100, 29);
            this.btnDataSave.TabIndex = 1;
            this.btnDataSave.Text = "数据保存";
            this.btnDataSave.UseVisualStyleBackColor = true;
            this.btnDataSave.Click += new System.EventHandler(this.btnDataSave_Click);
            // 
            // btnDataShow
            // 
            this.btnDataShow.Location = new System.Drawing.Point(9, 137);
            this.btnDataShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDataShow.Name = "btnDataShow";
            this.btnDataShow.Size = new System.Drawing.Size(100, 29);
            this.btnDataShow.TabIndex = 2;
            this.btnDataShow.Text = "数据显示";
            this.btnDataShow.UseVisualStyleBackColor = true;
            this.btnDataShow.Click += new System.EventHandler(this.btnDataShow_Click);
            // 
            // btnSetParamaters
            // 
            this.btnSetParamaters.Enabled = false;
            this.btnSetParamaters.Location = new System.Drawing.Point(8, 77);
            this.btnSetParamaters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSetParamaters.Name = "btnSetParamaters";
            this.btnSetParamaters.Size = new System.Drawing.Size(100, 29);
            this.btnSetParamaters.TabIndex = 1;
            this.btnSetParamaters.Text = "设置参数";
            this.btnSetParamaters.UseVisualStyleBackColor = true;
            this.btnSetParamaters.Click += new System.EventHandler(this.btnSetParamaters_Click);
            // 
            // btnShowCurve
            // 
            this.btnShowCurve.Location = new System.Drawing.Point(8, 194);
            this.btnShowCurve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnShowCurve.Name = "btnShowCurve";
            this.btnShowCurve.Size = new System.Drawing.Size(100, 29);
            this.btnShowCurve.TabIndex = 0;
            this.btnShowCurve.Text = "曲线显示";
            this.btnShowCurve.UseVisualStyleBackColor = true;
            this.btnShowCurve.Click += new System.EventHandler(this.btnShowCurve_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(321, 27);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1271, 781);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblEngineVelocity);
            this.tabPage1.Controls.Add(this.lblHighPressure);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(1263, 752);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "液压混合动力系统";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(583, 508);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "压力：";
            // 
            // lblEngineVelocity
            // 
            this.lblEngineVelocity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEngineVelocity.AutoSize = true;
            this.lblEngineVelocity.BackColor = System.Drawing.Color.White;
            this.lblEngineVelocity.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEngineVelocity.Location = new System.Drawing.Point(23, 651);
            this.lblEngineVelocity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEngineVelocity.Name = "lblEngineVelocity";
            this.lblEngineVelocity.Size = new System.Drawing.Size(71, 18);
            this.lblEngineVelocity.TabIndex = 0;
            this.lblEngineVelocity.Text = "0 r/min";
            // 
            // lblHighPressure
            // 
            this.lblHighPressure.AutoSize = true;
            this.lblHighPressure.BackColor = System.Drawing.Color.White;
            this.lblHighPressure.Location = new System.Drawing.Point(400, 27);
            this.lblHighPressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHighPressure.Name = "lblHighPressure";
            this.lblHighPressure.Size = new System.Drawing.Size(52, 15);
            this.lblHighPressure.TabIndex = 3;
            this.lblHighPressure.Text = "压力：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Aqua;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(23, 621);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "发动机转速：";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblSlipPump, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lablel6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label13, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label14, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblCarVelocity, 1, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(920, 419);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(340, 332);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblSlipPump
            // 
            this.lblSlipPump.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSlipPump.AutoSize = true;
            this.lblSlipPump.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSlipPump.Location = new System.Drawing.Point(228, 14);
            this.lblSlipPump.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSlipPump.Name = "lblSlipPump";
            this.lblSlipPump.Size = new System.Drawing.Size(53, 18);
            this.lblSlipPump.TabIndex = 0;
            this.lblSlipPump.Text = "0 MPa";
            // 
            // lablel6
            // 
            this.lablel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lablel6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lablel6.Location = new System.Drawing.Point(52, 15);
            this.lablel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lablel6.Name = "lablel6";
            this.lablel6.Size = new System.Drawing.Size(65, 16);
            this.lablel6.TabIndex = 0;
            this.lablel6.Text = "补油泵压力";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(27, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "油门踏板信号";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(27, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "刹车踏板信号";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(233, 61);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "0 mm";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(233, 108);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "0 mm";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(13, 155);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "泵/马达出口压力";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(13, 202);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "泵/马达进口压力";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(228, 202);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "0 MPa";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(228, 155);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "0 MPa";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(63, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "车速";
            // 
            // lblCarVelocity
            // 
            this.lblCarVelocity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCarVelocity.AutoSize = true;
            this.lblCarVelocity.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCarVelocity.Location = new System.Drawing.Point(228, 249);
            this.lblCarVelocity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarVelocity.Name = "lblCarVelocity";
            this.lblCarVelocity.Size = new System.Drawing.Size(53, 18);
            this.lblCarVelocity.TabIndex = 0;
            this.lblCarVelocity.Text = "0 m/s";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1268, 787);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.cmbDrawChoose);
            this.tabPage2.Controls.Add(this.btnEndDraw);
            this.tabPage2.Controls.Add(this.btnStartDraw);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(1263, 752);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "曲线绘制";
            // 
            // cmbDrawChoose
            // 
            this.cmbDrawChoose.FormattingEnabled = true;
            this.cmbDrawChoose.Location = new System.Drawing.Point(1127, 29);
            this.cmbDrawChoose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbDrawChoose.Name = "cmbDrawChoose";
            this.cmbDrawChoose.Size = new System.Drawing.Size(99, 23);
            this.cmbDrawChoose.TabIndex = 3;
            this.cmbDrawChoose.SelectedIndexChanged += new System.EventHandler(this.cmbDrawChoose_SelectedIndexChanged);
            // 
            // btnEndDraw
            // 
            this.btnEndDraw.Enabled = false;
            this.btnEndDraw.Location = new System.Drawing.Point(1127, 230);
            this.btnEndDraw.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEndDraw.Name = "btnEndDraw";
            this.btnEndDraw.Size = new System.Drawing.Size(100, 29);
            this.btnEndDraw.TabIndex = 2;
            this.btnEndDraw.Text = "结束绘制";
            this.btnEndDraw.UseVisualStyleBackColor = true;
            this.btnEndDraw.Click += new System.EventHandler(this.btnEndDraw_Click);
            // 
            // btnStartDraw
            // 
            this.btnStartDraw.Location = new System.Drawing.Point(1127, 128);
            this.btnStartDraw.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStartDraw.Name = "btnStartDraw";
            this.btnStartDraw.Size = new System.Drawing.Size(100, 29);
            this.btnStartDraw.TabIndex = 1;
            this.btnStartDraw.Text = "开始绘制";
            this.btnStartDraw.UseVisualStyleBackColor = true;
            this.btnStartDraw.Click += new System.EventHandler(this.btnStartDraw_Click);
            // 
            // chart1
            // 
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(24, 25);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1064, 509);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.listView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1263, 752);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "数据显示";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Location = new System.Drawing.Point(51, 25);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(775, 184);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 56;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Width = 324;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(3, 399);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(311, 408);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参数设置";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnSlipPumpReleaseSign, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnReleaseSign, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRecycleSign, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPumpMotorReleaseSign, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnPumpCtrSign, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnMotorCtrSign, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.button8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 370);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnSlipPumpReleaseSign
            // 
            this.btnSlipPumpReleaseSign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSlipPumpReleaseSign.Location = new System.Drawing.Point(6, 85);
            this.btnSlipPumpReleaseSign.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSlipPumpReleaseSign.Name = "btnSlipPumpReleaseSign";
            this.btnSlipPumpReleaseSign.Size = new System.Drawing.Size(135, 32);
            this.btnSlipPumpReleaseSign.TabIndex = 4;
            this.btnSlipPumpReleaseSign.Text = "补油泵卸压信号";
            this.btnSlipPumpReleaseSign.UseVisualStyleBackColor = true;
            // 
            // btnReleaseSign
            // 
            this.btnReleaseSign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReleaseSign.Location = new System.Drawing.Point(6, 45);
            this.btnReleaseSign.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReleaseSign.Name = "btnReleaseSign";
            this.btnReleaseSign.Size = new System.Drawing.Size(135, 32);
            this.btnReleaseSign.TabIndex = 3;
            this.btnReleaseSign.Text = "释放能量信号";
            this.btnReleaseSign.UseVisualStyleBackColor = true;
            // 
            // btnRecycleSign
            // 
            this.btnRecycleSign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecycleSign.Location = new System.Drawing.Point(6, 5);
            this.btnRecycleSign.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRecycleSign.Name = "btnRecycleSign";
            this.btnRecycleSign.Size = new System.Drawing.Size(135, 32);
            this.btnRecycleSign.TabIndex = 2;
            this.btnRecycleSign.Text = "回收能量信号";
            this.btnRecycleSign.UseVisualStyleBackColor = true;
            // 
            // btnPumpMotorReleaseSign
            // 
            this.btnPumpMotorReleaseSign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPumpMotorReleaseSign.Location = new System.Drawing.Point(6, 125);
            this.btnPumpMotorReleaseSign.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPumpMotorReleaseSign.Name = "btnPumpMotorReleaseSign";
            this.btnPumpMotorReleaseSign.Size = new System.Drawing.Size(135, 32);
            this.btnPumpMotorReleaseSign.TabIndex = 5;
            this.btnPumpMotorReleaseSign.Text = "泵马达卸压信号";
            this.btnPumpMotorReleaseSign.UseVisualStyleBackColor = true;
            // 
            // btnPumpCtrSign
            // 
            this.btnPumpCtrSign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPumpCtrSign.Location = new System.Drawing.Point(6, 165);
            this.btnPumpCtrSign.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPumpCtrSign.Name = "btnPumpCtrSign";
            this.btnPumpCtrSign.Size = new System.Drawing.Size(135, 32);
            this.btnPumpCtrSign.TabIndex = 6;
            this.btnPumpCtrSign.Text = "泵控制信号";
            this.btnPumpCtrSign.UseVisualStyleBackColor = true;
            // 
            // btnMotorCtrSign
            // 
            this.btnMotorCtrSign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMotorCtrSign.Location = new System.Drawing.Point(6, 205);
            this.btnMotorCtrSign.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMotorCtrSign.Name = "btnMotorCtrSign";
            this.btnMotorCtrSign.Size = new System.Drawing.Size(135, 32);
            this.btnMotorCtrSign.TabIndex = 7;
            this.btnMotorCtrSign.Text = "马达控制信号";
            this.btnMotorCtrSign.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(6, 245);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 32);
            this.button7.TabIndex = 8;
            this.button7.Text = "预留";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(6, 285);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 32);
            this.button8.TabIndex = 9;
            this.button8.Text = "预留";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbRecycleSign_on);
            this.panel1.Controls.Add(this.rdbRecycleSign_Off);
            this.panel1.Location = new System.Drawing.Point(151, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 31);
            this.panel1.TabIndex = 12;
            // 
            // rdbRecycleSign_on
            // 
            this.rdbRecycleSign_on.AutoSize = true;
            this.rdbRecycleSign_on.Location = new System.Drawing.Point(4, 3);
            this.rdbRecycleSign_on.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbRecycleSign_on.Name = "rdbRecycleSign_on";
            this.rdbRecycleSign_on.Size = new System.Drawing.Size(44, 19);
            this.rdbRecycleSign_on.TabIndex = 11;
            this.rdbRecycleSign_on.TabStop = true;
            this.rdbRecycleSign_on.Text = "on";
            this.rdbRecycleSign_on.UseVisualStyleBackColor = true;
            // 
            // rdbRecycleSign_Off
            // 
            this.rdbRecycleSign_Off.AutoSize = true;
            this.rdbRecycleSign_Off.Location = new System.Drawing.Point(81, 3);
            this.rdbRecycleSign_Off.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbRecycleSign_Off.Name = "rdbRecycleSign_Off";
            this.rdbRecycleSign_Off.Size = new System.Drawing.Size(52, 19);
            this.rdbRecycleSign_Off.TabIndex = 10;
            this.rdbRecycleSign_Off.TabStop = true;
            this.rdbRecycleSign_Off.Text = "off";
            this.rdbRecycleSign_Off.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbReleaseSign_on);
            this.panel2.Controls.Add(this.rdbReleaseSign_off);
            this.panel2.Location = new System.Drawing.Point(151, 45);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 31);
            this.panel2.TabIndex = 12;
            // 
            // rdbReleaseSign_on
            // 
            this.rdbReleaseSign_on.AutoSize = true;
            this.rdbReleaseSign_on.Location = new System.Drawing.Point(4, 3);
            this.rdbReleaseSign_on.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbReleaseSign_on.Name = "rdbReleaseSign_on";
            this.rdbReleaseSign_on.Size = new System.Drawing.Size(44, 19);
            this.rdbReleaseSign_on.TabIndex = 11;
            this.rdbReleaseSign_on.TabStop = true;
            this.rdbReleaseSign_on.Text = "on";
            this.rdbReleaseSign_on.UseVisualStyleBackColor = true;
            // 
            // rdbReleaseSign_off
            // 
            this.rdbReleaseSign_off.AutoSize = true;
            this.rdbReleaseSign_off.Location = new System.Drawing.Point(81, 3);
            this.rdbReleaseSign_off.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbReleaseSign_off.Name = "rdbReleaseSign_off";
            this.rdbReleaseSign_off.Size = new System.Drawing.Size(52, 19);
            this.rdbReleaseSign_off.TabIndex = 10;
            this.rdbReleaseSign_off.TabStop = true;
            this.rdbReleaseSign_off.Text = "off";
            this.rdbReleaseSign_off.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdbSlipPumpReleaseSign_on);
            this.panel3.Controls.Add(this.rdbSlipPumpReleaseSign_off);
            this.panel3.Location = new System.Drawing.Point(151, 85);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 31);
            this.panel3.TabIndex = 12;
            // 
            // rdbSlipPumpReleaseSign_on
            // 
            this.rdbSlipPumpReleaseSign_on.AutoSize = true;
            this.rdbSlipPumpReleaseSign_on.Location = new System.Drawing.Point(4, 3);
            this.rdbSlipPumpReleaseSign_on.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbSlipPumpReleaseSign_on.Name = "rdbSlipPumpReleaseSign_on";
            this.rdbSlipPumpReleaseSign_on.Size = new System.Drawing.Size(44, 19);
            this.rdbSlipPumpReleaseSign_on.TabIndex = 11;
            this.rdbSlipPumpReleaseSign_on.TabStop = true;
            this.rdbSlipPumpReleaseSign_on.Text = "on";
            this.rdbSlipPumpReleaseSign_on.UseVisualStyleBackColor = true;
            // 
            // rdbSlipPumpReleaseSign_off
            // 
            this.rdbSlipPumpReleaseSign_off.AutoSize = true;
            this.rdbSlipPumpReleaseSign_off.Location = new System.Drawing.Point(81, 3);
            this.rdbSlipPumpReleaseSign_off.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbSlipPumpReleaseSign_off.Name = "rdbSlipPumpReleaseSign_off";
            this.rdbSlipPumpReleaseSign_off.Size = new System.Drawing.Size(52, 19);
            this.rdbSlipPumpReleaseSign_off.TabIndex = 10;
            this.rdbSlipPumpReleaseSign_off.TabStop = true;
            this.rdbSlipPumpReleaseSign_off.Text = "off";
            this.rdbSlipPumpReleaseSign_off.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdbPumpMotorReleaseSign_on);
            this.panel4.Controls.Add(this.rdbPumpMotorReleaseSign_off);
            this.panel4.Location = new System.Drawing.Point(151, 125);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(135, 31);
            this.panel4.TabIndex = 12;
            // 
            // rdbPumpMotorReleaseSign_on
            // 
            this.rdbPumpMotorReleaseSign_on.AutoSize = true;
            this.rdbPumpMotorReleaseSign_on.Location = new System.Drawing.Point(4, 3);
            this.rdbPumpMotorReleaseSign_on.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbPumpMotorReleaseSign_on.Name = "rdbPumpMotorReleaseSign_on";
            this.rdbPumpMotorReleaseSign_on.Size = new System.Drawing.Size(44, 19);
            this.rdbPumpMotorReleaseSign_on.TabIndex = 11;
            this.rdbPumpMotorReleaseSign_on.TabStop = true;
            this.rdbPumpMotorReleaseSign_on.Text = "on";
            this.rdbPumpMotorReleaseSign_on.UseVisualStyleBackColor = true;
            // 
            // rdbPumpMotorReleaseSign_off
            // 
            this.rdbPumpMotorReleaseSign_off.AutoSize = true;
            this.rdbPumpMotorReleaseSign_off.Location = new System.Drawing.Point(81, 3);
            this.rdbPumpMotorReleaseSign_off.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbPumpMotorReleaseSign_off.Name = "rdbPumpMotorReleaseSign_off";
            this.rdbPumpMotorReleaseSign_off.Size = new System.Drawing.Size(52, 19);
            this.rdbPumpMotorReleaseSign_off.TabIndex = 10;
            this.rdbPumpMotorReleaseSign_off.TabStop = true;
            this.rdbPumpMotorReleaseSign_off.Text = "off";
            this.rdbPumpMotorReleaseSign_off.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.txtPumpCtrSign);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(151, 165);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(136, 32);
            this.panel5.TabIndex = 15;
            // 
            // txtPumpCtrSign
            // 
            this.txtPumpCtrSign.Location = new System.Drawing.Point(4, 3);
            this.txtPumpCtrSign.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPumpCtrSign.Name = "txtPumpCtrSign";
            this.txtPumpCtrSign.Size = new System.Drawing.Size(89, 25);
            this.txtPumpCtrSign.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "ml/r";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.txtMotorCtrSign);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(151, 205);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(136, 32);
            this.panel6.TabIndex = 15;
            // 
            // txtMotorCtrSign
            // 
            this.txtMotorCtrSign.Location = new System.Drawing.Point(4, 3);
            this.txtMotorCtrSign.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMotorCtrSign.Name = "txtMotorCtrSign";
            this.txtMotorCtrSign.Size = new System.Drawing.Size(89, 25);
            this.txtMotorCtrSign.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "ml/r";
            // 
            // timeDispalyMsg
            // 
            this.timeDispalyMsg.Enabled = true;
            this.timeDispalyMsg.Tick += new System.EventHandler(this.timeDispalyMsg_Tick);
            // 
            // TimeShow
            // 
            this.TimeShow.Enabled = true;
            this.TimeShow.Tick += new System.EventHandler(this.TimeShow_timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1592, 839);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTimeShow);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Control System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBaudrate;
        private System.Windows.Forms.ComboBox cmbHardWare;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslCANStatus;
        private System.Windows.Forms.Label lblTimeShow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDataShow;
        private System.Windows.Forms.Button btnSetParamaters;
        private System.Windows.Forms.Button btnShowCurve;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslSend_Sum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsslRece_Sum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsslSendMsgeStatus;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timeDispalyMsg;
        private System.Windows.Forms.Button btnDataSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lablel6;
        private System.Windows.Forms.Label lblEngineVelocity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSlipPump;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tsslSendMsgStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel tsslRunStatus;
        private System.Windows.Forms.Timer TimeShow;
        private System.Windows.Forms.ComboBox cmbDrawChoose;
        private System.Windows.Forms.Button btnEndDraw;
        private System.Windows.Forms.Button btnStartDraw;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnSlipPumpReleaseSign;
        private System.Windows.Forms.Button btnReleaseSign;
        private System.Windows.Forms.Button btnRecycleSign;
        private System.Windows.Forms.Button btnPumpMotorReleaseSign;
        private System.Windows.Forms.Button btnPumpCtrSign;
        private System.Windows.Forms.Button btnMotorCtrSign;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.RadioButton rdbRecycleSign_Off;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbRecycleSign_on;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbReleaseSign_on;
        private System.Windows.Forms.RadioButton rdbReleaseSign_off;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdbSlipPumpReleaseSign_on;
        private System.Windows.Forms.RadioButton rdbSlipPumpReleaseSign_off;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdbPumpMotorReleaseSign_on;
        private System.Windows.Forms.RadioButton rdbPumpMotorReleaseSign_off;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtPumpCtrSign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtMotorCtrSign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHighPressure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCarVelocity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

