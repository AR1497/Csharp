using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Реализовать метод проверки логина и пароля.
            //На вход метода подается логин и пароль.
            //На выходе истина, если прошел авторизацию,
            //и ложь, если не прошел
            //(Логин: root, Password: GeekBrains).
            //Используя метод проверки логина и пароля, написать программу:
            //пользователь вводит логин и пароль,
            //программа пропускает его дальше или не пропускает.
            //С помощью цикла do while ограничить ввод пароля тремя попытками.
            string login = "root";
            string password = "GeekBrains";
            
            int k = 0;

            do
            {
                Console.WriteLine("Введите логин: ");
                var login_1 = Console.ReadLine();
                Console.WriteLine("Введите пароль: ");
                var password_1 = Console.ReadLine();

                if ((login != login_1) || (password != password_1))
                {
                    Console.WriteLine("Неправильно введён пароль или логин");
                }
                else
                {
                    Console.WriteLine("Вы успешно вошли в учётную запись");
                    break;
                }
                k++;
            }
            while (k < 3);
        }
    }
}
