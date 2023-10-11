using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YagodinVA.Sprint2.Task2.V26.Lib
{
    public class DataService : ISprint2Task2V26
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            string[] array = new string[] { "33", "34", "35", "39", "310", "311", "312", "43", "44", "45", "49",
            "410", "53", "54", "55", "56", "57", "58", "59", "510", "63", "64", "65", "66", "67", "68", "69", "610",
            "611", "612", "613", "73", "74", "75", "76", "77", "78", "79", "710", "711", "712", "713", "86", "87",
            "88", "89", "810", "811", "812", "813", "96", "97", "98", "99", "106", "107", "108", "109", "113", "114",
            "115", "116", "117", "118", "119", "1110", "1111", "1112", "127", "128", "129", "1210", "1211", "1212",
            "139", "1310" };
            string line = $"{x}{y}";
            if (array.Contains(line))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
