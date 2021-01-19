namespace WpfApp1
{
    internal class CalcStateMinus : ICalcState
    {
        public double Calculate(double x, double y)
        {
            return x - y;
        }
    }
}