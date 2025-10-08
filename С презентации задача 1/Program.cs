using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С_презентации_задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год: "); //текстовая подсказка
            int year = Convert.ToInt32(Console.ReadLine()); //ввод данных

            if (year % 4 == 0) //если остаток от деления на 4 равен 0, то год высокосный
                Console.WriteLine("Высокосный год");
            else
                Console.WriteLine("Обычный год"); // в остальных случаях это обычный год
            
            Console.ReadKey();

        }
    }
}
