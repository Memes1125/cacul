using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1
{
    public class CalcStatePlus : ICalcState
    {
        public double Calculate(double x, double y)
        {
            return x + y;
        }
    }
}
