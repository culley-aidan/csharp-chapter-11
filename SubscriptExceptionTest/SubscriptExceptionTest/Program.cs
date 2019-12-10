using System;

namespace SubscriptExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[20];
            try
            {
                for (int x = 0; x < arr.Length; ++x)
                {
                    Console.Write("Enter a number for position {0}: ", x);
                    double.TryParse(Console.ReadLine(), out double result);
                    arr[x] = result;
                }
            } catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("{0}Finished Array{0}", Environment.NewLine);
            for(int x = 0; x < arr.Length; ++x)
            {
                Console.Write("{0, 6}", arr[x]);
            }
        }
    }
}
