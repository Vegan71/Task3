using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typical_Tasks
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 задание \n\n");

    
            Console.Write("Как вас зовут: ");
            string name = Console.ReadLine();

            Console.Write("Сколько вам лет: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Какой ваш рост в см: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ваше имя {name}, вам {age}, а ваш рост {height} см.");

            Console.WriteLine("\n\n 2 задание \n\n");

            Console.WriteLine("Введите 2 числа:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Сумма: {num1+num2}; Разность: {num1-num2}; Произведение: {num1*num2}; Частное: {num1/num2} ");

            Console.WriteLine("\n\n 3 задание \n\n");

            Console.Write("Введите число:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num3 % 2 == 0)
            {
                Console.WriteLine($"Число {num3} чётное");
            }
            else
            {
                Console.WriteLine($"Число {num3} не чётное");
            }

            Console.WriteLine("\n\n 4 задание \n\n");

            Console.WriteLine("Какой сегодня день недели по счёту?");
            int dayInput = Convert.ToInt32(Console.ReadLine());
            switch(dayInput)
            {
                case 1:
                    Console.WriteLine("Сегодня понедельник"); break;
                case 2:
                    Console.WriteLine("Сегодня Вторник"); break;
                case 3:
                    Console.WriteLine("Сегодня среда"); break;
                case 4:
                    Console.WriteLine("Сегодня четверг"); break;
                case 5:
                    Console.WriteLine("Сегодня пятница"); break;
                case 6:
                    Console.WriteLine("Сегодня суббота"); break;
                case 7:
                    Console.WriteLine("Сегодня воскресенье"); break;
                default:
                    Console.WriteLine("В недели всего 7 дней"); break;
            }

            Console.WriteLine("\n\n 5 задание \n\n");

            Console.WriteLine("Вот все числа от 1 до 10\n");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n\n 6 задание \n\n");

            int[] Array = new int[5];
            Console.WriteLine("Пожалуйста, заполните массив за нас");
            for(int i = 0;i < Array.Length; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Вот что вы ввели");
            Console.WriteLine(String.Join(" ", Array));

            Console.WriteLine("\n\n 7 задание \n\n");

            Console.WriteLine("С вас 2 числа, с меня максимальное значение");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int result = Program.Max(a, b);
            Console.WriteLine($"Максимальное число это: {result}");

            Console.WriteLine("\n\n 8 задание \n\n");

            Console.WriteLine("Введите три числа ,а я их сравню без Math");
            int num10 = Convert.ToInt32(Console.ReadLine());
            int num11 = Convert.ToInt32(Console.ReadLine());
            int num12 = Convert.ToInt32(Console.ReadLine());
            if(num10>num11 & num10 > 12)
            {
                Console.WriteLine($"{num10} Самое большое число");
            }
            else if(num11>num10 & num11 > num12)
            {
                Console.WriteLine($"{num11} Самое большое число");
            }
            else
            {
                Console.WriteLine($"{num12} Самое большое число");
            }

            Console.WriteLine("\n\n 9 задание \n\n");

            Console.Write("Напиши оценку ,а я о ней расскажу: ");
            int grade = Convert.ToInt32(Console.ReadLine());
            switch (grade) 
            {
                case 0: 
                    Console.WriteLine("Это же хуже чем кол.Как ты это получил?");
                    break;
                case 1:
                    Console.WriteLine("Это Кол");
                    break;
                case 2:
                    Console.WriteLine("bad");
                    break;
                case 3:
                    Console.WriteLine("удовлетворительно");
                    break;
                case 4:
                    Console.WriteLine("Хорошо");
                    break;
                case 5:
                    Console.WriteLine("Отлично!");
                break;
                default:
                    Console.WriteLine("Я таких оценок не знаю");
                    break;
            }
            Console.WriteLine("\n\n 10 задание \n\n");

            Console.WriteLine("На какое число вас интересует таблица умножения?");
            int multiplication = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"вот таблциа умножения на {multiplication}");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{multiplication} * {i} = {multiplication * i}");
            }

            Console.WriteLine("\n\n 11 задание \n\n");

            Console.Write("Ваш возраст: ");
            int age1= Convert.ToInt32(Console.ReadLine());
            if (age1 < 18)
            {
                Console.WriteLine("Вы очень молоды");
            }
            else
            {
                Console.WriteLine("Что стоишь?Иди голосуй!");
            }

            Console.WriteLine("\n\n 12 задание \n\n");

            Console.Write("Считаем квадратный корень для числа: ");
            int sqrtInput= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Квадратный корень из числа {sqrtInput} равен {Math.Sqrt(sqrtInput)}");

            Console.WriteLine("\n\n 15 задание \n\n");

            Console.WriteLine("Все чётные числа от 0 до 100");
            int check = 0;
            while (check <=100)
            {
                if(check % 2 == 0)
                {
                    Console.WriteLine(check);
                }
                check++;
            }



        }
        static int Max(int a, int b)
        {
            return Math.Max(a, b);
        }
       
    }
}