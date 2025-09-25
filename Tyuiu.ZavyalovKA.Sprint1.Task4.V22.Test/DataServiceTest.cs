using Tyuiu.ZavyalovKA.Sprint1.Task4.V22.Lib;
namespace Tyuiu.ZavyalovKA.Sprint1.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 1;
            double wait = 0.054;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res); 
        }
    }
}