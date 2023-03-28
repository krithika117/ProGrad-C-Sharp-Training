using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6_hands_on
{
    internal class LambdaDemo
    {
        // delegate int GreatestDelegate(int a, int b);
        public static void Main(String[] args)
        {
            //var sum = (int num1, int num2) => (num1 + num2); 
            //var sub = (int sum, int num2) => (sum - num2);    
            //Console.WriteLine(sub(sum(9,8), 1));
            //List<int> L1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> divisible_by_5 = (L1).FindAll((int n) => n % 5 == 0);
            //Console.WriteLine(string.Join(" ", divisible_by_5));

            //List<string> list = new List<string>() { "abc", "defa", "hij", "klm" };
            //List<string> containsA = list.FindAll(x => x.Contains('a'));
            //Console.WriteLine(string.Join(" ", containsA));

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "A");
            dict.Add(4, "k");
            dict.Add(2, "L");
            dict.Add(3, "g");
            dict.Add(5, "S");

            foreach (KeyValuePair<int, string> kvp in dict.OrderByDescending(x => x.Key)) {
                Console.WriteLine($"Key {kvp.Key} Value {kvp.Value}");
            }
        }
    }
}