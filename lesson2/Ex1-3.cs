using System;
using System.Linq;

namespace lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать метод, возвращающий минимальное из трёх чисел
            //Ex1();

            //Написать метод подсчета количества цифр числа.
            //Ex2();

            //С клавиатуры вводятся числа, пока не будет введен 0.Подсчитать сумму всех нечетных положительных чисел.
            //Ex3();
            
        }

        private static void Ex3()
        {
            Console.WriteLine("Введите число: ");
            while (true)
            {
                var a = Convert.ToInt32(Console.ReadLine());
                if (a != 0)
                {
                    continue;
                }
                else break;
            }
        }

        private static void Ex2()
        {
            Console.WriteLine("Введите число: ");
            var a = Convert.ToInt32(Console.ReadLine());
            int i = 0;

            while (a > 0)
            {
                a = a / 10;
                i++;
            }
            Console.WriteLine(i);
        }

        private static void Ex1()
        {
            Console.WriteLine("Введите 3 числа: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            if ((a < b) && (a < c)) Console.WriteLine($"Число {a} минимально");
            else if ((b < a) && (b < c)) Console.WriteLine($"Число {b} минимальное число");
            else Console.WriteLine($"Число {c} минимальное число");
        }
    }
}
