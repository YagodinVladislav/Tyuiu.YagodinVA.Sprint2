using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YagodinVA.Sprint2.Task1.V15.Lib;

namespace Tyuiu.YagodinVA.Sprint2.Task1.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 415;
            int b = 616;
            int c = 134;
            int d = 127;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Ягодин  В.А. | АСОиУБ-23-2";
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                     *");
            Console.WriteLine("* Тема: Логические операции                                                     *");
            Console.WriteLine("* Задание #1                                                                    *");
            Console.WriteLine("* Вариант #15                                                                   *");
            Console.WriteLine("* Выполнил: Ягодин Владислав Александрович | АСОиУБ-23-2                        *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                      *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Написать программу из операций сравнения и логических операций,               *");
            Console.WriteLine("* а также арифметических выражений, которая                                     *");
            Console.WriteLine("* вернет логическую последовательность (массив)                                 *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                              *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine($"* A = {a}                                                                      *");
            Console.WriteLine($"* B = {b}                                                                      *");
            Console.WriteLine($"* C = {c}                                                                      *");
            Console.WriteLine($"* D = {d}                                                                      *");
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
