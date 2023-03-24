using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4_hands_on
{
    internal class Problem
    {
        public void swapFirstAndLastCharacters()
        {
            Console.WriteLine("Enter input = ");
            char[] a = Console.ReadLine().ToCharArray();
            char temp;
            temp = a[0];
            a[0] = a[a.Length - 1];
            a[a.Length - 1] = temp;
            Console.WriteLine(string.Join("", a));

        }
        public string checkForSubString() {
            Console.WriteLine("Enter input = ");
            string input = Console.ReadLine();
            if (input.Contains("ok"))
            {
                return "OK is present, so the result is = " + input.Replace("ok","");
            }
            return "OK is not present = " + input;
        }

        
        public string addLastCharacter() {
            Console.WriteLine("Enter input = ");
            string input = Console.ReadLine();

            if (input.Length > 0)
            {
                char lastChar = input[input.Length - 1];
                return lastChar + input + lastChar;
            }
            return "Empty String";
        }

        
        public static void Main(string[] args)
        {
            Problem problem = new Problem();    
            //problem.swapFirstAndLastCharacters();
            //Console.Write(problem.addLastCharacter());
            Console.Write(problem.checkForSubString());
            
        }
    }
}
