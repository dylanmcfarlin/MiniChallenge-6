using System;

// Dylan McFarlin
// Date Revised: 9-4-20
// MiniChallenge#6
// Program that takes an input and tells you if the number is odd or even.
// Code Reviewed by: Joseph Racca
    // Comments: maybe use an if statement for an incorrect input,
    // I tried “o” and got an error. Other than that your code is solid.

namespace MiniChallenge_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, rem1;
        
            Console.Clear();
            Console.WriteLine("This program will check if a number is odd or even.");
            Console.WriteLine();
            Console.WriteLine("Enter a whole number:");
            num1 = Convert.ToInt16(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
            {
                Console.WriteLine(num1 + " is an even number.");
            } else {
                Console.WriteLine(num1 + " is an odd number.");
            }
        }
    }
}
