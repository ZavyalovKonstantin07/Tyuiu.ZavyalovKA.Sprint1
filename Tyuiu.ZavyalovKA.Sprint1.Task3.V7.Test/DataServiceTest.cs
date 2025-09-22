using Tyuiu.ZavyalovKA.Sprint1.Task3.V7.Lib;
namespace Tyuiu.ZavyalovKA.Sprint1.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double versts = 100.0; 
            double kilometers = ds.VerstsToKilometers(versts);
            Assert.AreEqual(106.68, kilometers, 0.001);
        }
    }
}
