using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ZavyalovKA.Sprint1.Task3.V7.Lib
{
    public class DataService
    {
        public double VerstsToKilometers(double versts)
        {
            double kilometers = versts * 1.0668;
            return Math.Round(kilometers, 3);
        }
    }
}