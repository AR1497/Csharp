using System;
using System.Text;
using System.Linq;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
            //В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.

            Console.WriteLine("Введите ваше имя: ");
            var name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию: ");
            var surname = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш рост: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш вес: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Имя: " + name + " Фамилия: " + surname + " Возраст: " + age + " Рост: " + height + " Вес: " + weight);
            Console.WriteLine("Имя: " + name + " Фамилия: " + surname + " Возраст: " + age + " Рост: " + height.ToString("###.#") + " Вес: {0:F1}", weight);
            Console.WriteLine($"Имя: {name} Фамилия: {surname} Возраст: {age} Рост: {height} Вес: {weight}");
        }
    }
}
