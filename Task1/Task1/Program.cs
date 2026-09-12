using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        private static int Input()
        {   
            
            Console.WriteLine("Введите натуральное число: ");
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }

        private static int Summ(int number)
        {
            int sum = 0;
            int temp = number;

            while (temp >0)
            {
                int digit = temp % 10;
                sum += digit;
                temp /= 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {

        }
    }
}
