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
        public void displayChocolates()
        {
            Console.WriteLine();
            foreach (KeyValuePair<string, int> chocolate in chocolates)
                Console.WriteLine(chocolate.Key + " = " + chocolate.Value);
        }

        // Trial 1
        public void addChocolates(string color, int count)
        {
            chocolates[color] += count;
        }

        // Trial 2
        public void removeChocolates(int count)
        {
            List<string> removedChocolateList = new List<string>();
            foreach (var color in chocolates.Keys)
            {
                while (chocolates[color] > 0 && count > 0)
                {
                    removedChocolateList.Add(color);
                    chocolates[color]--;
                    count--;
                }
                if (count == 0) break;
            }
            Console.WriteLine(string.Join(" ", removedChocolateList));

        }

        // Trial 3
        public void dispensedChocolates(int count)
        {
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
        public void dispenseChocolateOfColor(string color, int count)
        {
            List<string> dispensedChocolates = new List<string>();
            while (chocolates[color] > 0 && count > 0)
            {
                dispensedChocolates.Add(color);
                chocolates[color]--;
                count--;
            }
            Console.WriteLine(string.Join(" ", dispensedChocolates));
        }

        // Trial 5
        public void noOfChocolates()
        {
            Console.WriteLine(string.Join(" ", chocolates.Values.ToArray()));
        }

        // Trial 6
        public Dictionary<string, int> chocolateSort()
        {
            return chocolates.OrderByDescending(chocolate => chocolate.Value).ToDictionary(chocolate => chocolate.Key, chocolate => chocolate.Value);
        }

        // Trial 7
        public void changeChocolateColor(string originColor, string finalColor, int count)
        {
            while (chocolates[originColor] > 0 && count > 0)
            {
                chocolates[originColor]--;
                chocolates[finalColor]++;
                count--;
            }
        }

        // Trial 8
        public int changeChocolateColorAllOfxCount(String originColor, string finalColor, int count)
        {
            chocolates[finalColor] += chocolates[originColor];
            return chocolates[finalColor];
        }

        // Challenge 1
        public void removeChocolateOfColor(string color)
        {
            if (chocolates[color] > 0)
                chocolates[color]--;
            Console.WriteLine("Removed");
        }

        // Challenge 2
        public int dispenseRainbowChocolates(int count)
        {
            int rainbowChocolates = 0;
            foreach (var color in chocolates.Keys)
            {
                int currCount = chocolates[color];
                if (currCount >= 3)
                {
                    int possibleCount = (int)currCount / 3;
                    rainbowChocolates += possibleCount;
                    chocolates[color] -= (possibleCount * 3);
                }
            }
            return rainbowChocolates;
        }
        public static void Main(String[] args)
        {
            Question2 obj = new Question2();

            Console.WriteLine("Initial chocolates:");
            obj.displayChocolates();

            // Trial 1
            Console.WriteLine("\nTrial 1: Add chocolates");
            obj.addChocolates("green", 5);
            obj.addChocolates("silver", 5);
            obj.addChocolates("red", 15);
            obj.displayChocolates();

            // Trial 2
            Console.WriteLine("\nTrial 2: Remove chocolates");
            obj.removeChocolates(6);
            obj.displayChocolates();


            // Trial 3
            Console.WriteLine("\nTrial 3: Dispense chocolates");
            obj.dispensedChocolates(4);
            obj.displayChocolates();

            // Trial 4
            Console.WriteLine("\nTrial 4: Dispense chocolates of a color");
            obj.dispenseChocolateOfColor("red", 2);
            obj.displayChocolates();

            // Trial 5
            Console.WriteLine("\nTrial 5: Get number of chocolates");
            obj.noOfChocolates();

            // Trial 6
            Console.WriteLine("\nTrial 6: Sort chocolates");
            var sortedChocolates = obj.chocolateSort();
            foreach (var chocolate in sortedChocolates)
            {
                Console.WriteLine(chocolate.Key + ": " + chocolate.Value);
            }

            // Trial 7
            Console.WriteLine("\nTrial 7: Change chocolate color");
            obj.changeChocolateColor("green", "blue", 3);
            obj.displayChocolates();

            // Trial 8
            Console.WriteLine("\nTrial 8: Change all chocolates of a color to another color");
            int newCount = obj.changeChocolateColorAllOfxCount("red", "pink", 0);
            Console.WriteLine("New count of pink chocolates: " + newCount);
            obj.displayChocolates();

            // Challenge 1
            Console.WriteLine("\nChallenge 1: Remove chocolate of a color");
            obj.removeChocolateOfColor("green");
            obj.displayChocolates();

            // Challenge 2
            Console.WriteLine("\nChallenge 2: Dispense rainbow chocolates");
            int numRainbowChocolates = obj.dispenseRainbowChocolates(10);
            Console.WriteLine("Number of rainbow chocolates dispensed: " + numRainbowChocolates);
            obj.displayChocolates();

        }
    }
}