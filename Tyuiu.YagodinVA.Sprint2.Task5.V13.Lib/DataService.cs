using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YagodinVA.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int[] months = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            switch (n)
            {
                case 29:
                    m = 3;
                    n = 1;
                    break;
                case 30:
                    if (months[m + 1] == 30)
                    {
                        n = 1;
                        m += 1;
                    }
                    break;
                case 31:
                    if (months[m + 1] == 31)
                    {
                        n = 1;
                        m += 1;
                    }
                    break;
                default:
                    n += 1;
                    break;
            }
            string res = $"{g}-{m}-{n}";
            return res;
        }
    }
}
