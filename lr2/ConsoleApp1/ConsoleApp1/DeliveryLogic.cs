using System;

namespace DeliveryService
{

    static class DeliveryLogic
    {
      
        public static readonly string[] Names =
        {
            "посылка",
            "письмо",
            "бандероль",
            "экспресс",
            "документы"
        };

        
        public static readonly int[] Prices =
        {
            350,
            120,
            480,
            1250,
            200
        };

        
        public static readonly int[] Stock =
        {
            30,
            25,
            12,
            8,
            40
        };

        public static int[] CreateOrderedArray(int size)
        {
            return new int[size];
        }

        public static void PrintAssortment(string[] names, int[] prices, int[] stock)
        {
            Console.WriteLine("Услуги доставки:");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("{0}. {1} --- {2} руб., {3} мест",
                    i + 1, names[i], prices[i], stock[i]);
            }
        }

        public static void ReadOrder(string[] names, int[] ordered)
        {
            while (true)
            {
                int number = ReadIntInRange(
                    "Введите номер услуги (0 --- конец заказа): ",
                    0,
                    names.Length
                );

                if (number == 0)
                {
                    break;
                }

                int quantity = ReadNonNegativeInt("Введите количество: ");

                int index = number - 1;
                ordered[index] += quantity;
            }
        }

        public static int ReadIntInRange(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                int value;

                if (int.TryParse(input, out value) && value >= min && value <= max)
                {
                    return value;
                }

                Console.WriteLine("Ошибка: нужно ввести целое число от {0} до {1}.", min, max);
            }
        }

        public static int ReadNonNegativeInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                int value;

                if (int.TryParse(input, out value) && value >= 0)
                {
                    return value;
                }

                Console.WriteLine("Ошибка: нужно ввести целое число не меньше 0.");
            }
        }

        public static int FindShortage(int[] stock, int[] ordered)
        {
            for (int i = 0; i < stock.Length; i++)
            {
                if (ordered[i] > stock[i])
                {
                    return i;
                }
            }

            return -1;
        }

        public static void ProcessOrder(string[] names, int[] prices, int[] stock, int[] ordered)
        {
            int shortageIndex = FindShortage(stock, ordered);

            if (shortageIndex == -1)
            {
                AcceptOrder(prices, stock, ordered);
            }
            else
            {
                PrintShortage(names[shortageIndex]);
            }
        }

        public static void AcceptOrder(int[] prices, int[] stock, int[] ordered)
        {
            int total = CalculateTotal(prices, ordered);

            WriteOffStock(stock, ordered);

            Console.WriteLine("Стоимость заказа: {0} руб.", total);
        }

        public static int CalculateTotal(int[] prices, int[] ordered)
        {
            int total = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                total += prices[i] * ordered[i];
            }

            return total;
        }

        public static void WriteOffStock(int[] stock, int[] ordered)
        {
            for (int i = 0; i < stock.Length; i++)
            {
                stock[i] -= ordered[i];
            }
        }

        public static void PrintShortage(string name)
        {
            Console.WriteLine("Не хватает: {0}", name);
        }

        public static void PrintRemaining(string[] names, int[] stock)
        {
            Console.Write("Осталось свободных мест: ");

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("{0} {1}", names[i], stock[i]);

                if (i < names.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
    }
}