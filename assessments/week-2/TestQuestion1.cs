using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_9_hands_on
{
    internal class TestQuestion1
    {
        public static string LicensePlate(string s, int n)
        {
            // Remove any existing hyphens and convert to uppercase
            string plainString = s.Replace("-", "").ToUpper();
            int len = plainString.Length;

            // Calculate the number of groups in the final plate number
            int numOfGroups = len / n + (len % n == 0 ? 0 : 1);

            // Create an array to hold the groups of characters
            string[] groups = new string[numOfGroups];

            // Loop through the plainString 
            for (int i = 0; i < len; i++)
            {
                int groupIndex = i / n;
                if (groups[groupIndex] == null)
                {
                    groups[groupIndex] = "";
                }
                groups[groupIndex] += plainString[i];
            }
            // Join the groups with hyphens and return the final plate number
            return string.Join("-", groups.Reverse());
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(LicensePlate("5F3Z-2e-9-w", 4));
            Console.WriteLine(LicensePlate("2-5g-3-J", 2));
            Console.WriteLine(LicensePlate("2-4A0r7-4k", 3));
            Console.WriteLine(LicensePlate("nlj-206-fv", 3));
        }
    }
}
