using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = SuperFunctions.Input();
            Console.WriteLine($"Сумма цифр числа {a} равна {SuperFunctions.Summ(a)}");
        }
    }
}
