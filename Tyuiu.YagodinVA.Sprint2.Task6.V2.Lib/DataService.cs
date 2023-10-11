using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YagodinVA.Sprint2.Task6.V2.Lib
{
    public class DataService : ISprint2Task6V2
    {
        public string FindMonthSeason(int value)
        {
            string result;
            switch (value)
            {
                case 1:
                    result = "Зима";
                    break;
                case 2:
                    result = "Зима";
                    break;
                case 3:
                    result = "Весна";
                    break;
                case 4:
                    result = "Весна";
                    break;
                case 5:
                    result = "Весна";
                    break;
                case 6:
                    result = "Лето";
                    break;
                case 7:
                    result = "Лето";
                    break;
                case 8:
                    result = "Лето";
                    break;
                case 9:
                    result = "Осень";
                    break;
                case 10:
                    result = "Осень";
                    break;
                case 11:
                    result = "Осень";
                    break;
                case 12:
                    result = "Зима";
                    break;
                default:
                    result = "Некорректный ввод";
                    break;
            }
            return result;
        }
    }
}
