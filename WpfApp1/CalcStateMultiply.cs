namespace WpfApp1
{
    internal class CalcStateMultiply : ICalcState
    {
        public double Calculate(double x, double y)
        {
            return x * y;
        }
    }
}