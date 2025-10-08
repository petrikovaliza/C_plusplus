using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С_презентации_задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 31000; //цена выбранного ноутбука

            if (price >= 2000 & price <= 30000) //Проверяем оба условия
                Console.WriteLine("Подходит");
            else
                Console.WriteLine("Не подходит");

            Console.ReadKey();
        }
    }
}
