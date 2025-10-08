using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._0._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите первое число:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
            int operation = Convert.ToInt32(Console.ReadLine());

            if (operation == 1)
                Console.WriteLine("Сложение: " + (num1 + num2));

            else if (operation == 2)
                Console.WriteLine("Вычитание: " + (num1 - num2));

            else if (operation == 3)
                Console.WriteLine("Умножение: " + (num1 * num2));

            else
                Console.WriteLine("Операция неопределена");

            Console.ReadKey();

        }
    }
}

