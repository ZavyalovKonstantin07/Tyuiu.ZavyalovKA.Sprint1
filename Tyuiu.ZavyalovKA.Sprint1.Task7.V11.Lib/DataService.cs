using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ZavyalovKA.Sprint1.Task7.V11.Lib
{
    public class DataService : ISprint1Task7V11
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Pow(Math.Log(Math.Sin(x)), x) / Math.Log(1 + x * x) + (y - Math.Sqrt(Math.Abs(x)));
            return Math.Round(res, 3);
        }
    }
}
