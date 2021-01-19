using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1
{
    class Calculator
    {
        public double X { get; set; }
        public double Y { get; set; }

        ICalcState calcState;

        public double Calculate()
        {
            return calcState?.Calculate(X, Y) ?? 0;
        }

        public void SetState(ICalcState calcState)
        {
            this.calcState = calcState;
        }

    }
}
