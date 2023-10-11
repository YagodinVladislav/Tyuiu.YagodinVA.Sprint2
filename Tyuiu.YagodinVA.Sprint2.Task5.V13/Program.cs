using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YagodinVA.Sprint2.Task5.V13.Lib;
namespace Tyuiu.YagodinVA.Sprint2.Task5.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Ягодин В.А. | АСОиУБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Ягодин Владислав Александрович | АСОиУБ-23-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу, которая вычисляет дату следующего дня               *");
            Console.WriteLine("* по заданным значениям пользователем (год, месяц, день).                 *");
            Console.WriteLine("* Заданный год является високосным.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Введите год (переменная g):");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите месяц (переменная m):");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите день (переменная n):");
            int n = Convert.ToInt32(Console.ReadLine());
            string res = ds.FindDateOfNextDay(g, m, n);
            Console.WriteLine($" Дата следующего дня: {res}");
            Console.ReadKey();
        }
    }
}
