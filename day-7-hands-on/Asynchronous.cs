using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Asynchronous
    {
        public static async void method1()
        {

            Console.WriteLine("M1Start");
            await Task.Delay(3000);
            Console.WriteLine("M1End");
        }
        public static async void method2()
        {
            Console.WriteLine("M2Start");
            await Task.Delay(3000);
            Console.WriteLine("M2End");
        }
    }
}