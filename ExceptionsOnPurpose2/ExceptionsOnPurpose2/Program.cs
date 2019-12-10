using System;

namespace ExceptionsOnPurpose2
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0, result, zero = 0;
            try
            {
                Console.Write("Enter an integer >> ");
                answer = Convert.ToInt32(Console.ReadLine());
                result = answer / zero;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("The answer is " + answer);
        }
    }
}
