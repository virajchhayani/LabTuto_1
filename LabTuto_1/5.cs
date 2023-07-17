using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_1
{
    internal class _5
    {
        static void Main(string[] args)
        {
            int n, fact = 1; // Declare variables 'n' and 'fact' and initialize 'fact' to 1

            Console.WriteLine("Enter Number : "); // Print a message asking the user to enter a number
            string str = Console.ReadLine(); // Read the user's input as a string
            n = Convert.ToInt32(str); // Convert the input string to an integer and assign it to 'n'

            for (int i = 1; i <= n; i++) // Start a loop from 1 to 'n' (inclusive)
            {
                fact = fact * i; // Calculate the factorial by multiplying 'fact' with 'i' in each iteration
            }

            Console.WriteLine("Factorial : {0}", fact); // Print the factorial value
            Console.Read(); // Wait for the user to press a key before exiting the program
        }
    }
}
