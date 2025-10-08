using System;

namespace petrikova
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 5

            Console.WriteLine("Введите два числа:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Среднее арифметическое: " + (num1 + num2) / 2.0);
            Console.ReadKey();

            // Задание 5

            Console.WriteLine("Введите 3 стороны треугольника:");
            int storona1 = int.Parse(Console.ReadLine());
            int storona2 = int.Parse(Console.ReadLine());
            int storona3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Площадь: " + (storona1 * storona2 / 2));
            Console.WriteLine("Периметр: " + (storona1 + storona2 + storona3));
            Console.ReadKey();
        }
    }
}
