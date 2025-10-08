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
            // 13.1

            //Console.WriteLine("Введите номер месяца от 1 до 12");
            //int month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 1: Console.Write("Январь"); break;
            //    case 2: Console.Write("Февраль"); break;
            //    case 3: Console.Write("Март"); break;
            //    case 4: Console.Write("Апрель"); break;
            //    case 5: Console.Write("Май"); break;
            //    case 6: Console.Write("Июнь"); break;
            //    case 7: Console.Write("Июль"); break;
            //    case 8: Console.Write("Август"); break;
            //    case 9: Console.Write("Сентябрь"); break;
            //    case 10: Console.Write("Октябрь"); break;
            //    case 11: Console.Write("Ноябрь"); break;
            //    case 12: Console.Write("Декабрь"); break;
            //    default: Console.Write("Нужно ввести только от 1 до 12"); break;
            //}
            //Console.ReadKey();

            // 13.2

            //int a = 10;
            //int b = 5;
            //int c = 3;
            //int d = 2;
            //int e = 1;
            //int tableArea = a * b;
            //int rectArea = c * d * e;
            //int count = 0;

            //switch (tableArea >= rectArea)
            //{
            //    case true:
            //        while (a >= c && b >= d && b >= e)
            //        {
            //            int maxRows = b / d;
            //            int maxCols = a / c;
            //            int maxCount = maxRows * maxCols;
            //            count += maxCount;
            //            a -= maxCols * c;
            //            b -= maxRows * d;
            //        }
            //        Console.WriteLine("Количество размещенных прямоугольников: " + count);
            //        break;
            //    case false:
            //        Console.WriteLine("Прямоугольник слишком большой для стола");
            //        break;
            //}

            //Console.ReadKey();

            // 13.3

            //Console.Write("Введите значение a2(число десятков): ");
            //int numDes = int.Parse(Console.ReadLine());

            //Console.Write("Введите значение a1(число единиц): ");
            //int numEd = int.Parse(Console.ReadLine());

            //Console.Write("Введите значение b(однозначного числа): ");
            //int odnoznachNum = int.Parse(Console.ReadLine());
            //int twoZnach = numDes * 10 + numEd;
            //int result = twoZnach - odnoznachNum;
            //int resultDes = result / 10;
            //int resultEd = result % 10;

            //Console.WriteLine($"Цифры числа {result}:");
            //switch (resultDes)
            //{
            //    case 0:
            //        Console.WriteLine("0");
            //        break;
            //    case 1:
            //        Console.WriteLine("1");
            //        break;
            //    case 2:
            //        Console.WriteLine("2");
            //        break;
            //    case 3:
            //        Console.WriteLine("3");
            //        break;
            //    case 4:
            //        Console.WriteLine("4");
            //        break;
            //    case 5:
            //        Console.WriteLine("5");
            //        break;
            //    case 6:
            //        Console.WriteLine("6");
            //        break;
            //    case 7:
            //        Console.WriteLine("7");
            //        break;
            //    case 8:
            //        Console.WriteLine("8");
            //        break;
            //    case 9:
            //        Console.WriteLine("9");
            //        break;
            //}

            //switch (resultEd)
            //{
            //    case 0:
            //        Console.WriteLine("0");
            //        break;
            //    case 1:
            //        Console.WriteLine("1");
            //        break;
            //    case 2:
            //        Console.WriteLine("2");
            //        break;
            //    case 3:
            //        Console.WriteLine("3");
            //        break;
            //    case 4:
            //        Console.WriteLine("4");
            //        break;
            //    case 5:
            //        Console.WriteLine("5");
            //        break;
            //    case 6:
            //        Console.WriteLine("6");
            //        break;
            //    case 7:
            //        Console.WriteLine("7");
            //        break;
            //    case 8:
            //        Console.WriteLine("8");
            //        break;
            //    case 9:
            //        Console.WriteLine("0");
            //        break;
            //}

            //Console.ReadKey();

            // 13.4

            //Console.Write("Введите целое число k от 1 до 365(день года): ");
            //int day = int.Parse(Console.ReadLine());
            //int dayOfWeek = (day % 7);

            //switch (dayOfWeek)
            //{
            //    case 0:
            //        Console.WriteLine("Выходной день");
            //        break;
            //    case 6:
            //        Console.WriteLine("Выходной день");
            //        break;
            //    default:
            //        Console.WriteLine("Рабочий день");
            //        break;
            //}

            //Console.ReadKey();

            // 13.5

            //Console.Write("Введите целое число n от 1 до 99 (возраст в годах): ");
            //int age = int.Parse(Console.ReadLine());
            //string okonchanie;
            //switch (age % 10)
            //{
            //    case 1 when age != 11:
            //        okonchanie = " год";
            //        break;
            //    case 2:
            //    case 3:
            //    case 4 when age != 12 && age != 13 && age != 14:
            //        okonchanie = " года";
            //        break;
            //    default:
            //        okonchanie = " лет";
            //        break;
            //}

            //Console.WriteLine($"Мне {age}{okonchanie}.");
            //Console.ReadKey();

            // 13.6

            //Console.Write("Введите целое число k (кол-во грибов: ");
            //int kolGrib = int.Parse(Console.ReadLine());
            //string okonchanie;
            //switch (kolGrib % 100)
            //{
            //    case 11:
            //    case 12:
            //    case 13:
            //    case 14:
            //        okonchanie = "грибов";
            //        break;
            //    case 1:
            //        okonchanie = "гриб";
            //        break;
            //    case 2:
            //    case 3:
            //    case 4:
            //        okonchanie = "гриба";
            //        break;
            //    default:
            //        okonchanie = "грибов";
            //        break;
            //}

            //Console.WriteLine($"Мы нашли {kolGrib}{okonchanie} в лесу.");
            //Console.ReadKey();

            // 13.7

            //Console.Write("Введите стоимость товара в копейках (1–9999): ");
            //int priceKop = int.Parse(Console.ReadLine());
            //int rub = priceKop / 100;
            //int kop = priceKop % 100;

            //string rubOkonchanie;
            //switch (rub % 10)
            //{
            //    case 1 when rub != 11:
            //        rubOkonchanie = "рубль";
            //        break;
            //    case 2:
            //    case 3:
            //    case 4 when rub != 12 && rub != 13 && rub != 14:
            //        rubOkonchanie = "рубля";
            //        break;
            //    default:
            //        rubOkonchanie = "рублей";
            //        break;
            //}

            //string kopOkonchanie;
            //switch (kop % 10)
            //{
            //    case 1 when kop != 11:
            //        kopOkonchanie = "копейка";
            //        break;
            //    case 2:
            //    case 3:
            //    case 4 when kop != 12 && kop != 13 && kop != 14:
            //        kopOkonchanie = "копейки";
            //        break;
            //    default:
            //        kopOkonchanie = "копеек";
            //        break;
            //}

            //Console.WriteLine($"{rub} {rubOkonchanie} {kop} {kopOkonchanie}");
            //Console.ReadKey();

            // 13.8

            //Console.Write("Введите возраст в месяцах (1–1188): ");
            //int months = int.Parse(Console.ReadLine());
            //int years = months / 12;
            //int ostatokMonths = months % 12;

            //string yearOkonchanie;
            //switch (years % 10)
            //{
            //    case 1 when years != 11:
            //        yearOkonchanie = "год";
            //        break;
            //    case 2:
            //    case 3:
            //    case 4 when years != 12 && years != 13 && years != 14:
            //        yearOkonchanie = "года";
            //        break;
            //    default:
            //        yearOkonchanie = "лет";
            //        break;
            //}

            //string monthOkonchanie;
            //switch (ostatokMonths % 10)
            //{
            //    case 1 when ostatokMonths != 11:
            //        monthOkonchanie = "месяц";
            //        break;
            //    case 2:
            //    case 3:
            //    case 4 when ostatokMonths != 12 && ostatokMonths != 13 && ostatokMonths != 14:
            //        monthOkonchanie = "месяца";
            //        break;
            //    default:
            //        monthOkonchanie = "месяцев";
            //        break;
            //}

            //if (years == 0)
            //{
            //    Console.WriteLine($"{ostatokMonths} {monthOkonchanie}");
            //}
            //else
            //{
            //    Console.WriteLine($"{years} {yearOkonchanie} {ostatokMonths} {monthOkonchanie}");

            //}

            //Console.ReadKey();

            // 13.9

            //int a = 8;
            //int b = 4;
            //int c = 2;
            //int d = 5;

            //if ((a + b) % 2 == (c + d) % 2)
            //{
            //    Console.WriteLine("Поля (a, b) и (c, d) находятся на одном цвете.");
            //}
            //else
            //{
            //    Console.WriteLine("Поля (a, b) и (c, d) находятся на разных цветах.");
            //}

            //Console.ReadKey();

        }
            
    }    
}   
