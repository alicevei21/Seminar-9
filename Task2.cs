using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N");
            int m = InputNumbers("Введите m: ");
            int n = InputNumbers("Введите n: ");
            int y = m;

            if (m > n)
            {
                m = n;
                n = y;
            }

            int InputNumbers(string input)
            {
                Console.Write(input);
                int outt = Convert.ToInt32(Console.ReadLine());
                return outt;
            }

            PrintSumm(m, n, y = 0);

            void PrintSumm(int m2, int n2, int summ)
            {
                summ = summ + n2;
                if (n2 <= m2)
                {
                    Console.Write($"Сумма элементов = {summ} ");
                    return;
                }
                PrintSumm(m2, n2 - 1, summ);
            }
        }
    }
}