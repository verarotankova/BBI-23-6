using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[5, 5]
        {
                { 11, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 25, 14, 15 },
                { 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 13 }
        };
            int nj = Max(A);
            Zam(A, nj);
            PrintMatrix(A);
            static void PrintMatrix(int[,] matrix)
            {
                int rows = matrix.GetLength(0);
                int columns = matrix.GetLength(1);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
;
            Console.WriteLine(nj);
            static int Max(int[,] matrix)
            {
                int ni = 0;
                int max = matrix[0, 0];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] > max)
                        {
                            max = matrix[i, j];
                            ni = j;
                        }
                    }
                }
                return ni;
            }
            static void Zam(int[,] matrix,int ni)
            {
                int[] a = new int[matrix.GetLength(0)];
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    a[i] = matrix[i, ni];
                }
                for (int i = 0; i < Math.Min(matrix.GetLength(0), matrix.GetLength(1)); i++)
                {
                    matrix[i, ni] = matrix[i, i];
                }
                
            }

        }
    }
}

