﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Tyuiu.PoznyakIA.Sprint5.Task4.V21.Lib;
namespace Tyuiu.PoznyakIA.Sprint5.Task4.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Позняк И.А. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Позняк Игорь Андреевич   | ИСТНб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt (файл взять из архива  *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и      *");
            Console.WriteLine("* скопировать в неё файл) в котором есть вещественное значение. Прочитать *");
            Console.WriteLine("* значение из файла и подставить вместо Х в формуле y = x^3 * cos(x) + 2x *");
            Console.WriteLine("* Вычислить значение по формуле (Полученное значение округлить до трёх    *");
            Console.WriteLine("* знаков после запятой) и вернуть полученный результат на консоль.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Sprint\Sprint5Task4\InPutDataFileTask4V21.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            double numb = ds.LoadFromDataFile(path);

            Console.WriteLine(numb);

            Console.ReadLine();
        }
    }
}
