using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_1
{
    internal class _11
    {
        static void Main()
        {
            Console.Write("NAME: ");
            string name = Console.ReadLine();

            Console.Write("GENDER: ");
            char gender = char.ToUpper(Console.ReadKey().KeyChar);

            string prefix = (gender == 'M') ? "Mr." : "Ms.";
            Console.WriteLine($"\nHello, {prefix} {name}!");
        }
    }
}
