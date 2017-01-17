using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peak.Can.Basic;

namespace MyPCAN_USB
{
    class MessageSend
    {

        #region 属性定义
        private TPCANMsg sendMsg;

        private byte recycleSign;             //回收能量信号(开关量)
        private byte releaseSign;             //释放能量信号(开关量)
        private byte slipPumpReleaseSign;     //补油泵卸压信号（开关量）
        private byte pump_motorReleaseSign;   // 泵马达卸压信号（开关量）
        private byte pumpCtrSign;             //泵控制信号（模拟量）
        private byte motorCtrSign;            //马达控制信号（模拟量）
        #endregion

        #region 属性操作
        public byte RecycleSign
        {
            get
            {
                return recycleSign;
            }

            set
            {
                recycleSign = value;
            }
        }

        public byte ReleaseSign
        {
            get
            {
                return releaseSign;
            }

            set
            {
                releaseSign = value;
            }
        }

        public byte SlipPumpReleaseSign
        {
            get
            {
                return slipPumpReleaseSign;
            }

            set
            {
                slipPumpReleaseSign = value;
            }
        }

        public byte Pump_motorReleaseSign
        {
            get
            {
                return pump_motorReleaseSign;
            }

            set
            {
                pump_motorReleaseSign = value;
            }
        }

        public byte PumpCtrSign
        {
            get
            {
                return pumpCtrSign;
            }

            set
            {
                pumpCtrSign = value;
            }
        }

        public byte MotorCtrSign
        {
            get
            {
                return motorCtrSign;
            }

            set
            {
                motorCtrSign = value;
            }
        }
        #endregion

        public MessageSend(UInt32 ID)
        {
            IntialSendMsg(ID);
        }
     
        public void IntialSendMsg(UInt32 ID)
        {
            sendMsg = new TPCANMsg();
            sendMsg.MSGTYPE = TPCANMessageType.PCAN_MESSAGE_STANDARD;
            sendMsg.ID = ID;
            sendMsg.LEN = Convert.ToByte(8);
            sendMsg.DATA = new byte[8];
        }
        public void recycleSignSend()
        {
            sendMsg.DATA[0] = recycleSign;
            
        }


    }
}
