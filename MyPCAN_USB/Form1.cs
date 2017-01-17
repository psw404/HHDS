using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using Peak.Can.Basic;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;


namespace MyPCAN_USB
{
    using TPCANHandle = System.Byte;

    public partial class Form1 : Form
    {

        #region 全局变量定义
        //硬件参数，波特率和句柄
        private TPCANHandle m_PcanHandle;//Saves the handle of a PCAN hardware
        private TPCANBaudrate m_Baudrate;//Saves the baudrate register for a connection

        //接收数据的集合定义
        private ArrayList M_LastMsgStatusList;//Stores the status of received messsages for its dispaly
        private List<byte[]> ReceivelistMsg;
        private List<byte[]> ReceiveListAnother;
        byte[] AllData = new byte[32];

       //接收线程和委托定义
        private delegate void ReadDelegateHandler();//Read-Delegate Handle
        private ReadDelegateHandler m_ReadDelegate;//Read Delegate for calling the function "ReadMessages"
        private Thread m_ReadThread;//Thread for message reading (using events)
        private Thread m_DataSaveThread;//数据库存数据线程
        private AutoResetEvent m_ReceiveEvent;//Receive-Event

        //接收和发送计数
        private ulong rece_sum = 0;
        private ulong send_sum = 0;

        //数据库操作类
        DataBaseOperation dboperation = new DataBaseOperation();

        //实时绘制曲线线程和委托定义
        Series mySeries;
        int index;//选择要绘制的曲线
        private  Thread addDataRunner;
        private delegate void AddDataDelegate();
        private AddDataDelegate addDataDel;
        #endregion

        #region 窗体初始化/关闭
        public Form1()
        {
            InitializeComponent();
            InitalizeBasicComponents();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定关闭软件？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr!=DialogResult.Yes)
            {
                e.Cancel = true ;
            }
            else
                PCANBasic.Uninitialize(m_PcanHandle);
        }
        #endregion

        #region CAN卡配置
        private void InitalizeBasicComponents()
        {
            ReceivelistMsg = new List<byte[]>(64);
            ReceiveListAnother = new List<byte[]>(64); 

            M_LastMsgStatusList = new ArrayList();
            m_ReadDelegate = new ReadDelegateHandler(ReadMessages);
            m_ReceiveEvent = new AutoResetEvent(false);

            #region 数组m_HandlesArray 存储PCAN现有设备
           /*m_HandlesArray = new TPCANHandle[] 
            { 
                PCANBasic.PCAN_ISABUS1,
                PCANBasic.PCAN_ISABUS2,
                PCANBasic.PCAN_ISABUS3,
                PCANBasic.PCAN_ISABUS4,
                PCANBasic.PCAN_ISABUS5,
                PCANBasic.PCAN_ISABUS6,
                PCANBasic.PCAN_ISABUS7,
                PCANBasic.PCAN_ISABUS8,
                PCANBasic.PCAN_DNGBUS1,
                PCANBasic.PCAN_PCIBUS1,
                PCANBasic.PCAN_PCIBUS2,
                PCANBasic.PCAN_PCIBUS3,
                PCANBasic.PCAN_PCIBUS4,
                PCANBasic.PCAN_PCIBUS5,
                PCANBasic.PCAN_PCIBUS6,
                PCANBasic.PCAN_PCIBUS7,
                PCANBasic.PCAN_PCIBUS8,
                PCANBasic.PCAN_USBBUS1,
                PCANBasic.PCAN_USBBUS2,
                PCANBasic.PCAN_USBBUS3,
                PCANBasic.PCAN_USBBUS4,
                PCANBasic.PCAN_USBBUS5,
                PCANBasic.PCAN_USBBUS6,
                PCANBasic.PCAN_USBBUS7,
                PCANBasic.PCAN_USBBUS8,
                PCANBasic.PCAN_PCCBUS1,
                PCANBasic.PCAN_PCCBUS2
            };
           */
            #endregion

            FillComboBoxData();

            ConfiguerLogFile();
        }

