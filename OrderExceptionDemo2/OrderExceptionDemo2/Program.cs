using System;

namespace OrderExceptionDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}Generating array...{0}", Environment.NewLine);
            Order[] orders = new Order[5];
            for (int x = 0; x < orders.Length; ++x)
            {
                Random rng = new Random();
                int itmNumber = rng.Next(0, 1001), quantity = rng.Next(0, 14), dayOrdered = rng.Next(0, 33);
                try
                {
                    orders[x] = new Order(itmNumber, quantity, dayOrdered);
                } catch (ArgumentException e)
                {
                    Console.WriteLine($"Cannot place order w/ {itmNumber}, {quantity}, {dayOrdered} gave: {e.Message}");
                }
            }
            Console.WriteLine("{0}Reading array...{0}", Environment.NewLine);
            for (int x = 0; x < orders.Length; ++x)
            {
                try
                {
                    Console.WriteLine($"Order #{x} w/ Item Number: {orders[x].ItemNumber}, Quantity: {orders[x].Quantity}, DayOrdered: {orders[x].DayOrdered} ");
                } catch (NullReferenceException e)
                {
                    Console.WriteLine($"Order #{x} threw {e.Message}");
                }
            }
        }
        public class Order
        {
            public int ItemNumber { get; private set; }
            public int Quantity { get; private set; }
            public int DayOrdered { get; private set; }
            public Order(int itemNumber, int quantity, int dayOrdered)
            {
                if (itemNumber < 100 || itemNumber > 999)
                {
                    throw new ArgumentException("invalid item number");
                }
                else if (quantity < 1 || quantity > 12)
                {
                    throw new ArgumentException("invalid quantity");
                }
                else if (dayOrdered < 1 || dayOrdered > 31)
                {
                    throw new ArgumentException("invalid day ordered");
                }
                ItemNumber = itemNumber;
                Quantity = quantity;
                DayOrdered = dayOrdered;
            }
            public Order()
            {
                ItemNumber = 0;
                Quantity = 0;
                DayOrdered = 0;
            }
        }
    }
}