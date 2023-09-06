using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - a
            bool flag = false; //true , false
            byte bit = 0; // 0-256, Беззнаковое 8 - битное целое число
            sbyte bit1 = 33; // -128 -127 , 8-битное целое число со знаком
            char liter = 'B'; // символ Юникода UTF-16 , 16
            decimal stok = 3456.65465754m; //тип с плавающей запятой , точность 28-29 цифр , 16 байт
            double stok1 = 54.43434d;//тип с плавающей запятой , 15-17 цифр, 8 байт
            float stok2 = 23.43254f;//тип с плавающ запятоу , 6-9 цифр, 4байт
            int a = 5; //32-битное целое число со знаком
            uint b = 4; //Беззнаковое 32-битное целое число
            nint c = -6; //32-битное или 64-битное целое число со знаком.
            nuint d = 8; //Беззнаковое 32-битное или 64-битное целое число
            long f = 546; //64-битное целое число со знаком
            ulong g = 34574957349573;// 	Беззнаковое 64-битное целое число
            short m = 10; //16 - битное целое число со знаком
            ushort j = 323; //Беззнаковое 16-битное целое число


            Console.WriteLine("flag: " + flag);
            Console.WriteLine("bit: " + bit);
            Console.WriteLine("bit1: " + bit1);
            Console.WriteLine("liter: " + liter);
            Console.WriteLine("stok: " + stok);
            Console.WriteLine("stok1: " + stok1);
            Console.WriteLine("stok2: " + stok2);
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("c: " + c);
            Console.WriteLine("d: " + d);
            Console.WriteLine("f: " + f);
            Console.WriteLine("g: " + g);
            Console.WriteLine("m: " + m);
            Console.WriteLine("j: " + j);

            // 1 - b 
            //явное привеление
            double x = 3.14;
            int y = (int)x;

            long a1 = 1000;
            short b1 = (short)a1;

            decimal c1 = 12.345m;
            float d1 = (float)c1;

            byte e = 65;
            char f1 = (char)e;

            nint g1 = -10;
            int h = (int)g1;

            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            Console.WriteLine("a1: " + a1);
            Console.WriteLine("b1: " + b1);
            Console.WriteLine("c1: " + c1);
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("e: " + e);
            Console.WriteLine("f1: " + f1);
            Console.WriteLine("g1: " + g1);
            Console.WriteLine("h: " + h);

            //неявное приведение 
            int i = 100;
            long j1 = i;

            float k = 3.14f;
            double l = k;

            short m1 = 1000;
            int n = m1;

            byte o = 255;
            int p = o;

            char q = 'A';
            int r = q;

            Console.WriteLine("i: " + i);
            Console.WriteLine("j1: " + j1);
            Console.WriteLine("k: " + k);
            Console.WriteLine("l: " + l);
            Console.WriteLine("m1: " + m1);
            Console.WriteLine("n: " + n);
            Console.WriteLine("o: " + o);
            Console.WriteLine("p: " + p);
            Console.WriteLine("q: " + q);
            Console.WriteLine("r: " + r);

            byte e1 = 65;
            char i1 = Convert.ToChar(e1);

            Console.WriteLine(e1);
            Console.WriteLine(i1);

            //1 - c
            //упаковка и распоковка
            int x2 = 254;
            Object obj = x2;
            x2 = (int)obj;

            Console.WriteLine(x2);

            //1 - d

            var P = 3.14; // неявно типизированная переменная x будет иметь тип double
            var z = 100; // неявно типизированная переменная y будет иметь тип int

            Console.WriteLine("z: " + P);
            Console.WriteLine("z: " + z);

            //1 - e
            //nullable (?) позволяет присваевать null любому типу данных
            float? nullableFloat = null; // nullable переменная типа float, присвоена null
            Console.WriteLine(nullableFloat);

            //1 - f
            var variable = "Hello"; // неявно типизированная переменная типа string

            //variable = 123; // ОШИБКА: Попытка присвоить переменной типа string значение типа int
            Console.WriteLine(variable);

            //2

            string str1 = "Hello, world!"; // Объявление строки с помощью строкового литерала
            string str2 = "Hello!"; // Объявление другой строки с помощью строкового литерала

            // Сравнение строковых литералов
            bool Equal = (str1 == str2); // Сравнение двух строковых литералов

            Console.WriteLine("str1: " + str1);
            Console.WriteLine("str2: " + str2);
            Console.WriteLine("Equal: " + Equal);

            string str3 = "Hello";
            string str4 = "world";
            string str5 = "!";

            // Сцепление строк
            string result1 = str1 + " " + str4 + str5;
            Console.WriteLine("Сцепление строк: " + result1);

            // Копирование строки
            string copy = String.Copy(str3);
            Console.WriteLine("Копия строки: " + copy);

            // Выделение подстроки
            string substring = str3.Substring(0, 3);
            Console.WriteLine("Подстрока: " + substring);

            // Разделение строки на слова
            string sentence = "This is a sentence.";
            string[] words = sentence.Split(' ');
            Console.WriteLine("Разделение строки на слова:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // Вставка подстроки в заданную позицию
            string original = "Hello world!";
            string inserted = "beautiful ";
            int position = 6;
            string modified = original.Insert(position, inserted);
            Console.WriteLine("Вставка подстроки: " + modified);

            // Удаление заданной подстроки
            string phrase = "I don't like apples.";
            string removed = phrase.Remove(10, 5);
            Console.WriteLine("Удаление подстроки: " + removed);

            //интерполяция строк
            string name = "Alice";
            int age = 30;

            string message = $"Hello, {name}! You are {age} years old.";

            Console.WriteLine(message);

            string emptyString = string.Empty; // Создание пустой строки
            string nullString = null; // Создание строки со значением null

            // Использование метода string.IsNullOrEmpty
            bool isEmptyOrNull1 = string.IsNullOrEmpty(emptyString); // Проверка, является ли строка пустой или null
            bool isEmptyOrNull2 = string.IsNullOrEmpty(nullString); // Проверка, является ли строка пустой или null

            Console.WriteLine("Empty string is empty or null: " + isEmptyOrNull1);
            Console.WriteLine("Null string is empty or null: " + isEmptyOrNull2);

            // Некоторые другие операции с пустыми и null строками
            string concatenated = emptyString + "Hello"; // Сцепление пустой строки с другой строкой
            string trimmed = emptyString.Trim(); // Удаление начальных и конечных пробелов из пустой строки
            int length = (nullString ?? string.Empty).Length; // Получение длины строки или 0, если она равна null

            Console.WriteLine("Concatenated string: " + concatenated);
            Console.WriteLine("Trimmed empty string: " + trimmed);
            Console.WriteLine("Length of null string: " + length);

            StringBuilder stringBuilder = new StringBuilder("Hello, world!");

            // Удаление определенных позиций
            stringBuilder.Remove(7, 6);

            // Добавление символов в начало строки
            stringBuilder.Insert(0, "Hi, ");

            // Добавление символов в конец строки
            stringBuilder.Append(" Welcome!");

            string result = stringBuilder.ToString();
            Console.WriteLine(result);

            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            int rows = 3;
            int columns = 3;

            // Выводим массив на консоль
            for (int v = 0; v < rows; v++)
            {
                for (int v1 = 0; v1 < columns; v1++)
                {
                    Console.Write(matrix[v, v1] + "\t");
                }
                Console.WriteLine();
            }

            {
                // Создаем одномерный массив строк
                string[] array2 = { "apple", "banana", "cherry", "date" };

                // Выводим содержимое массива
                Console.WriteLine("Исходное содержимое массива:");
                PrintArray(array2);

                // Выводим длину массива
                Console.WriteLine("Длина массива: " + array2.Length);

                // Запрашиваем позицию и новое значение элемента для изменения
                Console.Write("Введите позицию элемента для изменения (от 0 до " + (array2.Length - 1) + "): ");
                int position1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите новое значение элемента: ");
                string newValue = Console.ReadLine();

                // Изменяем элемент массива
                array2[position1] = newValue;

                // Выводим обновленное содержимое массива
                Console.WriteLine("Обновленное содержимое массива:");
                PrintArray(array2);
            }

            static void PrintArray(string[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("Элемент[" + i + "]: " + array[i]);
                }
            }

            // Создаем ступенчатый массив
            double[][] array = new double[3][];

            // Вводим значения массива с консоли
            for (int i3 = 0; i3 < array.Length; i3++)
            {
                Console.Write("Введите количество столбцов для строки " + (i3 + 1) + ": ");
                int columns2 = Convert.ToInt32(Console.ReadLine());

                array[i3] = new double[columns2];

                for (int j3 = 0; j3 < columns2; j3++)
                {
                    Console.Write("Введите значение для элемента [" + i3 + ", " + j3 + "]: ");
                    array[i3][j3] = Convert.ToDouble(Console.ReadLine());
                }
            }

            // Выводим содержимое массива
            Console.WriteLine("Содержимое массива:");

            for (int i3 = 0; i3 < array.Length; i3++)
            {
                for (int j3 = 0; j3 < array[i3].Length; j3++)
                {
                    Console.Write(array[i3][j3] + "\t");
                }
                Console.WriteLine();
            }

            var array3 = new[] { 1, 2, 3, 4, 5 }; // Неявно типизированная переменная для массива

            var str = "Пример строки"; // Неявно типизированная переменная для строки

            // Вывод строки в консоль
            Console.WriteLine("Значение строки: " + str);


            //4 - создание кортежа

            var tuple = (42, "Hello", 'A', "World", 123456789UL);

            //4 - 2

            var tuple1 = (42, "Hello", 'A', "World", 123456789UL);

            // Вывод кортежа целиком
            Console.WriteLine("Кортеж целиком: " + tuple);

            // Вывод выборочных элементов кортежа
            Console.WriteLine("Первый элемент: " + tuple.Item1);
            Console.WriteLine("Третий элемент: " + tuple.Item3);
            Console.WriteLine("Четвертый элемент: " + tuple.Item4);

            var tuple2 = (42, "Hello", 'A', "World", 123456789UL);

            // Распаковка кортежа с явным указанием типов переменных
            (int number, string greeting, char letter, string world, ulong bigNumber) = tuple;
            Console.WriteLine("Распаковка с явным указанием типов:");
            Console.WriteLine(number);
            Console.WriteLine(greeting);
            Console.WriteLine(letter);
            Console.WriteLine(world);
            Console.WriteLine(bigNumber);

            // Распаковка кортежа с использованием var
            var (num, greet, _, wrld, _) = tuple;
            Console.WriteLine("Распаковка с использованием var:");
            Console.WriteLine(num);
            Console.WriteLine(greet);
            Console.WriteLine(wrld);


            var tuple3 = (42, "строка", true);
            var tuple4 = (42, "строка", true);
            var tuple5 = (42, "другая строка", true);

            bool areEqual1 = tuple3 == tuple4;  // true
            bool areEqual2 = tuple3 == tuple5;  // false
            bool areNotEqual = tuple3 != tuple5;  // true

            int[] iq = { 3, 2, 3, 4, 5, 9, 3 };
            string nic = "Nikita";

            (int, int, int, char) Func(int[] iq, string nic)
            {
                (int, int, int, char) qw;
                qw.Item1 = iq.Max();
                qw.Item2 = iq.Min();
                qw.Item3 = iq.Sum();
                qw.Item4 = nic.First();

                return qw;
            }
            (int, int, int, char) qw = Func(iq, nic);
            Console.WriteLine(qw);

            void Func1()
            {
                checked
                {
                    int bebra = int.MaxValue;
                    Console.WriteLine(bebra);
                }
            }
            void Func2()
            {
                unchecked
                {
                    int bebra = int.MaxValue+2;
                }
              
                // Чтобы консольное окно не закрылось сразу после вывода, используем ReadLine()
              
            }
      
            Console.ReadLine();
        }
    }

}

