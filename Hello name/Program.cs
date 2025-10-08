using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Скажи как тебя зовут:");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}");
            Console.ReadKey();
        }
    }
}
