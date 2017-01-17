using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peak.Can.Basic;

namespace MyPCAN_USB
{
    using myType = System.String;
    class MessageRece
    {
        #region 属性定义
        TPCANMsg receMsg;

        private myType accuHighPre; //高压蓄能器压力
        private myType accuLowPre; //低压蓄能器压力
        private myType slipPumpPre;//补油泵压力
        private myType acceSign; //加速信号(油门踏板信号)
        private myType brakeSign; //刹车信号(刹车踏板信号)
        private myType carSpeed; //车速
        private myType engineSpeed;//发动机转速
        private myType pump_notorOutPre;//泵/马达出口压力
        private myType pump_motorInPre;//泵/马达进口压力
        #endregion
        

        
    }
}
