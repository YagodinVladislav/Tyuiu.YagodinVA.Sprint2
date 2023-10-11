using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YagodinVA.Sprint2.Task5.V13.Lib;
namespace Tyuiu.YagodinVA.Sprint2.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int g = 2005;
            int m = 5;
            int n = 27;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "2005-5-28";
            Assert.AreEqual(wait, res);
        }
    }
}
