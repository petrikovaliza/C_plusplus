using System;

namespace petrikova7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 7.1

            Console.Write("Студент: {0} Номер: {1}", "Петров", 4);
            Console.ReadKey();

            //Задание 7.2

            double pi = Math.PI;
            Console.WriteLine("Число: " + pi);
            Console.WriteLine("Число: {0:#.#} ", pi);
            Console.WriteLine("Число: {0:#.###} ", pi);
            Console.ReadKey();

            Console.WriteLine("\tПН\tВТ\tСР");
            Console.WriteLine("1.\t+9\t+12\t+10");
            Console.WriteLine("\n\n\n  Четверг\n  Пятница\n  Суббота");
            Console.ReadKey();

            //Задание 7.3

            const double PI = Math.PI;
            double err = 0.00001;

            Console.Write("Форматирование:\n");
            Console.WriteLine("Обычный: " + PI);
            Console.WriteLine("С резервацией: {0,20}", PI);
            Console.WriteLine("Несколько значений: {0,20} \t{1,10}", PI, err);
            Console.WriteLine("Вывод с точностью до 5 знаков: {0:#.#####}", PI);
            Console.ReadKey();

            // Задание 7.4

            const double PI = Math.PI;
            Console.WriteLine("C формат: {0,15:C} \t{0:C3}", PI); 
            Console.WriteLine("D формат: {0,15:D} \t{0:D8}", 2018);
            Console.WriteLine("E формат: {0,15:E} \t{0:E5}", PI);
            Console.WriteLine("G формат: {0,15:G} \t{0:G5}", PI);
            Console.WriteLine("N формат: {0,15:N} \t{0:N5}", PI);
            Console.WriteLine("X формат: {0,15:X} ", 2018);
            Console.WriteLine("P формат: {0,15:P} ", PI);
            Console.ReadKey();
        }
    }
}
