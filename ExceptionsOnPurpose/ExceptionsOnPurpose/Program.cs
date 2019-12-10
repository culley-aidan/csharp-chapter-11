using System;

namespace ExceptionsOnPurpose
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer, result, zero = 0;
            Console.Write("Enter an integer >> ");
            answer = Convert.ToInt32(Console.ReadLine());
            result = answer / zero;
            Console.WriteLine("The answer is ", answer);
        }
    }
}
