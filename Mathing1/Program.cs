using System;

// add an inputed integer with catches
// sum of the integer and a constant
// multiply the sum by the constant and ouput rounded answer with 1 decimal place

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            const float Constant = 3.22f; // the constant
            int number; // our input number

            do // returns 0 instead of trying again on any non integer input
            {
                Console.WriteLine("Input your desired number (-100 to 100): ");
                Int32.TryParse(Console.ReadLine(), out number);
                if (number < -100 || number > 100)
                    Console.WriteLine("Number was out of bounds!");
                else Console.WriteLine("Your chosen number was: " + number);
            } while (number < -100 || number > 100);

            Console.WriteLine("The sum between the constant and chosen number is: " + (number + Constant));

            Console.WriteLine("The rounded down multiplication is: " + Math.Round(((number + Constant) * Constant), 1));
        }
    }
}