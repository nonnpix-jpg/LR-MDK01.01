using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class SuperFunctions
    {
        public static int Input()
        {
            while (true)
            {
                Console.WriteLine("Введите натуральное число: ");
                string result = Console.ReadLine();
                bool isValid = int.TryParse(result, out int number) && number > 0;
                if (isValid)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Ошибка! Попробуй еще раз");
                }
            }
        }

        public static int Summ(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            return sum;
        }

        public static int Revers(int number)
        {

            int reversed = 0;
            while (number > 0)
            {
                int a = number % 10;
                reversed = reversed * 10 + a;
                number /= 10;
            }
            return reversed;
        }

        public static int Count(int number)
        {
            int count = 0;
            for (int i = 0; number > 0; i++)
            {
                number /= 10;
                count++;
            }
            return count;
        }

        public static int Increase(int number)
        {
            int result = 1;
            while (number > 0)
            {
                int digit = number % 10;
                result *= digit;
                number /= 10;
            }
            return result;
        }
    }
}
