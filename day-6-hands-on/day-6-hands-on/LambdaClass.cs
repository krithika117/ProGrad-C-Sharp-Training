using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6_hands_on
{
    internal class LambdaDemo
    {
        delegate int GreatestDelegate(int a, int b);
        public static void Main(String[] args)
        {
            GreatestDelegate sum = (num1, num2) => (num1 > num2) ? num1 : num2;
            Console.WriteLine(sum(9, 8));
        }
    }
}