﻿using Tyuiu.ZavyalovKA.Sprint1.Task0.V27.Lib;
namespace Tyuiu.ZavyalovKA.Sprint1.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(22, res);
        }
    }
}