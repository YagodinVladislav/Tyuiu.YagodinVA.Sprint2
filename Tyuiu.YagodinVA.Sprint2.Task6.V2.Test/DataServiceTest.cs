using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YagodinVA.Sprint2.Task6.V2.Lib;
namespace Tyuiu.YagodinVA.Sprint2.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthSeason()
        {
            DataService ds = new DataService();
            int value = 1;
            string res = ds.FindMonthSeason(value);
            string wait = "Зима";
            Assert.AreEqual(wait, res);
        }
    }
}
