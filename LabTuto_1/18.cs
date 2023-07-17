using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_1
{
    internal class _18
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            int number = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }
        }
    }
}
