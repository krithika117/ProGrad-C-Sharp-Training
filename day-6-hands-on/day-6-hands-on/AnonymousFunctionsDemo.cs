//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace day_6_hands_on
//{
//    delegate int DelegateForSum(int x, int y);
//    delegate void printMessage(string s);
//    delegate void noParameter();
//    internal class AnonymousFunctionsDemo
//    {
//        public static void Main(String[] args)
//        {
//            DelegateForSum dAdd = delegate (int a, int b) { return a + b; };
//            printMessage dMesssage = delegate (string s) { Console.WriteLine("Hello " + s); };
//            noParameter np = delegate () { Console.WriteLine("No Paramter"); };
//            Console.WriteLine(dAdd(3, 4));
//            dMesssage("Krithika");
//            np();
//        }
//    }
//}