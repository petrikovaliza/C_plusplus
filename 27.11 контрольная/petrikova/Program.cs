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
            // Задание 1

            //Console.Write("Введите начало отрезка a: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Введите конец отрезка b: ");
            //int b = int.Parse(Console.ReadLine());

            //Console.Write("Введите шаг h: ");
            //int h = int.Parse(Console.ReadLine());

            //for (int x = a; x <= b; x += h)
            //{
            //    int y = x * x * x + 2 * x * x + 4 * x + 7;
            //    Console.WriteLine($"x = {x}, y = {y}");
            //    Console.ReadKey();

            //}

            // Задание 2

            //double sum = 20;
            //sum += sum * 0.05 * (2010 - 1626);

            //Console.WriteLine($"На счету в 2010 было бы {sum} долларов");
            //Console.ReadKey();

            // Задание 3

            Console.Write("Введите начало отрезка a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите конец отрезка b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите делитель x: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                if (i % x == 0)
                {
                    Console.WriteLine(i);
                    Console.ReadKey();
                }
            }
        }
    }
}
