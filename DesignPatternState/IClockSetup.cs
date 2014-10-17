using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternState
{
    public interface IClockSetup
    {
        void PushKnob();
        void RotateRight();
        void RotateLeft();
        int GetSelectedDate();
    }
}
