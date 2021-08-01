﻿using System;

namespace Ex3
{
    class Program
    {
        //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле
        //r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f
        //(с двумя знаками после запятой);
        //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода

        private static void Main(string[] args)
        {
            Console.WriteLine("Введите точку x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите точку y1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите точку x2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите точку y2: ");
            int y2 = int.Parse(Console.ReadLine());

            var r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("{0:F2}", r);
        }
    }
}
