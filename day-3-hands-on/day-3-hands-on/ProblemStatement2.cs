using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Text.Json.JsonSerializer;

namespace day_3_hands_on
{
    internal class ProblemStatement2
    {
        public static void Main(String[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 2, 3,4 };

            Console.WriteLine("\nQ1. Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.");
            int[] arr1 = { 1, 2, 5, 7 };
            int[] arr2 = { 3, 4, 6, 8 };
            int[] resultArray = new int[arr1.Length + arr2.Length];

            int i = 0, j = 0, k = 0;
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    resultArray[k++] = arr1[i++];
                }
                else
                {
                    resultArray[k++] = arr2[j++];
                }
            }

            while (i < arr1.Length)
                resultArray[k++] = arr1[i++];

            while (j < arr2.Length)
                resultArray[k++] = arr2[j++];

            Console.WriteLine("Arrays:");

            Array.ForEach(arr1, num => Console.Write(num + " "));
            Console.WriteLine();
            Array.ForEach(arr2, num => Console.Write(num + " "));

            Console.Write("\nMerged Array = ");
            Array.ForEach(resultArray, num => Console.Write(num + " "));
            Console.WriteLine();

            Console.WriteLine("\nQ2. Write a program in C# Sharp to count a total number of duplicate elements in an array.");
            var dictionary = new Dictionary<int, int>();
            int duplicates=0;
            foreach (int n in array)
            {
                if (!dictionary.ContainsKey(n)) 
                    dictionary[n] = 1;
                else
                {
                    dictionary[n]++;
                    duplicates++;
                }
            }

            Console.Write("Array = ");
            Array.ForEach(array, num => Console.Write(num + " "));

            Console.WriteLine("\nNumber of duplicates = "+duplicates);
            Console.WriteLine("\nQ3. Write a program in C# Sharp to separate odd and even integers in separate arrays");

            // int[] mixedArray = { 1, 2, 3, 4 };
            int[] oddArray = new int[array.Length];
            int[] evenArray = new int[array.Length];
            j = 0;
            k = 0;
            foreach (int x in array)
            {
                if(x%2==0)
                    oddArray[j++] = x;
                else 
                    evenArray[k++] = x;
            }
            Array.Resize(ref oddArray, j);
            Array.Resize(ref evenArray, k);

            Console.Write("Array = ");
            Array.ForEach(array, num => Console.Write(num + " "));
            Console.Write("\nOdd = ");
            Array.ForEach(oddArray, num => Console.Write(num + " "));
            Console.Write("\nEven = ");
            Array.ForEach(evenArray, num => Console.Write(num + " "));
            Console.WriteLine();

        }


    }
}
