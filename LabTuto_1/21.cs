using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_1
{
    internal class _21
    {
        static void Main()
        {
            Console.WriteLine("Input the number of terms: ");
            int terms = int.Parse(Console.ReadLine());

            Console.WriteLine("Input number: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int currentNumber = number;
            for (int i = 0; i < terms; i++)
            {
                sum += currentNumber;
                currentNumber = currentNumber * 10 + number;
            }
            Console.WriteLine("The sum is: " + sum);
        }
    }
}