        public void FillComboBoxData()
        {
            //UInt32 iBuffer;
            //TPCANStatus stsResult;

            ////the detected Plug&Play hardware
            //cmbHardWare.Items.Clear();
            //try
            //{
            //    for (int i = 0; i < m_HandlesArray.Length; i++)
            //    { 
            //        stsResult =PCANBasic .GetValue (m_HandlesArray [i],TPCANParameter.PCAN_CHANNEL_CONDITION ,
            //                   out iBuffer ,sizeof (UInt32));
            //        if ((stsResult == TPCANStatus.PCAN_ERROR_OK) && (iBuffer == PCANBasic.PCAN_CHANNEL_AVAILABLE))
            //            cmbHardWare.Items.Add(FormatChannelName(m_HandlesArray[i]));
            //    }
            //    cmbHardWare.SelectedIndex = cmbHardWare.Items.Count - 1;
            //}
            //catch (DllNotFoundException )
            //{
            //    tsslRunStatus.Text=("Unable to find the library:PCANBasic.dll !","error!",
            //        MessageBoxButtons .OK ,MessageBoxIcon.Error  );
            //    Environment.Exit(-1);
            //} 
            //main form tabpage1
            cmbHardWare.Items.Add(FormatChannelName(PCANBasic.PCAN_USBBUS1));
            cmbHardWare.SelectedIndex = 0;
            cmbBaudrate.SelectedIndex = 2;//500K

            //tabpage2
            cmbDrawChoose.Items.Add("车速");
            cmbDrawChoose.Items.Add("蓄能器压力");
            cmbDrawChoose.SelectedIndex = 0;

        }

        public string FormatChannelName(TPCANHandle handle)
        {
            TPCANDevice m_device;
            byte byChannel;
            m_device = (TPCANDevice)(handle >> 4);//转换成16进制
            byChannel = (byte)(handle & 0xF);

            return string.Format("{0} {1}({2:X2}h)", m_device, byChannel, handle);
        }

        public void ConfiguerLogFile()
        {
            UInt32 iBuffer;
            iBuffer = PCANBasic.LOG_FUNCTION_ALL;
            PCANBasic.SetValue(PCANBasic.PCAN_NONEBUS, TPCANParameter.PCAN_LOG_CONFIGURE, ref iBuffer, sizeof(UInt32));

        }

