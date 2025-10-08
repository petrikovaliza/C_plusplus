using System;

namespace Петрикова_Кузьменко_07._11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Теория

            //Все операции с числами делятся на унарные и бинарные.

            // Унарные
            //int numOne = 0, numTwo = 5;
            //numOne++; // numOne = 1
            //numTwo--; // numTwo = 4
            //numTwo = --numTwo + numOne; //numTwo = 3 + 1 = 4
            //numOne = ++numOne - numTwo; // numOne = 2 - 4 = -2

            //numOne = ++numTwo // сначала увеличивается значение nT на единицу и потом присвается переменной nO
            //numOne = numTwo++ // сначала присваивается переменной nO значение переменной nT и следом переменная nT уже увеличивается на единицу


            //int num1 = 18;
            //int num2 = 8;
            //Console.WriteLine("первое число = " + num1 + ",второе число=" + num2);
            //int result = num1 + num2;
            //Console.WriteLine("сложение:\t\t" + num1 + "+" + num2 + "=" + result); //26
            //result = num1 * num2;
            //Console.WriteLine("умножение: \t\t" + num1 + "*" + num2 + "=" + result); //144
            //result = num1 / num2;
            //Console.WriteLine("деление нацело: \t" + num1 + "/" + num2 + "=" + result); //2
            //result = num1 % num2;
            //Console.WriteLine("деление с остатком: \t" + num1 + "%" + num2 + "=" + result); //2
            //Console.ReadKey();

            //\t — это управляющий символ, который вставляет табуляцию(8 символов пробела) в тексте.


            // Задание 1

            //Console.Write("Введите три числа: ");
            //int a = Convert.ToInt32(Console.ReadLine()); 
            //int b = Convert.ToInt32(Console.ReadLine()); 
            //int c = Convert.ToInt32(Console.ReadLine());
            //int summa = (a + b + c);
            //int multi = (a * b * c);
            //Console.WriteLine("Сложение: "  + summa + "\nПроизведение: " + multi);

            // Задание 2

            //Console.Write("Введите два числа: ");
            //int shkolniki = Convert.ToInt32(Console.ReadLine());
            //int yabloki = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(yabloki / shkolniki + " - cтолько яблок достанется школьникам");

            // Задание 3

            //Console.Write("Введите два числа: ");
            //int shkolniki = Convert.ToInt32(Console.ReadLine());
            //int yabloki = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(yabloki % shkolniki + " - останется в корзине");

            // Задание 4 

            //Console.Write("Введите рубли, копейки и кол-во пирожков: ");
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine()); 
            //double c = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine((a * c) +  (b * c / 100) + " -  стоимость пирожков");

            // Задание 5

            //Console.Write("Введите число x: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int r = x * x;
            //int y = r * x;
            //int u = y * y;
            //Console.WriteLine(u);

            // Задание 6

            //Console.Write("Введите сторону квадрата: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int P = a * 4;
            //Console.WriteLine("Периметр - " + P);

            // Задание 7

            //int x = Convert.ToInt32(Console.ReadLine());
            //int r2 = x * x;
            //int y4 = r2 * r2;
            //Console.WriteLine(y4);

            //int x = Convert.ToInt32(Console.ReadLine());
            //int r2 = x * x;
            //int y3 = r2 * x;
            //int u6 = y3 * y3;
            //Console.WriteLine(u6);

            //int x = Convert.ToInt32(Console.ReadLine());
            //int r2 = x * x;
            //int y3 = r2 * x;
            //int u6 = y3 * y3;
            //int e7 = u6 * x;
            //Console.WriteLine(e7);

            //int x = Convert.ToInt32(Console.ReadLine());
            //int r2 = x * x;
            //int y4 = r2 * r2;
            //int u8 = y4 * y4;
            //Console.WriteLine(u8);

            //int x = Convert.ToInt32(Console.ReadLine());
            //int r2 = x * x;
            //int y4 = r2 * r2;
            //int u8 = y4 * y4;
            //int i9 = u8 * x;
            //Console.WriteLine(i9);

            //int x = Convert.ToInt32(Console.ReadLine());
            //int r2 = x * x;
            //int y4 = r2 * r2;
            //int u8 = y4 * y4;
            //int i10 = u8 * r2;
            //Console.WriteLine(i10);

            //int x = Convert.ToInt32(Console.ReadLine());
            //int r2 = x * x;
            //int y4 = r2 * r2;
            //int u8 = y4 * y4;
            //int i9 = u8 * x;
            //int h13 = i9 * y4;
            //Console.WriteLine(h13);

            //int x = Convert.ToInt32(Console.ReadLine());
            //int r2 = x * x;
            //int y3 = r2 * x;
            //int i5 = r2 * y3;
            //int j15 = i5 * y3;
            //Console.WriteLine(j15);

            //int x = Convert.ToInt32(Console.ReadLine());
            //int r2 = x * x;
            //int y3 = r2 * x;
            //int i5 = r2 * y3;
            //int p6 = i5 * x;
            //int j15 = i5 * y3;
            //int e21 = j15 * p6;
            //Console.WriteLine(e21);

            //int x = Convert.ToInt32(Console.ReadLine());
            //int r2 = x * x;
            //int i4 = r2 * r2;
            //int p8 = i4 * i4;
            //int j16 = p8 * p8;
            //int e24 = j16 * p8;
            //int q28 = e24 * i4;
            //Console.WriteLine(q28);

            //int x = Convert.ToInt32(Console.ReadLine());
            //int r2 = x * x;
            //int i4 = r2 * r2;
            //int p8 = i4 * i4;
            //int j16 = p8 * p8;
            //int e32 = j16 * j16;
            //int q64 = e32 * e32;
            //Console.WriteLine(q64);

            // Задание 8 

            //int a = 2;
            //int b = 8;
            //int c = 6;
            //b = c;
            //a = b;
            //c = a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //int a = 9;
            //int b = 2;
            //int c = 4;
            //b = a;
            //a = c;
            //c = b;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            // Задание 9

            //int dlinaRebra = 3;
            //int V = dlinaRebra * dlinaRebra * dlinaRebra;
            //int S = 6 * dlinaRebra * dlinaRebra;
            //Console.WriteLine("Объем: " + V + ", Площадь: " + S);

            // Задание 10

            //int priceApple = 129;
            //int priceCookies = 350;
            //int priceCandies = 499;

            //int kgApple = 3;
            //int kgCookies = 2;
            //int kgCandies = 1;
            //int stoimostVsya = priceApple * kgApple + priceCookies * kgCookies + priceCandies * kgCandies;
            //Console.WriteLine("Стоимость всей покупки: " + stoimostVsya);

            // Задание 11

            //Console.WriteLine("Введите два числа: :");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int summa = num1 + num2;
            //int sub = num1 - num2;
            //int multi = num1 * num2;
            //int div = num1 / num2;
            //Console.WriteLine("Cумма " + summa + "\nРазность " + sub + "\nПроизведение " + multi + "\nДеление " + div);

            // Задание 12

            //Console.WriteLine("Введите кол-во лет, месяцев, недель: ");
            //int year = Convert.ToInt32(Console.ReadLine());
            //int month = Convert.ToInt32(Console.ReadLine());
            //int week = Convert.ToInt32(Console.ReadLine());
            //int days = year * 365 + month * 30 + week * 7;
            //Console.WriteLine("Получилось: "+ days + " дней");

            // Задание 13

            //int С = 26;
            //int F = С * (9 / 5) + 32;
            //double K = С + 273.15;
            //Console.WriteLine("Фаренгейты:  " + F + "\nКельвины: " + K);

            // Задание 14

            //Console.WriteLine("Введите количество секунд с начала суток: ");
            //int sec = Convert.ToInt32(Console.ReadLine());
            //int hour = sec / 3600;
            //int min = (sec % 3600) / 60;
            //int secmin = (sec % 3600) % 60;
            //Console.WriteLine("Полные часы с начала суток: " + hour + "\nПолных минут с начала часа: " + min + "\nПолных cекунд с начала минуты " + secmin);

            // Задание 15

            //int S1 = 543 * 130; 
            //int S2 = 130 * 130; 
            //int countKvad = S1 / S2;
            //Console.WriteLine(countKvad);











        }
    }
}
