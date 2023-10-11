using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YagodinVA.Sprint2.V26.Lib
{
    public class DataService : ISprint2Task2V15
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            string text = $"{x}{y}";
            string[] array = new string[] {"33", "34", "35", "39", "310", "311", "312",
            "43", "44", "45", "49", "410", "411", "412", "52", "53", "54", "55", "56", "57",
            "58", "59", "510", "511", "512", "62", "63", "64", "65", "66", "67", "68", "69",
            "610", "611", "612", "613", "73", "74", "75", "76", "77", "78", "79", "710", "711",
            "712", "713", "86", "87", "88", "89", "810", "811", "812", "813", "95", "96", "911", "912",
            "105", "106", "1011", "1012", "116", "1111", "1112", "124", "125", "126", "1212", "1213",
            "132", "133"};
            if (array.Contains(text))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
