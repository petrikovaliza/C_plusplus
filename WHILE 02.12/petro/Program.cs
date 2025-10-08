using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 16.1

            //int i = 0;
            //while (i <= 119)
            //{
            //    Console.WriteLine("I am a code writer!");
            //    i++;
            //}

            //Console.ReadKey();

            // 16.2

            //int i = -2;

            //while (i >= -200)
            //{
            //    Console.WriteLine(i);
            //    i -= 2;
            //}

            //Console.ReadKey();

            // 16.3

            //Console.Write("Введите начало отрезка a: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("Введите конец отрезка b: ");
            //int end = int.Parse(Console.ReadLine());

            //int currentNumber = start;

            //while (currentNumber <= end)
            //{
            //    if (currentNumber % 2 == 0)
            //        Console.WriteLine(currentNumber);
            //        currentNumber++;
            //}    
            //Console.ReadKey();

            // 16.4

            //Console.Write("Введите число x: ");
            //int naturalNumber = int.Parse(Console.ReadLine());
            //int i = 1;
            //while (i <= naturalNumber / 2)
            //{
            //    if (naturalNumber % i == 0)
            //        Console.WriteLine(i);
            //        i++;
            //}
            //Console.ReadKey();

            // 16.5

            //Console.Write("Введите первое число: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("Введите второе число: ");
            //int end = int.Parse(Console.ReadLine());

            //int minstart = Math.Min(start, end);
            //int maxend = Math.Max(start, end);

            //int currentNumber = maxend;
            //while (currentNumber >= minstart)
            //{
            //    if (currentNumber % 9 == 0)
            //        Console.WriteLine(currentNumber);
            //    currentNumber--;
            //}
            //Console.ReadKey();

            // 16.6 

            //Console.Write("Введите число n: ");
            //int targetSum = int.Parse(Console.ReadLine());
            //int currentNumber = 1;

            //while ((long)currentNumber * currentNumber <= int.MaxValue)
            //{
            //    int squaredNumber = currentNumber * currentNumber;
            //    int digitSum = 0;
            //    int temporarySquaredNumber = squaredNumber;
            //    while (temporarySquaredNumber > 0)
            //    {
            //        digitSum += temporarySquaredNumber % 10;
            //        temporarySquaredNumber /= 10;
            //    }

            //    if (digitSum > targetSum)
            //    {
            //        Console.WriteLine(currentNumber); 
            //    }

            //    currentNumber++;

                // 16.7

                //int sum = 0;

                //bool continueInput = true;

                //while (continueInput)
                //{
                //    Console.Write("Введите число (или 'q' для завершения): ");
                //    string input = Console.ReadLine();

                //    if (input == "q")
                //    {
                //        Console.WriteLine($"Сумма введенных чисел: {sum}");
                //        Console.ReadKey();
                //        continueInput = false;
                //    }
                //    else
                //    {
                //        int number = int.Parse(input);
                //        sum += number;
                //    }
                //}

                // 16.8

                //int countDelit = 0;

                //Console.Write("Введите число n: ");
                //int number = int.Parse(Console.ReadLine());

                //int i = 1;
                //while (i <= number / 2)
                //{
                //    if (number % i == 0 && i != 1 && i != number)
                //        countDelit += 1;
                //        i++;
                //}

                //Console.WriteLine($"Количество натуральных чисел: {countDelit}");
                //Console.ReadKey();

                // 16.9

                //Console.Write("Введите количество чисел n: ");
                //int n = int.Parse(Console.ReadLine());

                //int sum = 0;
                //int negativeEvenCount = 0;

                //int count = 0;
                //while (count < n)
                //{
                //    Console.Write($"Введите {count + 1}-е число: ");
                //    int number = int.Parse(Console.ReadLine());

                //    if (number < 0 && number % 2 == 0)
                //    {
                //        sum += number;
                //        negativeEvenCount++;
                //    }

                //    count++;
                //}

                //Console.WriteLine($"Сумма отрицательных чётных чисел: {sum}");
                //Console.WriteLine($"Количество отрицательных чётных чисел: {negativeEvenCount}");
                //Console.ReadKey();

                // 16.10

                //Console.Write("Введите количество чисел n: ");
                //int n = int.Parse(Console.ReadLine());

                //int sum = 0;

                //int count = 0;
                //while (count < n)
                //{
                //    Console.Write($"Введите {count + 1}-е число: ");
                //    int number = int.Parse(Console.ReadLine());

                //    if (number > 5 && number < n)
                //    {
                //        sum += number;

                //    }

                //    count++;
                //}

                //Console.WriteLine($"Сумма чисел больше 5, но меньше введенного n: {sum}");
                //Console.ReadKey();

                // 16.11

                //Console.Write("Введите количество чисел n: ");
                //int n = int.Parse(Console.ReadLine());

                //int countEnd5 = 0;

                //int count = 0;
                //while (count < n)
                //{
                //    Console.Write($"Введите {count + 1}-е число: ");
                //    int number = int.Parse(Console.ReadLine());

                //    if (number % 10 == 5)
                //    {
                //        countEnd5++;
                //    }

                //    count++;
                //}

                //Console.WriteLine($"Количество чисел, оканчивающихся на 5: {countEnd5}");
                //Console.ReadKey();

                // 16.12

                //Console.Write("Введите количество чисел: ");
                //int n = Convert.ToInt32(Console.ReadLine());
                //bool zeroFound = false;

                //int i = 0;

                //while (i < n)
                //{
                //    Console.Write($"Введите {i + 1}-е число: ");
                //    int number = Convert.ToInt32(Console.ReadLine());

                //    if (number == 0)
                //    {
                //        zeroFound = true;
                //        break;
                //    }

                //    i++;
                //}

                //if (zeroFound)
                //{
                //    Console.WriteLine("Ноль найден");

                //}
                //else
                //{
                //    Console.WriteLine("Нет нулей");
                //}

                //Console.ReadKey();

                // 16.13

                //Console.Write("Введите число n: ");
                //int n = int.Parse(Console.ReadLine());
                //int result = 1;

                //if (n < 0)
                //{
                //    int currentNumber = n;
                //    while (currentNumber <= 1)
                //    {
                //        if (currentNumber % 2 != 0)
                //        {
                //            result *= currentNumber;
                //        }
                //        currentNumber++;
                //    }
                //}
                //else
                //{
                //    int currentNumber = 1;
                //    while (currentNumber <= n)
                //    {
                //        if (currentNumber % 2 == 0)
                //        {
                //            result *= currentNumber;
                //        }
                //        currentNumber++;
                //    }
                //}

                //Console.WriteLine($"Произведение: {result}");
                //Console.ReadKey();

                // 16.14

                //Console.Write("Введите основание a: ");
                //double a = Convert.ToDouble(Console.ReadLine());

                //Console.Write("Введите показатель степени n: ");
                //int n = Convert.ToInt32(Console.ReadLine());

                //double result = 1;

                //if (n == 0)
                //{
                //    if (a != 0)
                //        result = 1;
                //    else
                //        Console.WriteLine("Ошибка. Ноль в нулевой степени.");
                //}
                //else if (n > 0)
                //{
                //    int counter = 0;
                //    while (counter < n)
                //    {
                //        result *= a;
                //        counter++;
                //    }
                //}
                //else
                //{
                //    n = -n;
                //    int counter = 0;
                //    while (counter < n)
                //    {
                //        result *= a;
                //        counter++;
                //    }
                //    result = 1 / result;
                //}

                //Console.WriteLine($"Результат: {result}");
                //Console.ReadKey();

                // 16.15

                //Console.Write("Введите начало отрезка a: ");
                //int a = int.Parse(Console.ReadLine());

                //Console.Write("Введите конец отрезка b: ");
                //int b = int.Parse(Console.ReadLine());

                //if (a > b)
                //{
                //    int vremenno = a;
                //    a = b;
                //    b = vremenno;
                //}

                //long multiply = 1;
                //int currentNumber = a;

                //while (currentNumber <= b)
                //{
                //    multiply *= currentNumber;
                //    currentNumber++;
                //}

                //Console.WriteLine(multiply);
                //Console.ReadKey();

                // 16.16

                //Console.Write("Введите начало отрезка a: ");
                //int a = int.Parse(Console.ReadLine());

                //Console.Write("Введите конец отрезка b: ");
                //int b = int.Parse(Console.ReadLine());

                //if (a > b)
                //{
                //    int vremenno = a;
                //    a = b;
                //    b = vremenno;
                //}

                //long multiply = 1;
                //int currentNumber = a;

                //while (currentNumber <= b)
                //{
                //    if (currentNumber % 10 == 7)
                //    {
                //        multiply *= currentNumber;
                //    }
                //    currentNumber++;
                //}

                //Console.WriteLine($"Произведение чисел на отрезке от a до b, оканчивающихся на 7 - {multiply}");
                //Console.ReadKey();

                // 16.17

                //Console.Write("Введите n: ");
                //int n = int.Parse(Console.ReadLine());

                //long factorial = 1;
                //int i = 1;
                //while (i <= n)
                //{
                //    factorial *= i;
                //    i++;
                //}

                //Console.WriteLine(factorial);
                //Console.ReadKey();

            }
    }
}
