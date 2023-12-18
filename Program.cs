using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 задача
            int[,] A = new int[5, 5]
        {
                { 11, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 25, 14, 15 },
                { 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 13 }
        };

            int[,] B = new int[6, 6]
            {
                { 11, 2, 3, 4, 5, 6 },
                { 7, 8, 9, 10, 11, 12 },
                { 13, 14, -15, 16, 17, 18 },
                { 19, 20, 21, 22, 23, 24 },
                { 25, 26, 27, 28, 36, 30 },
                { 31, 32, 33, 34, 35, 1 }
            };
            int indexA = FindMaxElement(A);
            int indexB = FindMaxElement(B);
            int[,] newA = RemoveRow(A, indexA);
            int[,] newB = RemoveRow(B, indexB);
            PrintMatrix(newA);
            PrintMatrix(newB);
        }
        static int FindMaxElement(int[,] matrix)
        {
            int maxelement = matrix[0, 0];
            int inew = 0;
            for (int i = 0; i < Math.Min(matrix.GetLength(0), matrix.GetLength(1)); i++)
            {
                if (matrix[i, i] > maxelement)
                {
                    maxelement = matrix[i, i];
                    inew = i;
                }
            }
            return inew;
        }
        static int[,] RemoveRow(int[,] matrix, int rowIndex)
        {
            int rows = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            int[,] newmatrix = new int[rows - 1, col];
            for (int i = 0, newRow = 0; i < rows; i++)
            {
                if (i != rowIndex)
                {
                    for (int j = 0; j < col; j++)
                    {
                        newmatrix[newRow, j] = matrix[i, j];
                    }
                    newRow++;
                }
            }
            return newmatrix;
        }
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
            9 задача
            int[,] A = new int[6, 5]
            {
                { 11, -2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 25, 0, 15 },
                { 16, 17, -18, 19, 20 },
                { 21, 22, 23, 24, 13 },
                {-1, 6 , 5, 8, -10 }
            };
        int[,] B = new int[7, 4]
        {
                {2, -3, 0, 5 },
                {1, 23, 0, -23},
                { 4,5,6,7},
                {3,7,12,-29 },
                {0,0,0,0 },
                {-1,-2,-3,4 },
                { 3,3,3,3},
        };
        int[] sumA = SumPositive(A);
        int[] sumB = SumPositive(B);
        int[] sumAB = new int[sumA.Length + sumB.Length];
        int f = 0;
            for (int i = 0; i<sumA.Length; i++)
            {
                sumAB[i] = sumA[i];
            }
            for (int i = sumA.Length; i<sumAB.Length; i++)
            {
                sumAB[i] = sumB[f];
                f++;
            }
for (int i = 0; i < sumAB.Length; i++)
{
    Console.WriteLine(sumAB[i]);
}
static int[] SumPositive(int[,] matrix)
{
    int[] sumPos = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, j] > 0)
            {
                sumPos[j] += matrix[i, j];
            }
        }
    }
    return sumPos;
}
//15 задача
double[,] A = new double[6, 5]
            {
                { 11, -2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 25, 0, 15 },
                { 16, 17, -18, 19, 20 },
                { 21, 22, 23, 24, 13 },
                {-1, 6 , 5, 8, -10 }
            };
            double[,] B = new double[1, 2]
            {
                {2, 5},
                
            };
            double[,] C = new double[1, 3]
            {
                {3,-19,25 },
                
            };
            double srA = Srznach(A);
            double srB = Srznach(B);
            double srC = Srznach(C);
            double[] znac = new double[3];
            znac[0] = srA; znac[1] = srB; znac[2] = srC;
            if (znac[0] < znac[1] & znac[1] < znac[2])
            {
                Console.WriteLine("возрастает");
            }
            if (znac[0] > znac[1] & znac[1] > znac[2])
            {
                Console.WriteLine("убывает");
            }
            else
            {
                Console.WriteLine("ничего не образует");
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(znac[i]);
            }
            static double Srznach(double[,] matrix)
            {
                double max = matrix[0, 0];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] > max)
                        {
                            max = matrix[i, j];
                        }
                    }
                }
                double min = matrix[0, 0];
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] < min)
                        {
                            min = matrix[i, j];
                        }
                    }
                }
                double sum = 0;
                double col = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        sum += matrix[i, j];
                        col++;
                    }
                }
                if (col == 2)
                {
                    return 0;
                }
                else
                {
                    double sumnew = sum - max - min;
                    double sr = sumnew / (col - 2);
                    return sr;
                }
            }
//21 задача
int[,] A = new int[5, 5]
{
                { 11, -2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 25, 0, 15 },
                { 16, 17, -18, 19, 20 },
                { 21, 22, 23, 24, 13 },
};
int[,] B = new int[4, 4]
{
                {2, -3, 0, 5 },
                {1, 23, 0, -23},
                { 4,5,6,7},
                {3,7,12,-29 },
};
int[] minA = searchMin(A);
int[] minB = searchMin(B);
Printarray(minA);
Printarray(minB);
static int[] searchMin(int[,] matrix)
{
    int[] minznach = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int min = matrix[i, i];
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
            }
        }
        minznach[i] = min;
    }
    return minznach;
}
static void Printarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//27 задача
int[,] A = new int[5, 6]
                        {
                            { 11, -2, 3, 4, 5,-1 },
                            { 6, 7, 8, 9, 10,5 },
                            { 11, 12, 25, 0, 15,0 },
                            { 16, 17, -18, 19, 20,7 },
                            { 21, 22, 23, 24, 13,6 },
                        };
            int[,] B = new int[4, 4]
            {
                            {2, -3, 0, 5 },
                            {1, 23, 0, -23},
                            { 4,5,6,7},
                            {3,7,12,-29 },
            };
            zamena(A);
            zamena(B);
            PrintMatrix(A);
            Console.WriteLine();
            PrintMatrix(B);
            static void zamena(int[,] matrix)
            {
                int nj = 0;
                
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    int max = matrix[i, 0];
                    if (i % 2 == 0)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            if (matrix[i, j] > max)
                            {
                                max = matrix[i, j];
                                nj = j;
                            }
                        }
                        matrix[i, nj] = 0;
                    }
                    else
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            if (matrix[i, j] > max)
                            {
                                max = matrix[i, j];
                                nj = j;
                            }  
                        }
                        matrix[i, nj] *= nj;
                    }
                    }
                }
            }
            static void PrintMatrix(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }



        }
    }  }
