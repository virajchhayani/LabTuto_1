using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_1
{
    internal class _9
    {
        static void Main()
        {
            Console.WriteLine("Enter a name:");
            string input = Console.ReadLine();
            string toggleCaseName = ToggleCaseName(input);
            Console.WriteLine("Toggle case name: " + toggleCaseName);
        }
        static string ToggleCaseName(string name)
        {
            char[] chars = name.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLower(chars[i]))
                    chars[i] = char.ToUpper(chars[i]);
                else if (char.IsUpper(chars[i]))
                    chars[i] = char.ToLower(chars[i]);
            }
            return new string(chars);
        }
    }
}
