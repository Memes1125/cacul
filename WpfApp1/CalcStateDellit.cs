namespace WpfApp1
{
    internal class CalcStateDellit : ICalcState
    {
        public double Calculate(double x, double y)
        {
            return x / y;
        }
    }
}