using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_1
{
    internal class _14
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            string[] words = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            Console.Write("OUTPUT: ");

            foreach (char c in number.ToString())
            {
                int digit = int.Parse(c.ToString());
                Console.Write(words[digit] + " ");
            }
            Console.WriteLine();
        }
    }
}
