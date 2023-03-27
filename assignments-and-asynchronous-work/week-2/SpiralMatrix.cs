using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5_hands_on
{
    internal class SpiralMatrix
    {
        public static void PrintSpiral(int[,] matrix, int m, int n)
        {
            int rowStart = 0, colStart = 0, rowEnd = m - 1, colEnd = n - 1;
           
            while (rowStart <= rowEnd && colStart <= colEnd)
            {
                for (int i = colStart; i <= colEnd; i++)
                {
                    Console.Write(matrix[rowStart, i] + " ");
                }
                rowStart++;


                for (int i = rowStart; i <= rowEnd; i++)
                {
                    Console.Write(matrix[i, colEnd] + " ");
                }
                colEnd--;

                
                for (int i = colEnd; i >= colStart; i--)
                {
                    Console.Write(matrix[rowEnd, i] + " ");
                }
                rowEnd--;
                

                for (int i = rowEnd; i >= rowStart; i--)
                {
                    Console.Write(matrix[i, colStart] + " ");
                }
                colStart++;
                
            }
        }
        public static void Main(String[] args) {
            int[,] a = new int[2, 3] { { 1,2,3 }, { 4,5,6 } };
            PrintSpiral(a, 2, 3);
        }
    }
}

//1  2  3
//4  5  6
//7  8  9 
//10 11 12
