using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program4
    {
        static void Main(string[] args)
        {
            int a = SuperFunctions.Input();
            Console.WriteLine($"Сумма цифр числа {a} равна {SuperFunctions.Summ(a)}");
            Console.WriteLine($"Число с цифрами в обратном порядке: {SuperFunctions.Revers(a)}");
            Console.WriteLine($"Количество цифр в числе {a} равно {SuperFunctions.Count(a)}");
            Console.WriteLine($"Произведение цифр числа {a} равно {SuperFunctions.Increase(a)}");
        }
    }
}
