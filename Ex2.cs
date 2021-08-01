using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h);
            //где m — масса тела в килограммах, h — рост в метрах.

            Console.WriteLine("Введите ваш вес: ");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш рост: ");
            double h = Convert.ToDouble(Console.ReadLine());

            double I = m / (h * h);

            Console.WriteLine("{0:F5}", I);
        }
    }
}
