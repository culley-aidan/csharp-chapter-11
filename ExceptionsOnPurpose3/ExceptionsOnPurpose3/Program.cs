using System;

namespace ExceptionsOnPurpose3
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
            }
            catch (FormatException e)
            {
                Console.WriteLine("You did not enter an integer");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("This is not your fault.{0}You entered the integer correctly.{0}The program divides by zero.", Environment.NewLine);
            }
            Console.WriteLine("The answer is " + answer);
        }
    }
}
