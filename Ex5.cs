using System;

namespace Ex5
{
    class Program
    {
        //5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        //   б) Сделать задание, только вывод организовать в центре экрана.
        //   в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).

        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя: ");
            var name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию: ");
            var surname = Console.ReadLine();
            Console.WriteLine("Введите ваш город: ");
            var city = Console.ReadLine();

            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine(name + " " + surname + " " + city);
        }
    }
}
