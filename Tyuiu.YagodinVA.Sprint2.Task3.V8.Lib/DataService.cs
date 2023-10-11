using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YagodinVA.Sprint2.Task3.V8.Lib
{
    public class DataService : ISprint2Task3V8
    {
        public double Calculate(double x)
        {
            double res;
            if (x > 0)
            {
                res = (Math.Sin(x) + Math.Cos(x)) / (Math.Cos(x) - Math.Sin(x));
            }
            else if (x == 0)
            {
                res = ((Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12));
            }
            else if ((x < 0) && (x > -12))
            {
                res = Math.Pow(1 + (3 / (Math.Pow(x, 2))), x);
            }
            else
            {
                res = x + 10 * x - (5 / x);
            }
            return Math.Round(res, 3);
        }
    }
}
