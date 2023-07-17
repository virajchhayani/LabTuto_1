using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_1
{
    internal class _15
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int originalNumber = number;
            int result = 0;
            int length = number.ToString().Length;

            while (number != 0)
            {
                int remainder = number % 10;
                result += (int)Math.Pow(remainder, length);
                number /= 10;
            }
            if (result == originalNumber)
                Console.WriteLine("The number is an Armstrong number.");
            else
                Console.WriteLine("The number is not an Armstrong number.");
        }
    }
}
