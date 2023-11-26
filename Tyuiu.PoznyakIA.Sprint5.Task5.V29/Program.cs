﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PoznyakIA.Sprint5.Task5.V29.Lib;
namespace Tyuiu.PoznyakIA.Sprint5.Task5.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Позняк И.А. | ИСТНб-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #29                                                            *");
            Console.WriteLine("* Выполнил: Позняк Игорь Андреевич    | ИСТНб-23-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан файл C:|DataSprint5|Sprint5Task5|InPutDataFileTask5V29.txt         *");
            Console.WriteLine("* в котором есть набор значений. Найти минимальное целое число в файле,  *");
            Console.WriteLine("* которое является двузначным числом. Полученный результат вывести на    *");
            Console.WriteLine("* консоль.                                                               *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            string path = @"C:\Sprint\Sprint5Task5\InPutDataFileTask5V29.txt";

            Console.WriteLine("Данные находятся в файле" + path);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
