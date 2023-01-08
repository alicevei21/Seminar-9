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
            Console.WriteLine("Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.");
            int n = InputNumbers("Введите n: ");
            int y = 2;
            PrintNumberToConsole(n, y);
            Console.Write(1);

            int InputNumbers(string input)
            {
                Console.Write(input);
                int outt = Convert.ToInt32(Console.ReadLine());
                return outt;
            }
            void PrintNumberToConsole(int n1, int y2)
            {
                if (x2 > n1) return;
                PrintNumberToConsole(n1, y2 + 1);
                Console.Write(y2 + ", ");
            }
        }
    }
}