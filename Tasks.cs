using System;
using System.Linq;

namespace ConsoleApp9
{
    internal class Program
    {

        static void Task1()
        {
            int a = 0;
            Console.WriteLine("Задание 1\n");
            for (a = 1; a <= 10; a++) Console.WriteLine(a);
        }

        static void Task2()
        {
            int a = 0;
            Console.WriteLine("Задание 2\n");
            for (a = 2; a <= 20; a++) if (a % 2 == 0) Console.WriteLine(a);
        }

        static void Task3()
        {
            int a = 0, sum = 0;
            Console.WriteLine("Задание 3\n");
            for (a = 1; a <= 15; a++) if (a % 2 != 0)
                {
                    Console.WriteLine(a);
                    sum += a;
                }
            Console.WriteLine($"\nСумма: {sum}");
        }

        static void Task4()
        {
            int a = 0;
            Console.WriteLine("Задание 4\n");
            for (a = 1; a <= 9; a++) Console.WriteLine($"7 * {a} = {7 * a}");
        }

        static void Task5()
        {
            int b = 0, result = 1, a = 0;
            Console.WriteLine("Задание 5\n");
            Console.Write("Введите целое число для нахождения факториала: ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Введите корректное число!");
            }

            for (a = 1; a <= b; a++) result *= a;
            Console.WriteLine(result);
        }

        static void Task6()
        {
            int range_a, range_b;
            Console.WriteLine("Задание 6\n");
            Console.Write("Введите начало диапазона:");
            while (!int.TryParse(Console.ReadLine(), out range_a))
            {
                Console.WriteLine("Введите корректное число!");
            }
            Console.Write("Введите конец диапазона:");
            while (!int.TryParse(Console.ReadLine(), out range_b))
            {
                Console.WriteLine("Введите корректное число!");
            }

            while (range_a <= range_b)
            {
                if (range_a == 2 || range_a == 3 || range_a == 5 || range_a == 7 || range_a == 13 || range_a % 2 != 0 && range_a % 3 != 0 && range_a % 5 != 0 && range_a % 7 != 0 && range_a % 13 != 0)
                {
                    Console.WriteLine(range_a);
                }
                range_a++;
            }
        }

        static void Task7()
        {
            Console.WriteLine("Задание 7\n");
            Console.Write("Введите строку:");
            string input = Console.ReadLine();
            int a = input.Length;
            string b = "";

            for (int i = a - 1; i >= 0; i--) b += input[i];

            Console.WriteLine($"Перевернутый вариант: {b}");
        }

        static void Task8()
        {
            string character_set, input;
            int counter_1 = 0, counter_2 = 0, input_l;
            character_set = "AEIOUYaeiouyАаЕеЁёИиОоУуЫыЭэЮюЯя";
            Console.WriteLine("Задание 8\n");
            Console.Write("Введите строку:");
            input = Console.ReadLine();
            input_l = input.Length;
            while (counter_1 != input_l)
            {
                if (character_set.Contains(input[counter_1]))
                {
                    counter_2++;
                }
                counter_1++;
            }
            Console.WriteLine(counter_2);
        }

        static void Task9()
        {
            Console.WriteLine("Задание 9\n");
            Console.Write("Введите строку:");
            string input = Console.ReadLine();
            int a = input.Length;
            string b = "";

            for (int i_1 = a - 1; i_1 >= 0; i_1--) b += input[i_1];
            if (b == input) Console.WriteLine("Введённая вами строка является палиндромом");
            else Console.WriteLine("Введённая вами строка НЕ является палиндромом");
        }

        static void Task10()
        {
            Console.WriteLine("Задание 10\n");
            Console.Write("Введите строку: ");
            string line = Console.ReadLine();
            string result_1 = "";

            int i = 0;
            while (i < line.Length)
            {
                if (line[i] != ' ')
                {
                    result_1 += line[i];
                }
                else
                {
                    result_1 += '_';
                }
                i++;
            }

            Console.WriteLine(result_1);
        }

        static void Task11()
        {
            Console.WriteLine("Задание 11\n");
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(input[i]);
            }
        }

        static void Task12()
        {
            int a = 0, b = 1, n;
            Console.WriteLine("Задание 12\n");
            Console.WriteLine("Введите значение: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Введите корректное число!");
            }

            while (a <= n)
            {
                Console.WriteLine(a);
                int temp = a;
                a = b;
                b = temp + b;
            }
        }

        static void Task13()
        {
            int b = 0;
            Console.WriteLine("Задание 13\n");
            Random rnd = new Random();
            int random_number = rnd.Next(1, 50);
            Console.WriteLine("Загадано случайное число от 1 до 50. Попробуйте угадать, а я буду подсказывать.");
            Console.WriteLine(random_number);
            while (b != random_number)
            {
                Console.WriteLine("Введите число: ");
                while (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Введите корректное число!");
                }
                if (b > random_number) Console.WriteLine("Вы не угадали. Загаданное число меньше.");
                if (b < random_number) Console.WriteLine("Вы не угадали. Загаданное число больше.");
            }
            Console.WriteLine($"Вы угадали! Загаданное число: {random_number}");
        }

        static void Task14()
        {
            int a = 0;
            Console.WriteLine("Задание 14\n");
            for (a = 1; a != 100; a++) if (a % 3 == 0 && a % 5 == 0) Console.WriteLine(a);
        }

        static void Task15()
        {
            int a = 0, b = 1;
            Console.WriteLine("Задание 15\n");
            while (a != 10)
            {
                Console.WriteLine($"{b}. Hello, world!");
                a++;
                b++;
            }
        }
    }
}