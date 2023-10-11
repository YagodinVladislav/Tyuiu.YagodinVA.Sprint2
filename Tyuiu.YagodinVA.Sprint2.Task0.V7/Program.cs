using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YagodinVA.Sprint2.Task0.V7.Lib;

namespace Tyuiu.YagodinVA.Sprint2.Task0.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 103;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #2 | Выполнил: Ягодин  В.А. | АСОиУБ-23-2";
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                     *");
            Console.WriteLine("* Тема: Операции сравнения                                                      *");
            Console.WriteLine("* Задание #0                                                                    *");
            Console.WriteLine("* Вариант #7                                                                    *");
            Console.WriteLine("* Выполнил: Ягодин Владислав Александрович | АСОиУБ-23-2                        *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                      *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Написать программу из операций сравнения и арифметических действий,           *");
            Console.WriteLine("* которая вернёт логическую последовательность (массив)                         *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                              *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine($"* X = {x}                                                                      *");
            Console.WriteLine($"* Y = {y}                                                                      *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                    *");
            Console.WriteLine("*********************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
