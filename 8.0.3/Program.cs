using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._0._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int numb = Convert.ToInt32(Console.ReadLine());

            if (numb == 5 | numb == 10)
                Console.WriteLine("Число либо равно 5, либо равно 10");
            else
                Console.WriteLine("Неизвестное число");

            Console.ReadKey();
            
        }
    }

}