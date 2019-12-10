using System;

namespace FindSquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValidDouble = false;
            double userDouble = 0, sqrRoot = 0;
            while(!isValidDouble)
            {
                Console.Write("Enter a valid double: ");
                isValidDouble = double.TryParse(Console.ReadLine(), out userDouble);
            }
            try
            {
                if (userDouble < 0) {
                    throw new ApplicationException("Double can't be negative!");
                } else {
                    sqrRoot = Math.Sqrt(userDouble);
                }
            } catch (ApplicationException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Square Root is " + sqrRoot);
        }
    }
}
