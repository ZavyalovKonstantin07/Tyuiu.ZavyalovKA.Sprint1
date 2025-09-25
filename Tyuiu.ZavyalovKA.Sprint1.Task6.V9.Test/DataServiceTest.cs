using Tyuiu.ZavyalovKA.Sprint1.Task6.V9.Lib;
namespace Tyuiu.ZavyalovKA.Sprint1.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string value = "Hello";
            string wait = "oHell";
            string res = ds.MoveLetterToStart(value);
            Assert.AreEqual(wait, res);
        }
    }
}
