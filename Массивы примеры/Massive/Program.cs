using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Способы создания одномерных массивов

            int[] MyArray = new int[2];

            short[] MyArray2 = new short[5];
            short[] MyArray3 = new short[5] { 9, 2, 6, 1, 5 };
            short[] MyArray4 = new short[] { 9, 2, 6, 1, 5 };
            short[] MyArray5 = new short[5];
            short[] MyArray6 = { 9, 2, 6, 1, 5 };

            // Cоздание массива при моменте задания явных значений  задает массив

            //

            short[] MyArray7 = new short[5];

            myArray7[0] = 10;
            myArray7[1] = 20;
            myArray7[2] = 30;
            myArray7[3] = 40;
            myArray7[4] = 50;

            Console.WriteLine(myArray7[0]);
            Console.WriteLine(myArray7[1]);
            Console.WriteLine(myArray7[2]);
            Console.WriteLine(myArray7[3]);
            Console.WriteLine(myArray7[4]);

            //

            int[] myArray = new int[1000];

            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = i * i;
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            //

            int count = 0;

            int[] myArray8 = new int[1000];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i * i;
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 5 == 0) count++;
            }
            Console.WriteLine(count);

            Console.ReadLine();

            // Опишите массив типа int на 50 элементов.Заполните массив четными числами, начиная с двойки.

            int[] Mass = new int[50]; // массив на 50 элементов
            for (int i = 0; i < Mass.Length; i++)
            {
                // Добавляем 1, так как счетчик начат с нуля
                Mass[i] = 2 * (i + 1);
                Console.WriteLine(Mass[i]);
            }
            Console.ReadKey();


            // Выводит все эелменты массива

            int[] array = { 0, 1, 3, 4, 5, 2, 1, -4, -1, 10, 55 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            // Выводит все элементы массива в обратном порядке.

            int[] array2 = { 0, 1, 3, 4, 5, 2, 1, -4, -1, 10, 55 };

            for (int i = array.Length - 1; i >= 0; i--) // меняем только эту строчку
            {
                Console.WriteLine(array[i]);
            }

            // Выводит чётные элементы массива.

            int[] array3 = { 0, 1, 3, 4, 5, 2, 1, -4, -1, 10, 55 };

            for (int i = 0; i < array.Length; i++)
            {
                int element = array[i];

                if (element % 2 == 0)
                {
                    Console.WriteLine(element);

                }
            }

            // Выводит все элементы массива через 1.

            int[] array4 = { 0, 1, 3, 4, 5, 2, 1, -4, -1, 10, 55 };

            for (int i = 0; i < array.Length; i += 2)
            {
                Console.WriteLine(array[i]);
            }

            // Выводит все элементы массива пока не встретится элемент -1.

            int[] array5 = { 0, 1, 3, 4, 5, 2, 1, -4, -1, 10, 55 };

            for (int i = 0; i < array.Length; i++)
            {
                int element = array[i];

                if (element == -1)
                    break;

                Console.WriteLine(element);
            }

            // Найти количество положительных и сумму нечетных элементов массива B[10].

            int[] B = { 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };

            //Кол-во положительных элементов массива
            var posNums = B.Where(n => n > 0);
            Console.WriteLine(posNums.LongCount());

            //Сумма нечетных элементов массва
            var oddNums = B.Where(t => t % 2 != 0);
            Console.WriteLine(oddNums.Sum());
            Console.ReadLine();


            // Найти сумму положительных и количество нечетных элементов массива А[10]

            int[] A = { 1, 2, 3, 4, 5, 6, 7, -8, -9, -10 };

            //Сумма положительных элементов массива
            var posNums2 = A.Where(n => n > 0);
            Console.WriteLine(posNums.Sum());

            //Кол-во нечетных элементов массива
            var oddNums2 = A.Where(t => t % 2 != 0);
            Console.WriteLine(oddNums.LongCount());
            Console.ReadLine();


            // Вычислить среднее арифметическое элементов массива Т[15], удовлетворяющих условию 5 ≤ T[i] ≤ 15.

            int[] T = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //Среднее арифметическое элементов от 5 до 15
            var iAver = T.Where(n => n >= 5 && n <= 15);
            Console.WriteLine(iAver.Average());
            Console.ReadLine();


            // Вычислить среднее геометрическое четных и сумму нечетных элементов массива С[10].

            int[] C = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double Mul = 1.0;

            //Среднее геометрическое четных элементов
            var iEven = C.Where(n => n % 2 == 0);
            foreach (int i in iEven)
                Mul *= i;

            double averGeom = Math.Pow(Mul, 1.0 / iEven.LongCount());
            Console.WriteLine(averGeom);

            //Сумма нечетных элементов массива
            var oddNums3 = C.Where(t => t % 2 != 0);
            Console.WriteLine(oddNums.Sum());

            Console.ReadLine();

        }
    }
      
}
