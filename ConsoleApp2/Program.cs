using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Вывести в строку десять заглавных букв "а" через один пробел:
            /*

            for (int i = 0; i < 10; i++)
            {
                Console.Write("A ");
            }
            */

            //2. Вывести в обратном порядке числа от 50 до 40.

            /*
            for (int i = 50; i >=40; i--)
            {
                Console.WriteLine(i);
            }
            */


            //3. Вывести в строку через пробел следующие натуральные числа:
            /*

            Console.Write("6 ");
            Console.Write("12 ");
            Console.Write("24 ");
            Console.Write("30 ");
            Console.Write("36 ");
            */

            //4. Вывести двузначные числа, кратные 11, подсчитать их количество и сумму.
            /*
            int quantity = 0;
            int sum = 0;

            for (int i = 10; i < 100; i++)
            {
                if (i %11 == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                    quantity++;

                }
            }
            Console.WriteLine($"Количество: {quantity}" );
            Console.WriteLine($"Сумма: {sum} ");
            */


            //6*. За каждый месяц банк начисляет к сумме вклада 7% от суммы. Напишите консольную программу, в которую пользователь вводит сумму вклада и количество месяцев. А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.
            /*
            Console.Write("Введите сумму вклада: ");
            double summ = int.Parse(Console.ReadLine());
            Console.Write("Введите количество месяцев: ");
            int months = int.Parse(Console.ReadLine());
            double procent = 0.10;
            for (int i = 0; i < months; i++)
            {
                double finalsum = summ * procent;
                summ += finalsum;
            }

            Console.WriteLine($"Через {months} меясцев ваш вклад будет равен: {summ}");
            */


            //7. Рост стоимости акций. Выпустив акции предприятие, оценило их в 100 руб. за штуку в первоначальный момент. Каждый следующий месяц акции вырастали в цене на 10% от стоимости предыдущего месяца. Определить:

            double cost = 100;
            Console.WriteLine($"Стоимость акций в 1 месяц: {cost}");
            double growth = 0.10;
            int months = 10;
            double price = cost;
            for (int  i = 1;i <= months;i++)
            {
                
                Console.WriteLine($"Стоимость акций полсе {i}: {price} ");
            }

        }
    }
}
