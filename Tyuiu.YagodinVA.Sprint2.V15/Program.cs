using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YagodinVA.Sprint2.V26.Lib;

namespace Tyuiu.YagodinVA.Sprint2.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Ягодин В А  | АСОиУБ-23-2";
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                     *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                            *");
            Console.WriteLine("* Задание #2                                                                    *");
            Console.WriteLine("* Вариант #26                                                                   *");
            Console.WriteLine("* Выполнил: Ягодин Владислав Александрович | АСОиУБ-23-2                        *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                      *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры           *");
            Console.WriteLine("* и вычисляет, находится ли точка с координатами X, Y                           *");
            Console.WriteLine("* в заштрихованной области.                                                     *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                              *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("Введите координату 'X':");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату 'Y':");
            int y = Convert.ToInt32(Console.ReadLine());
            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                    *");
            Console.WriteLine("*********************************************************************************");
            if (res)
            {
                Console.WriteLine($"Точка с координатами {x} {y} находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine($"Точка с координатами {x} {y} не находится в заштрихованной области");
            }
            Console.ReadKey();
        }
    }
}