using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5_hands_on
{
    class Question2
    {
        Dictionary<string, int> chocolates = new Dictionary<string, int>() {
            {"green",0 },
            {"silver",0 },
            {"blue",0 },
            {"crimson",0 },
            {"purple",0 },
            {"red",0 },
            {"pink",0 },

        };
        // Print Dictionary
        public void displayChocolates() {
            Console.WriteLine();
            foreach (KeyValuePair<string, int> chocolate in chocolates)
                Console.WriteLine(chocolate.Key + " = " + chocolate.Value);
        }

        // Trial 1
        public void addChocolates(string color, int count) {
            chocolates[color] += count;
        }

        // Trial 2
        public void removeChocolates(int count)
        {
            List<string> removedChocolateList = new List<string>();
            foreach (var color in chocolates.Keys) {
                while (chocolates[color] > 0 && count > 0) {
                    removedChocolateList.Add(color);
                    chocolates[color]--;
                    count--;
                }
                if (count == 0) break;
            }
            Console.WriteLine(string.Join(" ", removedChocolateList));

        }

        // Trial 3
        public void dispensedChocolates(int count) {
            List<string> dispensedChocolateList = new List<string>();
            foreach (var color in chocolates.Keys.Reverse())
            {
                while (chocolates[color] > 0 && count > 0)
                {
                    dispensedChocolateList.Add(color);
                    chocolates[color]--;
                    count--;
                }
                if (count == 0) break;
            }
            Console.WriteLine(string.Join(" ", dispensedChocolateList));

        }

        // Trial 4
        public void dispenseChocolateOfColor(string color, int count) {
            List<string> dispensedChocolates = new List<string>();
            while (chocolates[color] > 0 && count > 0) {
                dispensedChocolates.Add(color);
                chocolates[color]--;
                count--;
            }
            Console.WriteLine(string.Join(" ", dispensedChocolates));
        }

        // Trial 5
        public void noOfChocolates() {
            Console.WriteLine(string.Join(" ", chocolates.Values.ToArray()));
        }

        // Trial 6
        public Dictionary<string, int> chocolateSort() {
            return chocolates.OrderByDescending(chocolate => chocolate.Value).ToDictionary(chocolate => chocolate.Key, chocolate => chocolate.Value);
        }

        // Trial 7
        public void changeChocolateColor(string originColor, string finalColor, int count) {
            while (chocolates[originColor] > 0 && count > 0) {
                chocolates[originColor]--;
                chocolates[finalColor]++;
                count--;
            }
        }

        // Trial 8
        public int changeChocolateColorAllOfxCount(String originColor, string finalColor ,int count) {
            chocolates[finalColor] += chocolates[originColor];
            return chocolates[finalColor];
        }

        // Challenge 1
        public void removeChocolateOfColor(string color) {
            if (chocolates[color] > 0)
                chocolates[color]--;
            Console.WriteLine("Removed");
        }

        // Challenge 2
        public int dispenseRainbowChocolates(int count) {
            int rainbowChocolates = 0;
            foreach (var color in chocolates.Keys) { 
                int currCount = chocolates[color];
                if(currCount >= 3) {
                    int possibleCount = (int) currCount / 3;
                    rainbowChocolates += possibleCount;
                    chocolates[color] -= (possibleCount*3);
                }
            }
            return rainbowChocolates;
        }
        public static void Main(String[] args) { 
            Question2 obj = new Question2();
            // Test methods
        }
    }
}
