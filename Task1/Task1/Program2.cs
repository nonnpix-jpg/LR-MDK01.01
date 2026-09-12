using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program2
    {   /// второе задание
        static void Main(string[] args)
        {
            int a = SuperFunctions.Input();
            Console.WriteLine($"Число с цифрами в обратном порядке: {SuperFunctions.Revers(a)}");
        }
    }
}
