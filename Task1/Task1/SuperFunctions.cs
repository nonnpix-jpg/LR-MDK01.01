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
            int temp = number;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += digit;
                temp /= 10;
            }
            return sum;
        }
    }
}
