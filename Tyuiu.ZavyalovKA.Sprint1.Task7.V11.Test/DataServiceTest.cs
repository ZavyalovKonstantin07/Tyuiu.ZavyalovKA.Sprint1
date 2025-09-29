using Tyuiu.ZavyalovKA.Sprint1.Task7.V11.Lib;
namespace Tyuiu.ZavyalovKA.Sprint1.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 0.751;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
