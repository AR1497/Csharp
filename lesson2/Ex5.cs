using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //а) Написать программу, которая запрашивает массу и рост человека,
            //вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

            Console.WriteLine("Введите ваш вес(кг): ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш рост(см): ");
            double height = double.Parse(Console.ReadLine());

            double res = weight / (height * height);

            //Масса(кг) = (Рост(см) - 100) - (Рост(см) - 150) / 2.
            double massa = ((height - 100) - (height - 150) / 2);

            if (res <= 0.0016)
            {
                Console.WriteLine("У вас выраженный дефицит массы тела. Для достижения нормы вам необходимо набрать: ");
                res = massa - weight;
                Console.WriteLine(res + " кг");
            }
            else if (res > 0.0016 && res <= 0.00185)
            {
                Console.WriteLine("У вас недостаточна (дефицит) масса тела. Для достижения нормы вам необходимо набрать: ");
                res = massa - weight;
                Console.WriteLine(res + " кг");
            }
            else if (res > 0.00185 && res <= 0.002499)
            {
                Console.WriteLine("Норма");
            }
            else if (res > 0.0025 && res <= 0.0030)
            {
                Console.WriteLine("Избыточная масса тела. Для достижения нормы вам необходимо сбросить: ");
                res = weight - massa;
                Console.WriteLine(res + " кг");
            }
            else if (res > 0.0030 && res <= 0.0035)
            {
                Console.WriteLine("Ожирение 1-ей степени. Для достижения нормы вам необходимо сбросить: ");
                res = weight - massa;
                Console.WriteLine(res +  "кг");
            }
            else if (res > 0.0035 && res <= 0.0040)
            {
                Console.WriteLine("Ожирение 2-ей степени. Для достижения нормы вам необходимо сбросить: ");
                res = weight - massa;
                Console.WriteLine(res + " кг");
            }
            else 
            { 
                Console.WriteLine("Ожирение 3-ей степени (морбидное). Для достижения нормы вам необходимо сбросить: ");
                res = weight - massa;
                Console.WriteLine(res + " кг");
            }


        }
    }
}
