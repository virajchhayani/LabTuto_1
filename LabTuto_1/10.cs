using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTuto_1
{
    internal class _10
    {
        static void Main()
        {
            Console.Write("Enter a mobile number: ");
            string mobileNumber = Console.ReadLine();

            if (mobileNumber.Length >= 5)
            {
                string convertedNumber = mobileNumber.Substring(0, mobileNumber.Length - 5) + "XXXXX";
                Console.WriteLine("Converted number: " + convertedNumber);
            }
            else
            {
                Console.WriteLine("Invalid input. The mobile number should have at least 5 digits.");
            }
        }
    }
}
