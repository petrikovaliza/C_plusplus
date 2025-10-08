using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace massiveL11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 11.1  Задан массив Х = (х1 , х2 , …, хn ). Найти суммы положительных, отрицательных элементов массива и их количество. 

            int[] X = { -5, 10, -7, 0, 12, -8 };

            int sumPositive = 0;
            int countPositive = 0;

            int sumNegative = 0;
            int countNegative = 0;

            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] > 0)
                {
                    sumPositive += X[i];
                    countPositive++;
                }
                else if (X[i] < 0)
                {
                    sumNegative += X[i];
                    countNegative++;
                }
            }

            Console.WriteLine("Сумма положительных элементов: " + sumPositive);
            Console.WriteLine("Количество положительных элементов: " + countPositive);
            Console.WriteLine("Сумма отрицательных элементов: " + sumNegative);
            Console.WriteLine("Количество отрицательных элементов: " + countNegative);
            Console.ReadKey();

            // 11.2 Задан массив оценок, полученных студентами одной группы за экзамен. Найти: 1) количество пятерок, четверок, троек, двоек; 2) процент успеваемости группы; 3) процент повышенных оценок.

            int[] grades = { 5, 4, 3, 2, 5, 4, 3, 2, 5, 4, 3, 2, 5, 4, 3, 2 };

            int fivesCount = 0;
            int foursCount = 0;
            int threesCount = 0;
            int twosCount = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] == 5)
                    fivesCount++;
                else if (grades[i] == 4)
                    foursCount++;
                else if (grades[i] == 3)
                    threesCount++;
                else if (grades[i] == 2)
                    twosCount++;
            }

            int totalGrades = grades.Length;

            double successRate = ((double)(fivesCount + foursCount) / totalGrades) * 100;

            double highGradePercentage = ((double)(fivesCount + foursCount) / totalGrades) * 100;

            Console.WriteLine($"Пятерок: {fivesCount}");
            Console.WriteLine($"Четверок: {foursCount}");
            Console.WriteLine($"Троек: {threesCount}");
            Console.WriteLine($"Двоек: {twosCount}");
            Console.WriteLine($"Процент успеваемости: {successRate:F2}%");
            Console.WriteLine($"Процент повышенных оценок: {highGradePercentage:F2}%");
            Console.ReadKey();

            // 11.3

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            double sumOdd = 0;
            double productOdd = 1;
            int countOdd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    sumOdd += numbers[i];
                    productOdd *= numbers[i];
                    countOdd++;
                }
            }

            double arithmeticMean = sumOdd / countOdd;

            double geometricMean = Math.Pow(productOdd, 1.0 / countOdd);

            Console.WriteLine("Среднее арифметическое нечетных чисел: " + arithmeticMean);
            Console.WriteLine("Среднее геометрическое нечетных чисел: " + geometricMean);
            Console.ReadKey();

            // 11.4 Ввести массив A = (a1, a2, …, an). Просматривая его элементы слева направо, заменить в нем каждый нулевой элемент полусуммой последующего и предыдущего. Если a1 = 0, заменить его на a2, если an = 0, заменить его на an−1.

            int[] A = { 0, 2, 0, 4, 0, 6, 0 };

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    if (i == 0)
                    {
                        A[i] = A[i + 1];
                    }
                    else if (i == A.Length - 1)
                    {
                        A[i] = A[i - 1];
                    }
                    else
                    {
                        A[i] = (A[i - 1] + A[i + 1]) / 2;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", A));
            Console.ReadKey();


            // 11.5 Задан целочисленный массив из 150 элементов. Выделить в отдельный массив все его элементы, кратные 5.

            int[] array5 = new int[150];
            Random random = new Random();

            for (int i = 0; i < array5.Length; i++)
            {
                array5[i] = random.Next(101);
            }

            List<int> resultList = new List<int>();

            for (int i = 0; i < array5.Length; i++)
            {
                if (array5[i] % 5 == 0)
                {
                    resultList.Add(array5[i]);
                }
            }

            Console.WriteLine("Элементы, кратные 5:");

            for (int k = 0; k < resultList.Count; k++)
            {
                Console.Write(resultList[k] + " ");
            }

            Console.ReadKey();
            
        }
    }
}   

    
