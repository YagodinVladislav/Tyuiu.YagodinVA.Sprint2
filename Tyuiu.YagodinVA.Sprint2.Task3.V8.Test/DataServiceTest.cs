using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YagodinVA.Sprint2.Task3.V8.Lib;
namespace Tyuiu.YagodinVA.Sprint2.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 90;
            double res = ds.Calculate(x);
            double wait = -0.332;
            Assert.AreEqual(wait, res);
        }
    }
}
