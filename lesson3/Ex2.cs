using System;

namespace Ex2
{
    class Summa
    {
        public int x = 1;
        public int sum = 0;

        public void Print()
        {
            Console.WriteLine("Введите числа: ");
        }

        //private static void Analysis()
        //{
        //    while (x > 0)
        //    {
        //        x = int.Parse(Console.ReadLine());

        //        if ((x > 0) && (x % 2 == 1))
        //        {
        //            sum = sum + x;
        //        }
        //    }
        //}

    }

    class Program
    {
        struct Analysis
        {
            public int An(int x, int sum)
            {
                while (x > 0) 
                {
                    x = int.Parse(Console.ReadLine());

                    if ((x > 0) && (x % 2 == 1))
                    {
                        sum = sum + x;
                    }
                }
                Console.WriteLine(sum);
                return sum;
            }
        }

        static void Main(string[] args)
        {
            //а) С клавиатуры вводятся числа, пока не будет введён 0(каждое число в новой строке).
            //Требуется подсчитать сумму всех нечётных положительных чисел.
            //Сами числа и сумму вывести на экран, используя tryParse.

            Summa summma1 = new Summa();
            summma1.Print();
            int x = 1;
            int x1 = int.Parse(Console.ReadLine());
            if (x != 0)
            {
                Analysis struct1;
                struct1.An(1, 0);
            }

            //Console.WriteLine(summma1.sum);

            //Console.WriteLine("Сумма нечётных положительных чисел: " + sum);

        }
    }
}
