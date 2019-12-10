using System;

namespace OrderExceptionDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(420, 7, 24);
            Console.WriteLine("Order placed w/ 420,7,24");
            try {
                order = new Order(1337, 7, 24);
            } catch(ArgumentException e) {
                Console.WriteLine("Cannot place order w/ 1337, 7, 24. gave: " + e.Message);
            }
        }
        public class Order
        {
            public int ItemNumber { get; private set; }
            public int Quantity { get; private set; }
            public int DayOrdered { get; private set; }
            public Order(int itemNumber, int quantity, int dayOrdered)
            {
                if (itemNumber < 100 || itemNumber > 999) {
                    throw new ArgumentException("invalid item number");
                } else if (quantity < 1 || quantity > 12) {
                    throw new ArgumentException("invalid quantity");
                } else if (dayOrdered < 1 || dayOrdered > 31) {
                    throw new ArgumentException("invalid day ordered");
                }
                ItemNumber = itemNumber;
                Quantity = quantity;
                DayOrdered = dayOrdered;
            }
        }
    }
}
