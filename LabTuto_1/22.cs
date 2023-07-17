using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_1
{
    internal class _22
    {
        static void Main()
        {
            int n = 5;
            int space = n - 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= space; j++)
                    Console.Write(" ");
                space--;
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
            space = 1;
            for (int i = 1; i <= n - 1; i++)
            {
                for (int j = 1; j <= space; j++)
                    Console.Write(" ");
                space++;

                for (int j = 1; j <= 2 * (n - i) - 1; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}
