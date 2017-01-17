using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peak.Can.Basic ;

namespace MyPCAN_USB
{
    /// <summary>
    /// Message Status class is used to show CAN Messages 
    /// </summary>
    public class MessageStatus
    {
        private TPCANMsg myMsg;
        private TPCANTimestamp myTimeStamp;
        private TPCANTimestamp myOldTimeStamp;
        private int myListIndex;
        private int myCount;
        private bool mybShowPeriod;
        private bool mybWasChanged;

        public MessageStatus(TPCANMsg canMsg, TPCANTimestamp canTimerstamp, int listIndex)
        {
            this.myMsg = canMsg;
            this.myTimeStamp = canTimerstamp;
            this.myListIndex = listIndex;
            this.myCount = 1;
            this.mybShowPeriod = true;
            this.mybWasChanged = false;
        }

        public void Update(TPCANMsg canMsg, TPCANTimestamp canTimerstamp)
        {
            this.myMsg = canMsg;
            this.myOldTimeStamp = myTimeStamp;
            this.myTimeStamp = canTimerstamp;
            this.mybWasChanged = true;
            this.myCount += 1;
        }
        public TPCANMsg CANMsg
        {
            get { return myMsg; }
        }
        public TPCANTimestamp Timestamp
        {
            get { return myTimeStamp; }
        }
        public int Position
        {
            get { return myListIndex; }
        }
        public string TypeString
        {
            get { return GetMsgTypeString(); }
        }
        public string IdString
        {
            get { return GetIdString(); }
        }

        public string DataString
        {
            get { return GetDataString(); }
        }

        public int Count
        {
            get { return myCount; }
        }

        public bool ShowingPeriod
        {
            get { return mybShowPeriod; }
            set
            {
                if (mybShowPeriod ^ value)
                {
                    mybShowPeriod = value;
                    mybWasChanged = true;
                }
            }
        }

        public bool MarkedAsUpdated
        {
            get { return mybWasChanged; }
            set { mybWasChanged = value; }
        }

        public string TimeString
        {
            get { return GetTimeString(); }
        }

        private string GetTimeString()
        {
            double fTime;

            fTime = myTimeStamp.millis + (myTimeStamp.micros / 1000.0);
            if (mybShowPeriod)
                fTime -= (myOldTimeStamp.millis + (myOldTimeStamp.micros / 1000.0));
            return fTime.ToString("F1");
        }

        private string GetDataString()
        {
            string strTemp;

            strTemp = "";

            if ((myMsg.MSGTYPE & TPCANMessageType.PCAN_MESSAGE_RTR) == TPCANMessageType.PCAN_MESSAGE_RTR)
                return "Remote Request";
            else
                for (int i = 0; i < myMsg.LEN; i++)
                    strTemp += string.Format("{0:X2} ", myMsg.DATA[i]);

            return strTemp;
        }

        private string GetIdString()
        {
            // We format the ID of the message and show it
            //
            if ((myMsg.MSGTYPE & TPCANMessageType.PCAN_MESSAGE_EXTENDED) == TPCANMessageType.PCAN_MESSAGE_EXTENDED)
                return string.Format("{0:X8}h", myMsg.ID);
            else
                return string.Format("{0:X3}h", myMsg.ID);
        }

        private string GetMsgTypeString()
        {
            string strTemp;

            if ((myMsg.MSGTYPE & TPCANMessageType.PCAN_MESSAGE_EXTENDED) == TPCANMessageType.PCAN_MESSAGE_EXTENDED)
                strTemp = "EXTENDED";
            else
                strTemp = "STANDARD";

            if ((myMsg.MSGTYPE & TPCANMessageType.PCAN_MESSAGE_RTR) == TPCANMessageType.PCAN_MESSAGE_RTR)
                strTemp += "/RTR";

            return strTemp;
        }

    }

}

