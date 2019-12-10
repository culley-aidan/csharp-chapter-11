using System;

namespace MortgageApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter credit score: ");
                int.TryParse(Console.ReadLine(), out int credit);
                try {
                    Console.WriteLine(IsEligible(credit) ? "Yes, Eligible" : "No, Not eligible.");
                    break;
                } catch (ArgumentException e) {
                    Console.WriteLine("The credit score is invalid!");
                }
            }
        }

        static bool IsEligible(int creditscore)
        {
            if ((creditscore >= 300) && (creditscore <= 850)) {
                return (creditscore >= 650);
            } else {
                throw new ArgumentException();
            }
        }
    }
}
