using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_1
{
    internal class _8
    {
        static void Main()
        {
            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();
            string convertedName = ConvertToUpperCase(name);
            Console.WriteLine("Converted name: " + convertedName);
        }
        static string ConvertToUpperCase(string name)
        {
            string[] words = name.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            return string.Join(" ", words);
        }
    }
}
