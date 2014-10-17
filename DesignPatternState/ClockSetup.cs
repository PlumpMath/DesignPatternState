using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternState
{
    public class ClockSetup : IClockSetup
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public void PushKnob()
        {
            // Ska inte var == 1. Skrev så bara för att slippa error. Troligtvis helt fel tänk.
            if (Year == 1)
                Month++; 
        }

        public void RotateRight()
        {
            if (Year > 1)
                Year++;
        }

        public void RotateLeft()
        {
            if (Year < 1)
                Year--;
        }

        public int GetSelectedDate()
        {
            return Year;
        }

        public void YearState(ClockSetup setup, int year)
        {
        }

        public void MonthState(ClockSetup setup, int month)
        {
        }

        public void DayState(ClockSetup setup, int day)
        {
        }
    }
}
