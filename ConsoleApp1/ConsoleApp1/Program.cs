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
            Console.WriteLine("Введите три целых числа:");
            Console.Write("Число 1:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число 2:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число 3:");
            int c = Convert.ToInt32(Console.ReadLine());

            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            Console.WriteLine($"Максимальноре число: {max}");
            Console.ReadKey();
        }
    }
}
