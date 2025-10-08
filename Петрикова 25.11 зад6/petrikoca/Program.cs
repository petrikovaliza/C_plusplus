using System;

namespace petrikoca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 4 числа");
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат: " + (x1 + x2 > x3 + x4));
            Console.ReadKey();
        }
    }
}
