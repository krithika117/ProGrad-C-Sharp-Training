using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_3_hands_on
{
    internal class CollectionsDemo
    {
        public static void Main(String[] args) {
            Console.WriteLine("List Demo");
            var listDemo = new List<string>() { "new", "oranges" };
            listDemo.Add("Hello");
            listDemo.Add("Hello1");
            listDemo.Add("Hello2");
            listDemo.Add("Hello3");
            listDemo.Add("Hello3");
            foreach (var item in listDemo)
            {
                Console.WriteLine(item);
            }
            listDemo.Remove("Hello1");

            Console.WriteLine("\nAfter Removal");
            foreach (var item in listDemo)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("HashSet Demo");

            var hashsetTest = new HashSet<string>() { "a", "bb", "lorem", "ipsum", "ipsum" };
            foreach (var hashset in hashsetTest) { Console.Write(hashset + " "); }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sorted Set Demo");

            var sortedsetTest1 = new SortedSet<string>() { "a", "q", "k" };
            foreach (string s in sortedsetTest1) { Console.Write(s + " "); }

            Console.WriteLine();

            var sortedsetTest2 = new SortedSet<int>() { 4,5,6,1,2,0,-3,3 };
            foreach (int s in sortedsetTest2) { Console.Write(s + " "); }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Stack Demo");
            var stackSample = new Stack<string>();
            stackSample.Push("A");
            stackSample.Push("B");
            stackSample.Push("Z");

            foreach(var item in stackSample) 
            { Console.WriteLine(item); }

            Console.WriteLine();

            Console.WriteLine("Queue Demo");
            var queueDemo = new Queue<string>();
            queueDemo.Enqueue("A");
            queueDemo.Enqueue("B");
            queueDemo.Enqueue("Z");

            foreach (var item in queueDemo)
            { Console.WriteLine(item); }

        }
    }
}
