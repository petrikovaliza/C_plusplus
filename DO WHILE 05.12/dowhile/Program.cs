using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 17.1

            //int numbers, sum = 0;
            //Console.WriteLine("Введите построчно последовательность чисел, заканчивающуюся нулем: ");
            //do
            //{
            //    numbers = int.Parse(Console.ReadLine());
            //    sum += numbers;
            //}
            //while (numbers != 0);

            //Console.WriteLine("Сумма введенных чисел = " + sum);
            //Console.ReadKey();

            // 17.2

            //int numbers, minNumb = 0;
            //Console.WriteLine("Введите построчно последовательность чисел, заканчивающуюся нулем: ");
            //do
            //{
            //    numbers = int.Parse(Console.ReadLine());
            //    minNumb = Math.Min(numbers,minNumb);                
            //}
            //while (numbers != 0);

            //Console.WriteLine("Минимальное значение = " + minNumb);
            //Console.ReadKey();

            // 17.3

            //int numbers, minNumb = 0, maxNumb = 0;
            //Console.WriteLine("Введите количество чисел в последовательности: ");
            //int countNumb = int.Parse(Console.ReadLine());
            //int startcount = 0;
            //Console.WriteLine("Введите построчно числа: ");
            //do
            //{
            //    numbers = int.Parse(Console.ReadLine());
            //    minNumb = Math.Min(numbers, minNumb);
            //    maxNumb = Math.Max(numbers, maxNumb);
            //    startcount++;
            //}
            //while (startcount < countNumb);

            //int raznost = maxNumb - minNumb;

            //Console.WriteLine("Разность между макс и мин = " + raznost);
            //Console.ReadKey();

            // 17.4

            //int number, countMinNumb = 0, minNumb = Int32.MaxValue;

            //Console.WriteLine("Введите построчно последовательность чисел, заканчивающуюся нулем: ");

            //do
            //{
            //    number = int.Parse(Console.ReadLine());

            //    if (number == 0)
            //        break;

            //    if (number < minNumb)
            //    {
            //        minNumb = number;
            //        countMinNumb = 1;
            //    }
            //    else if (number == minNumb)
            //    {
            //        countMinNumb++;
            //    }
            //} while (true);

            //Console.WriteLine($"Количество минимальных значений = {countMinNumb}");
            //Console.ReadKey();

            // 17.5

            //Console.WriteLine("Введите рост первого ученика:");
            //double predRost = double.Parse(Console.ReadLine()); 
            //bool ubuvanie = true;

            //do
            //{
            //    Console.WriteLine("Введите рост следующего ученика (или 0 для завершения ввода):");
            //    double tekRost = Convert.ToDouble(Console.ReadLine()); 
            //    if (tekRost == 0)
            //    {
            //        break; 
            //    }

            //    if (tekRost > predRost)
            //    {
            //        ubuvanie = false;
            //        break;
            //    }

            //    predRost = tekRost;
            //} while (true);

            //if (ubuvanie)
            //{
            //    Console.WriteLine("Ученики перечислены в порядке убывания их роста.");
            //}
            //else
            //{
            //    Console.WriteLine("Ученики не перечислены в порядке убывания их роста.");
            //}

            //Console.ReadKey();

            // 17.6

            //int currentNumber, predudNumber = 0;
            //int index = 1;
            //bool foundPair = false;

            //Console.WriteLine("Введите целые числа (для завершения введите 9999):");

            //do
            //{
            //    currentNumber = int.Parse(Console.ReadLine());

            //    if (currentNumber == 9999)
            //    {
            //        break;
            //    }

            //    if (currentNumber == predudNumber)
            //    {
            //        Console.WriteLine($"Найдена пара одинаковых соседних чисел на позициях {index - 1} и {index}.");
            //        foundPair = true;
            //    }

            //    predudNumber = currentNumber;
            //    index++;
            //} while (true);

            //if (!foundPair)
            //{
            //    Console.WriteLine("Пар одинаковых соседних чисел не найдено.");
            //}

            //Console.ReadKey();

            // 17.7

            //int currentNumber, predudNumber = int.MinValue;
            //int index = 1;
            //bool vozrastanie = true;

            //Console.WriteLine("Введите целые числа (для завершения введите 9999):");

            //do
            //{
            //    currentNumber = int.Parse(Console.ReadLine());

            //    if (currentNumber == 9999)
            //    {
            //        break;
            //    }

            //    if (currentNumber < predudNumber)
            //    {
            //        Console.WriteLine($"Последовательность не упорядочена по возрастанию. Нарушение на позиции {index}.");
            //        vozrastanie = false;
            //        break;
            //    }

            //    predudNumber = currentNumber;
            //    index++;
            //} while (true);

            //if (vozrastanie)
            //{
            //    Console.WriteLine("Последовательность упорядочена по возрастанию.");
            //}

            //Console.ReadKey();

            // 17.8

            //double bestTime = double.MaxValue; 
            //double currentTime;

            //do
            //{
            //    Console.Write("Введите время спортсмена (0 для завершения): ");
            //    currentTime = double.Parse(Console.ReadLine());

            //    if (currentTime == 0)
            //    {
            //        break;
            //    }

            //    if (currentTime < bestTime)
            //    {
            //        bestTime = currentTime;
            //        Console.WriteLine($"Новый лучший результат: {bestTime} секунд.");
            //    }
            //} while (true);

            //Console.WriteLine("\nЛучший результат среди всех участников: " + {bestTime} + " секунд.");
            //Console.ReadKey();
        }
    }
}
