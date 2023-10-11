using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YagodinVA.Sprint2.V7.Lib;

namespace Tyuiu.YagodinVA.Sprint2.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Ягодин В А | ACOиУБ 23-2";
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                      *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                               *");
            Console.WriteLine("* Задание #0                                                                     *");
            Console.WriteLine("* Вариант #7                                                                     *");
            Console.WriteLine("* Выполнил Ягодин Владислав Александрович | AСОиУБ 23-2                          *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, после-         *");
            Console.WriteLine("* довательность операций не должна нарушаться) и арифметических выражений,       *");
            Console.WriteLine("* которая вернет логическую последовательность(массив): (True, False,            *");
            Console.WriteLine("* True, True, False, True),  при x = 103 , y = 475                               *");
            Console.WriteLine("*                                                                                *");
            Console.WriteLine("**********************************************************************************");



            int x = 103;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadLine();
        }
    }
}
