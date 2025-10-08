using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petrikova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 9.1

            Console.WriteLine("Введите построчно два числа: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else if (num1 < num2)
            {
                Console.WriteLine(num2);
            }
            else
            { 
                Console.WriteLine(num2);
            }

            Console.ReadKey();

            // Задание 9.2

            Console.WriteLine("Введите целое число: ");
            int number1 = int.Parse(Console.ReadLine());

            if (number1 % 2 == 0)
            {
                Console.WriteLine("Это число четное");
            }
            else
            {
                Console.WriteLine("Это число нечетное");
            }

            Console.ReadKey();

            // Задание 9.3

            Console.WriteLine("Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("Вы несовершеннолетний");
            }
            else if (age > 18 && age < 65)
            {
                Console.WriteLine("Вы взрослый");
            }
            else
            {
                Console.WriteLine("Вы пожилой человек");
            }

            Console.ReadKey();

            // Задание 9.4

            Console.WriteLine("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("Этот год високосный");
            }
            else
            {
                Console.WriteLine("Год обычный");
            }

            Console.ReadKey();

        }
    }
}
