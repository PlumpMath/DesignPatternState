using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternState
{
    public class ClockSetup : IClockSetup
    {
        public void PushKnob()
        {
            throw new NotImplementedException();
        }

        public void RotateRight()
        {
            throw new NotImplementedException();
        }

        public void RotateLeft()
        {
            throw new NotImplementedException();
        }

        public int GetSelectedDate()
        {
            throw new NotImplementedException();
        }

        public void YearState()
        {
        }

        public void MonthState()
        {
        }

        public void DayState()
        {            
        }
    }
}
