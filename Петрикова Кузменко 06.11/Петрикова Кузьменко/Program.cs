using System;

namespace Петрикова_Кузьменко
{
    class Program
    {
        static void Main(string[] args)
        {
            // Теория типы данных

            //int numbers; // Создание переменной с целыми числами
            //куда = что, где "=" оператор присвоения.

            //numbers = 17;
            //int numbers = 17; // можно сразу объявить и присвоить начальное значение

            //Console.WriteLine(numbers); // выведет в консоль число 17
            //int b = numbers * 5; // создаст новую целую переменную b с присвоением 17 * 5
            //Console.WriteLine(b); // выведет в консоль число 85

            //numbers = numbers + 8;
            //Console.WriteLine(numbers); //выведет в консоль 25


            //int     -целое число от -2147483648 до 2147483647
            //long    -целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807
            //string -текстовая строка
            //double -число с дробной частью
            //char    -символ
            //bool    -логичекий тип, принимает только два значения: true или false


            //string name = "Serg";
            //int age = 35;
            //double weight = 95.5;
            //bool isITMan = true;
            //string aboutMe = name + ",возраст" + age + ",вес" + weight + ",программист?" + isITMan;
            //Console.WriteLine(aboutMe);


            //int numberOne = 17, numberTwo = 10; // объявляем и сразу инициализируем целые 
            //Console.WriteLine(numberOne + numberTwo); //27
            //string stringOne = "17", stringTwo = "10"; // объявляем и сразу инициализируем строки 
            //Console.WriteLine(s1 + s2); // 1710


            //Теория ввод информации и конвертация

            //string input = Console.ReadLine();


            //Console.Write("Привет! Как тебя зовут?");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Рад с тобой познакомиться," + userName);


            //string input = Console.ReadLine();
            //int numbers = Convert.ToInt32(s);


            //int a = Convert.ToInt32(Console.ReadLine());


            //string input = Console.ReadLine(); // ввод строки
            //int number = Convert.ToInt32(input); // целое число
            //double real = Convert.ToDouble(input); //вещественное число 
            //char character = Convert.ToChar(input); // в символ
            //bool bollean = Convert.ToBoolean(input); // в логический тип данных


            //int numberOne = Convert.ToInt32(Console.ReadLine()); // ввели первое число
            //int numberTwo = Convert.ToInt32(Console.ReadLine()); // ввели второе число
            //int summa = numberOne + numberTwo; // посчитали сумму и записали в "c"
            //Console.WriteLine(summa); //вывели значение переменной "c"


            //Console.WriteLine(numberOne + numberTwo);


            //string input = Console.ReadLine(); // ввод строки
            //int number = int.Parse(input); // целое число
            //double real = double.Parse(input); // вещественное число
            //char character = char.Parse(input); // в символ
            //bool boolean = bool.Parse(input); // в логическое значение 

            // Задание 1.1

            Console.WriteLine(43 + 29);
            Console.WriteLine(72 - 0);
            Console.WriteLine(36 * 2);
            Console.WriteLine(144 / 2);

            // Задание 1.2

            int number = 69;
            Console.WriteLine("Мое любимое число: " + number);

            // Задание 1.3

            int a = 8;
            int b = 6;
            int c = 2;
            int formula = (a + b) / c;
            Console.WriteLine(formula);

            // Задание 1.4

            int digitOne = Convert.ToInt32(1); // ввели первое число
            int digitrTwo = Convert.ToInt32(5); // ввели второе число
            int digitThree = Convert.ToInt32(3); // посчитали сумму и записали в "c"
            Console.WriteLine(digitOne + " " + digitrTwo + " " + digitThree);

            // Задание 1.5

            string MyPerson = "Valeria Kuzmenko\nElizaveta Petrikova";
            Console.WriteLine(MyPerson);

            // Задание 3.1


            Console.Write("Введите сторону квадрата: ");
            int storona = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Квадрат числа:" + storona * storona);

            // Задание 3.2

            Console.Write("Введите построчно два числа для перестановки: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Значения после перестановки: " + r + " " + d);







        }

    }
}
