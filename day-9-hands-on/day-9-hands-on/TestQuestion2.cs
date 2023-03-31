//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace day_9_hands_on
//{
//    internal class LicenseTimeTaken {
//        public static int TimeTakenForLicense(string myName, int noOfAgents, string otherNames) {
//            // Adding my name to other names
//            otherNames += " " + myName;
//            string[] allNames = otherNames.Split(" ");
//            // Sorting to arrange alphabetically
//            Array.Sort(allNames);
//            // Finding my index to identify my turn
//            int myNameIdx = Array.IndexOf(allNames, myName);
//            // Returning the result
//            return ((myNameIdx / noOfAgents ) + 1) * 20;
//        }
//        public static void Main(string[] args) {
//            Console.WriteLine(TimeTakenForLicense("Eric", 2, "Adam Caroline Rebecca Frank"));
//            Console.WriteLine(TimeTakenForLicense("Zebediah", 1, "Bob Jim Becky Pat"));
//            Console.WriteLine(TimeTakenForLicense("Aaron", 3, "Jane Max Olivia Sam"));
//        }
//    }
//}
