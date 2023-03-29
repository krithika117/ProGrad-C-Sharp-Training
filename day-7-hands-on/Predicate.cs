using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class PredicateDemo
    {
        public static void Printer()
        {

            List<int> numbers = new List<int> { 2, 7, 4, 9, 1, 5, 6, 3 };
            Predicate<int> p = x => x > 5;
            List<int> greaterThanFive = numbers.FindAll(p);
            Console.WriteLine(string.Join(" ", greaterThanFive));

        }
    }
}