        private void cmbBaudrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBaudrate.SelectedIndex)
            {
                case 0:
                    m_Baudrate = TPCANBaudrate.PCAN_BAUD_1M;
                    break;
                case 1:
                    m_Baudrate = TPCANBaudrate.PCAN_BAUD_800K;
                    break;
                case 2:
                    m_Baudrate = TPCANBaudrate.PCAN_BAUD_500K;
                    break;
                case 3:
                    m_Baudrate = TPCANBaudrate.PCAN_BAUD_250K;
                    break;
                case 4:
                    m_Baudrate = TPCANBaudrate.PCAN_BAUD_125K;
                    break;
                case 5:
                    m_Baudrate = TPCANBaudrate.PCAN_BAUD_100K;
                    break;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            m_PcanHandle = PCANBasic.PCAN_USBBUS1;
            TPCANStatus stsResult;
            //初始化CAN通道
            stsResult = PCANBasic.Initialize(m_PcanHandle, m_Baudrate);
            //如果初始化失败
            if (stsResult != TPCANStatus.PCAN_ERROR_OK)
                MessageBox.Show(GetFormatedError(stsResult));
            else
            {
                //如果初始化成功，则配置通道
                ConfiguerTraceFile();
            }
            //根据打开状态，设置控件状态
            bool IsOk = (stsResult == TPCANStatus.PCAN_ERROR_OK);
            SetControlStatus(IsOk);

            //启动接收线程
            ReadThreadStartOrEnd(IsOk);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            PCANBasic.Uninitialize(m_PcanHandle);
            ReadThreadStartOrEnd(false);
            this.btnDataSave_Click(sender ,e);
            SetControlStatus(false);
            ///添加其他操作
            ///、、、、、、、、、、、、、、
            ///、、、、、、、、、、、、、、
            ///、、、、、、、、、、、、、、
            ///、、、、、、、、、、、、、、
            ///、、、、、、、、、、、、、、
            ///、、、、、、、、、、、、、、
            ///、、、、、、、、、、、、、、
        }

        /// <summary>
        /// 根据CAN通道的打开状态，设置控件状态：可操作或不可操作
        /// </summary>
        /// <param name="IsConnected"></param>
        public void SetControlStatus(bool IsConnected)
        {
            btnOpen.Enabled = !IsConnected;
            btnClose.Enabled = IsConnected;

            cmbBaudrate.Enabled = !IsConnected;
            cmbHardWare.Enabled = !IsConnected;

            tsslCANStatus.Text = IsConnected ? "CAN卡打开" : "CAN卡未打开";

            btnDataSave.Enabled = IsConnected;
            btnSetParamaters.Enabled = IsConnected;
            //groupBox2.Enabled = IsConnected ;
            ///、、、、添加其他控件的状态
            ///、、、、、、、、、、、、
            ///、、、、、、、、、、、、、、
            ///、、、、、、、、、、、、、、
            ///、、、、、、、、、、、、、、、、、、
            ///、、、、、、、、、、、、、、、、、、、、、、、、、
        }

        /// <summary>
        /// 如果初始化成功，则配置通道
        /// </summary>
        public void ConfiguerTraceFile()
        {
            UInt32 iBuffer;
            TPCANStatus stsResult;
            //Configure the maximum size of a trace file to 5 megabytes
            //
            iBuffer = 5;
            stsResult = PCANBasic.SetValue(m_PcanHandle, TPCANParameter.PCAN_TRACE_SIZE,
                       ref iBuffer, sizeof(UInt32));
            if (stsResult != TPCANStatus.PCAN_ERROR_OK)
                tsslCANStatus.Text = GetFormatedError(stsResult);

            // Configure the way how trace files are created: 
            // * Standard name is used
            // * Existing file is ovewritten, 
            // * Only one file is created.
            // * Recording stopts when the file size reaches 5 megabytes.
            //
            iBuffer = PCANBasic.TRACE_FILE_SINGLE | PCANBasic.TRACE_FILE_OVERWRITE;
            stsResult = PCANBasic.SetValue(m_PcanHandle, TPCANParameter.PCAN_TRACE_CONFIGURE, ref iBuffer, sizeof(UInt32));
            if (stsResult != TPCANStatus.PCAN_ERROR_OK)
                tsslCANStatus.Text = GetFormatedError(stsResult);

        }

        /// <summary>
        /// 获取错误详细信息
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        public string GetFormatedError(TPCANStatus error)
        {
            StringBuilder strTemp = new StringBuilder(256);
            if (PCANBasic.GetErrorText(error, 0, strTemp) != TPCANStatus.PCAN_ERROR_OK)
                return string.Format("An error occurred. Error-code's text({0:X}) couldn't be retrieved", error);
            else
                return strTemp.ToString();
        }

        #endregion

        #region CAN接收线程定义
        /// <summary>
        /// 启动接收线程
        /// </summary>
        /// <param name="IsOk"></param>
        public void ReadThreadStartOrEnd(bool IsOk)
        {
            if (IsOk)
            {
                m_ReadThread = new Thread(new ThreadStart(this.CANReadThreadFunc));
                m_ReadThread.IsBackground = true;
                m_ReadThread.Name = "Readthread";
                m_ReadThread.Start();
            }
            else
            {
                if (m_ReadThread != null)
                {
                    m_ReadThread.Abort();
                    m_ReadThread.Join();
                    m_ReadThread = null;
                }
            }
        }

        /// <summary>
        /// Thread-Function used for reading PCAN-Basic messages
        /// </summary>
        public void CANReadThreadFunc()
        {
            UInt32 iBuffer;
            TPCANStatus stsResult;

            iBuffer = Convert.ToUInt32(m_ReceiveEvent.SafeWaitHandle.DangerousGetHandle().ToInt32());
            stsResult = PCANBasic.SetValue(m_PcanHandle, TPCANParameter.PCAN_RECEIVE_EVENT, ref iBuffer, sizeof(UInt32));

            if (stsResult != TPCANStatus.PCAN_ERROR_OK)
            {
                MessageBox.Show(GetFormatedError(stsResult), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (true)
            {
                //waiting for Receive-Event
                //
                if (m_ReceiveEvent.WaitOne(50))
                    this.Invoke(m_ReadDelegate);
                   // ReadMessages();
                // m_ReadDelegate = new ReadDelegateHandler(ReadMessages);
                //
            }
        }

        /// <summary>
        /// Function for reading PCAN-Basic message
        /// </summary>
        public void ReadMessages()
        {
            TPCANMsg CANMsg;
            TPCANTimestamp CANTimeStamp;
            TPCANStatus stsResult;
            // We read at least one time the queue looking for messages.
            // If a message is found, we look again trying to find more.
            // If the queue is empty or an error occurr, we get out from
            // the dowhile statement.
            //		
            do
            {
                stsResult = PCANBasic.Read(m_PcanHandle, out CANMsg, out CANTimeStamp);
                if (stsResult == TPCANStatus.PCAN_ERROR_OK)
                {
                    MyProcessMessage(CANMsg);
                }
                //else tsslMessageStatus.Text = GetFormatedError(stsResult);

            } while (btnClose.Enabled && (!Convert.ToBoolean(stsResult & TPCANStatus.PCAN_ERROR_QRCVEMPTY)));
        }

        /// <summary>
        /// 收到消息后处理消息
        /// </summary>
        /// <param name="CANMsg"></param>
        /// <param name="CANTimeStamp"></param>
        int[] a = new int[4] { 0, 0, 0, 0 };
        public void MyProcessMessage(TPCANMsg CANMsg)
        {

            //byte[] data = new byte[10];
            if (CANMsg.ID != 388 && CANMsg.ID != 644 && CANMsg.ID != 900 && CANMsg.ID != 1156)
            {
                return;
            }
            if (CANMsg.ID == 388)
            {
                rece_sum++;
                a[0] = 1;
                for (int i = 0; i < 8; i++)
                    AllData[i] = CANMsg.DATA[i];
            }
            else if (CANMsg.ID == 644)
            {
                rece_sum++;
                a[1] = 1;
                for (int i = 8; i < 16; i++)
                    AllData[i] = CANMsg.DATA[i % 8];
            }
            else if (CANMsg.ID == 900)
            {
                rece_sum++;
                a[2] = 1;
                for (int i = 16; i < 24; i++)
                    AllData[i] = CANMsg.DATA[i % 8];
            }
            else if (CANMsg.ID == 1156)
            {
                rece_sum++;
                a[3] = 1;
                for (int i = 24; i < 32; i++)
                    AllData[i] = CANMsg.DATA[i % 8];
            }
            if ((a[0] == 1) && (a[1] == 1) && (a[2] == 1) && (a[3] == 1))
            {
                ReceivelistMsg.Add(AllData);
                a[0] = a[1] = a[2] = a[3] = 0;
            }

            if (ReceivelistMsg.Count == 64)
            {
                lock (ReceiveListAnother)
               {
                    ReceivelistMsg.ForEach(i => ReceiveListAnother.Add(i));
                }
                ReceivelistMsg.Clear();
            }
            

            //lock (M_LastMsgStatusList.SyncRoot)
            //{
            //    foreach (MessageStatus msg in M_LastMsgStatusList)
            //    {
            //        if ((msg.CANMsg.ID == CANMsg.ID) && (msg.CANMsg.MSGTYPE == CANMsg.MSGTYPE))
            //        {
            //            msg.Update(CANMsg, CANTimeStamp);
            //            return;
            //        }
            //    }
            //    //InsertMsgEntry(CANMsg, CANTimeStamp);
            //}

        }

        #endregion

        #region 显示实时数据

        /// <summary>
        /// 显示数据在主界面上 
        /// </summary>
        public void DisplayMsg()
        {
            //状态栏数据显示
            tsslRece_Sum.Text = rece_sum.ToString();
            tsslSend_Sum.Text = send_sum.ToString();
            tsslSendMsgeStatus.Text = (m_ReadThread == null ? "接收线程停止" : "正在接收数据");

            //主要设备状态显示
            lblCarVelocity.Text = AllData[0].ToString();
            lblEngineVelocity.Text = AllData[1].ToString();
        }
        /// <summary>
        /// 定时器定时显示数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeDispalyMsg_Tick(object sender, EventArgs e)
        {
            DisplayMsg();
        }
        #endregion

        #region 绘制实时曲线
        private void btnStartDraw_Click(object sender, EventArgs e)
        {
            btnStartDraw.Enabled = false;
            btnEndDraw.Enabled = true;

            addDataRunner = new Thread(new ThreadStart(AddDataThreadLoop));
            addDataRunner.IsBackground = true;
            addDataDel = new AddDataDelegate(AddData);

            DateTime timeValue = DateTime.Now;
            DateTime minValue = timeValue.ToLocalTime();
            DateTime maxValue = timeValue.AddSeconds(30).ToLocalTime();

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            chart1.ChartAreas[0].AxisX.Title = "时间";
            chart1.ChartAreas[0].AxisY.Title = cmbDrawChoose.SelectedItem.ToString ();
            chart1.ChartAreas[0].AxisX.Minimum = minValue.ToOADate();
            chart1.ChartAreas[0].AxisX.Maximum = maxValue.ToOADate();

            chart1.Series.Clear();
            mySeries = new Series();

            mySeries.ChartType = SeriesChartType.Spline;
            mySeries.BorderWidth = 1;
            mySeries.Color = Color.FromArgb(224, 64, 10);
            mySeries.IsValueShownAsLabel = true;
            mySeries.XValueType = ChartValueType.DateTime;
            chart1.Series.Add(mySeries);

            addDataRunner.Start();

        }
        private void AddDataThreadLoop()
        {
            try
            {
                while (true)
                {
                    chart1.Invoke(addDataDel);
                    Thread.Sleep(500);
                }
            }
            catch (Exception)
            { }
        }
        void AddData()
        {
            DateTime timestamp = DateTime.Now;

            mySeries.Points.AddXY(timestamp.ToLocalTime(), AllData[index].ToString ());
            double removeBefore = timestamp.AddSeconds((double)(20) * (-1)).ToOADate();
            while (mySeries.Points[0].XValue < removeBefore)
            {
                mySeries.Points.RemoveAt(0);
            }
            chart1.ChartAreas[0].AxisX.Minimum = mySeries.Points[0].XValue;
            chart1.ChartAreas[0].AxisX.Maximum = DateTime.FromOADate(mySeries.Points[0].XValue).AddSeconds(30).ToOADate();
            chart1.Invalidate();
        }

        private void btnEndDraw_Click(object sender, EventArgs e)
        {

            if (addDataRunner != null)
            {
                addDataRunner.Abort();
                addDataRunner.Join();
                addDataRunner = null;
            }
            btnStartDraw.Enabled = true;
            btnEndDraw.Enabled = false;
        }


        private void cmbDrawChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbDrawChoose.SelectedIndex)
            {
                case 0:
                    index = 0;
                    break;
                case 1:
                    index = 1;
                    break;
                case 2:
                    index = 2;
                    break;
            }
        }
        #endregion
        
        #region 保存数据到数据库/文件中

        /// <summary>
        /// 启动数据写入数据库线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDataSave_Click(object sender, EventArgs e)
        {
            if (m_DataSaveThread != null)
            {
                m_DataSaveThread.Abort();
                m_DataSaveThread.Join();
                m_DataSaveThread = null;

            }
            else
            {
                m_DataSaveThread = new Thread(new ThreadStart(operateDataBase));
                m_DataSaveThread.IsBackground = true;
                m_DataSaveThread.Name = "DATASAVEthread";
                m_DataSaveThread.Start();
            }
        }

        /// <summary>
        /// 保存到文件中
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public void dataSaveToFile(string data)
        {
            try
            {
                StreamWriter switer = File.AppendText("F:\\send_data.txt");
                switer.WriteLine(data);
                switer.Flush();
                switer.Close();

            }
            catch 
            {
                tsslRunStatus.Text="savetofile is a error";
                //return false;
            }
        }

        /// <summary>
        /// 数据库操作
        /// </summary>
        /// <returns></returns>
        public void operateDataBase()
        {
            dboperation = new DataBaseOperation();
            ReceiveListAnother.Clear();

            while (true)
            {
                if (ReceiveListAnother.Count == 64)
                {

                    lock (ReceiveListAnother)
                    {
                        dboperation.getcomPara(ReceiveListAnother);
                        ReceiveListAnother.Clear();
                    }

                }
            }
        }
       

        #endregion

        #region 数据库中数据读取并以图表/曲线显示

        /// <summary>
        /// 转到数据显示界面，并显示数据。从数据库中读取数据，并以图表显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDataShow_Click(object sender, EventArgs e)
        {

            tabControl1.SelectTab(tabPage3);
            /*
             * 
             * 
             * 
             * 
             * 显示数据
             * 
             * 
             * 
             */
        }


        /// <summary>
        /// 转到曲线显示界面，并显示曲线.从数据库中读取数据，并以曲线显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowCurve_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
            /*
             * 
             *显示曲线 
             * 
             * 
             *
             */
        }

        #endregion

        #region 发送操作定义

        private void btnSetParamaters_Click(object sender, EventArgs e)
        {
            TPCANMsg CANMsg;
            TPCANStatus stsResult;

            //创建一帧信息
            CANMsg = new TPCANMsg();
            CANMsg.ID = Convert.ToUInt32("383", 16);
            CANMsg.LEN = Convert.ToByte(8);
            CANMsg.MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
            CANMsg.DATA = new byte[8];

            try
            {
                if (rdbRecycleSign_Off.Checked)
                    CANMsg.DATA[0] = 0;
                CANMsg.DATA[0] = 1;
                CANMsg.DATA[1] = 2;
                CANMsg.DATA[2] = Convert.ToByte("10", 16);
                CANMsg.DATA[3] = Convert.ToByte("10", 16);
                CANMsg.DATA[4] = Convert.ToByte("10", 16);
                CANMsg.DATA[5] = Convert.ToByte("10", 16);
                CANMsg.DATA[6] = Convert.ToByte("10", 16);
                CANMsg.DATA[7] = Convert.ToByte("10", 16);
            }
            catch (Exception ex)
            {
                tsslRunStatus.Text=ex.ToString (); ;
            }
            
            //发送
            stsResult = PCANBasic.Write(m_PcanHandle, ref CANMsg);
            if (stsResult == TPCANStatus.PCAN_ERROR_OK)
            {
                tsslSendMsgStatus.Text = "发送成功";
                send_sum++;
            }
            else
                tsslSendMsgStatus.Text = GetFormatedError(stsResult);
        }

        #endregion

        #region 其他事务，如时间显示
        private void TimeShow_timer_Tick(object sender, EventArgs e)
        {
            lblTimeShow.Text = DateTime.Now.ToString("g");
        }

        #endregion

        

    }
}
