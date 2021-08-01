using System;

class Program
{
    static void Main(string[] args)
    {
        //Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
        //а) с использованием третьей переменной;
        //б) *без использования третьей переменной.

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = a;
        a = b;
        b = c;

        Console.WriteLine(a.ToString() + "\n" + b.ToString());
    }
}

