using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Tyuiu.ZhdanovaAA.Sprint5.Task1.V28.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint5.Task1.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Жданова А. А. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание: 1                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнила: Жданова Анна Александровна                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, (произвести табулирование) f(x) на заданном диапозоне     *");
            Console.WriteLine("* [-5; 5] с шагом 1. Произвести проверку деления на ноль. При делении на  *");
            Console.WriteLine("* ноль вернуть значение 0. Результат сохранить в текстовый файл OutPutFile*");
            Console.WriteLine("* Task1.txt и вывести на консоль в таблицу. Значения округлить до двух    *");
            Console.WriteLine("* знаков после запятой.                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"startValue = {startValue}");
            Console.WriteLine($"stopValue = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine($"Файл: {path}");
            Console.WriteLine("Создан!");

            Console.WriteLine("+-------------+-------------+");
            Console.WriteLine("|      X      |     f(x)    |");
            Console.WriteLine("+-------------+-------------+");

            string[] y = File.ReadAllLines(path);
            
            for (int x = startValue, i = 0; x <= stopValue - 1; x++, i++)
            {
                Console.WriteLine("| {0,6:d}      |   {1,6:f2}    |", x, Convert.ToDouble(y[i]));
            }

            Console.WriteLine("+-------------+-------------+");
            Console.ReadKey();
        }
    }
}
