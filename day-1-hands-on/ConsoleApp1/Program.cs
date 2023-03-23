using System.Security.Authentication;

namespace ConsoleApp1
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            string a = "Hello-World-krithika";
            string[] s = a.Split('-');
            foreach(string s2 in s)
            {
                Console.WriteLine(s2);
            }
        }

        /*
        public static void Main(string[] args) {
            int a = 9;
            Console.WriteLine("Demo for call by value and call by reference");
            Console.WriteLine("Before "+a);
            viewValue(a);
            Console.WriteLine("After " + a);

        }
        public static void viewValue(int a) {
            a = 8;
            Console.WriteLine(a);  
        }
        public static void viewRef(ref int a)
        {
            a = 11;
            Console.WriteLine(a);
        }
        */
    }
}
