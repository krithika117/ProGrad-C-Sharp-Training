// using System;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         int[,] square_matrix = {
//             { 1, 2, 3 },
//             { 4, 5, 6 },
//             { 7, 8, 9 }
//         };

//         int[,] rectangular_matrix1 = {
//             { 1, 2, 3, 4 },
//             { 5, 6, 7, 8 },
//             { 9, 10, 11, 12 }
//         };

//         int[,] rectangular_matrix2 = {
//             { 1, 2, 3 },
//             { 4, 5, 6 },
//             { 7, 8, 9 },
//             { 10, 11, 12 }
//         };

//         Console.WriteLine("Rectangular matrix where columns > rows:");
//         Console.WriteLine("Original matrix:");
//         PrintMatrix(rectangular_matrix1);
//         MatrixRotationBy90Degrees(rectangular_matrix1);
//         MatrixRotationBy180Degrees(rectangular_matrix1);
//         MatrixRotationBy270Degrees(rectangular_matrix1);

//         Console.WriteLine("Rectangular matrix where columns < rows:");
//         Console.WriteLine("Original matrix:");
//         PrintMatrix(rectangular_matrix2);
//         MatrixRotationBy90Degrees(rectangular_matrix2);
//         MatrixRotationBy180Degrees(rectangular_matrix2);
//         MatrixRotationBy270Degrees(rectangular_matrix2);

//         Console.WriteLine("Square matrix:");
//         Console.WriteLine("Original matrix:");
//         PrintMatrix(square_matrix);
//         MatrixRotationBy90Degrees(square_matrix);
//         MatrixRotationBy180Degrees(square_matrix);
//         MatrixRotationBy270Degrees(square_matrix);
//     }

//     public static void MatrixRotationBy90Degrees(int[,] matrix)
//     {
//         Console.WriteLine("Matrix Rotation By 90 Degrees"); 
//         int rows = matrix.GetLength(0);
//         int cols = matrix.GetLength(1);

//         int[,] rotatedMatrix = new int[cols, rows];

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 rotatedMatrix[j, rows - 1 - i] = matrix[i, j];
//             }
//         }
//         PrintMatrix(rotatedMatrix);
//     }

//     public static void MatrixRotationBy180Degrees(int[,] matrix)
//     {
//         Console.WriteLine("Matrix Rotation By 180 Degrees");

//         int rows = matrix.GetLength(0);
//         int cols = matrix.GetLength(1);

//         int[,] rotatedMatrix = new int[rows, cols];

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 rotatedMatrix[rows - i - 1, cols - j - 1] = matrix[i, j];

//             }
//         }
//         PrintMatrix(rotatedMatrix);
//     }

//     public static void MatrixRotationBy270Degrees(int[,] matrix)
//     {

//         Console.WriteLine("Matrix Rotation By 270 Degrees");

//         int rows = matrix.GetLength(0);
//         int cols = matrix.GetLength(1);

//         int[,] rotatedMatrix = new int[cols, rows];

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 rotatedMatrix[cols - j - 1, i] = matrix[i, j];
//             }
//         }
//         PrintMatrix(rotatedMatrix);
//     }

//     public static void PrintMatrix(int[,] matrix)
//     {
//         int rows = matrix.GetLength(0);
//         int cols = matrix.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 Console.Write(matrix[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();

//     }
// }

// /*

// 90 Degrees:
// Explanation
// 00 01 02 03       20 10 00
// 10 11 12 13   =>  21 11 01
// 20 21 22 23       22 12 02
//                   23 13 03

// OG   Rotated
// 00 = 02 
// 01 = 12
// 02 = 22
// 03 = 32
// _______

// 10 = 01
// 11 = 11
// 12 = 21
// 13 = 31
// _______

// 20 = 00
// 21 = 10
// 22 = 20
// 23 = 30

// So, 
// Original column j = Rotated row j
// Original row i = Rotated column (rowsOfOriginalMatrix-i-1)

// */