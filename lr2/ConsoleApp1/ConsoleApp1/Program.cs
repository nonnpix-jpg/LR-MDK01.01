namespace DeliveryService
{
    class Program
    {
        static void Main()
        {
            DeliveryLogic.PrintAssortment(
                DeliveryLogic.Names,
                DeliveryLogic.Prices,
                DeliveryLogic.Stock);

            int[] ordered = DeliveryLogic.CreateOrderedArray(DeliveryLogic.Names.Length);

            DeliveryLogic.ReadOrder(DeliveryLogic.Names, ordered);

            DeliveryLogic.ProcessOrder(
                DeliveryLogic.Names,
                DeliveryLogic.Prices,
                DeliveryLogic.Stock,
                ordered);

            DeliveryLogic.PrintRemaining(DeliveryLogic.Names, DeliveryLogic.Stock);
        }
    }
}