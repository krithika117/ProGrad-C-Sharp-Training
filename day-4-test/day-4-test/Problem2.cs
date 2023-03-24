using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4_test
{
    class Problem2
    {
        Dictionary<string, int> chocolateDetails;
        public Problem2()
        {
            chocolateDetails = new Dictionary<string, int>();
            chocolateDetails.Add("red", 0);
            chocolateDetails.Add("green", 0);
            chocolateDetails.Add("blue", 0);
            chocolateDetails.Add("yellow", 0);
  
        }

        public void addChocolates(string color, int count)
        {
            if (chocolateDetails.ContainsKey(color))
            {
                chocolateDetails[color] += count;
            }
           
        }
        public List<int> noOfChocolates()
        {
            List<int> counts = new List<int>();
            counts.Add(chocolateDetails["red"]);
            counts.Add(chocolateDetails["blue"]);
            counts.Add(chocolateDetails["green"]);
            counts.Add(chocolateDetails["yellow"]);
            return counts;
        }
        public static void Main(String[] args)
        {
            Problem2 problem = new Problem2();
            problem.addChocolates("red",4);
            Console.WriteLine(problem.noOfChocolates());
        }

    }
}