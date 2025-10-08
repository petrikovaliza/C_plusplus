using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arifmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите два числа: ");
            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Среднее арифметическое: ");
            Console.WriteLine((n + s) / 2.0);
            Console.ReadKey();
        }    
    }
}
