//namespace day_6_hands_on
//{
//    // Declare a delegate
//    //delegate int additionDelegate(int a, int b);
//    //internal class Program
//    //{
//    //    public static int addNumbers(int a, int b) {
//    //        return a + b;
//    //    }
//    //    static void Main(string[] args)
//    //    {
//    //        additionDelegate adder = addNumbers;
//    //        Console.WriteLine(adder.Invoke(5, 9));
//    //        Console.WriteLine(adder.Invoke(15, 9));
//    //    }
//    //}
//    public class MyClass
//    {
//        public delegate int DelegateAdd(int a, int b);
//    }
//    internal class Program
//    {

//        static int Add(int a, int b)
//        { return a + b; }
//        //static int Sub(int a,int b) {  return a - b; }
//        public static void Main(string[] args)
//        {
//            MyClass obj = new MyClass();
//            MyClass.DelegateAdd Dsum = Add;
//            Console.WriteLine(Dsum(2, 4));
//            Console.WriteLine(Dsum.Invoke(2, 5));

//        }
//    }


//}
/* using System;

delegate int CalculateDelegate(int x, int y);

class Program
{
   static void Main(string[] args)
    {
        CalculateDelegate add = new CalculateDelegate(new Calculator().Add);
        CalculateDelegate subtract = new CalculateDelegate(new Calculator().Subtract);
        CalculateDelegate multiply = new CalculateDelegate(new Calculator().Multiply);

        int result1 = add.Invoke(5, 3);
        int result2 = subtract.Invoke(5, 3);
        int result3 = multiply.Invoke(5, 3);

        Console.WriteLine("Addition result: " + result1);
        Console.WriteLine("Subtraction result: " + result2);
        Console.WriteLine("Multiplication result: " + result3);
    }
}

class Calculator
{
    public int Add(int x, int y)
    {
        return x + y;
    }

    public int Subtract(int x, int y)
    {
        return x - y;
    }

    public int Multiply(int x, int y)
    {
        return x * y;
    }
}

    */