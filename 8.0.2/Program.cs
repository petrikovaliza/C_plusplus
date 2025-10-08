using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._0._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int numb = Convert.ToInt32(Console.ReadLine());

            if (numb > 5 & numb < 10)
                Console.WriteLine("Число больше 5 и меньше 10");
            else
                Console.WriteLine("Неизвестное число");

            Console.ReadKey();
        }
    }
}
