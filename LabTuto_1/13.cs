using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_1
{
    internal class _13
    {
        static void Main()
        {
            int n = 11; // Number of terms to be printed
            int first = 0, second = 1;
            Console.Write("OUTPUT: " + first + " " + second);

            for (int i = 2; i < n; i++)
            {
                int next = first + second;
                Console.Write(" " + next);
                first = second;
                second = next;
            }
            Console.WriteLine();
        }
    }
}
