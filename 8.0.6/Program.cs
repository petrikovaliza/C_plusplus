using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._0._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
            int operation = Convert.ToInt32(Console.ReadLine());

            if (operation == 1)
                Console.WriteLine("Сложение");
            else if (operation == 2)
                Console.WriteLine("Вычитание");
            else if (operation == 3)
                Console.WriteLine("Умножение");
            else
                Console.WriteLine("Операция неопределена");

            Console.ReadKey();
          
        }
    }
}
