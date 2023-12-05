
using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 уровень 1 задача
            int[,] a1_1 = new int[5, 7];
            int sum1_1 = 0;
            Console.WriteLine("Введите матрицу: ");
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 7; j++)
                {
                    a1_1[i, j] = int.Parse(Console.ReadLine());
                }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    sum1_1 += a1_1[i, j];
                }
            }
            Console.WriteLine(sum1_1);
            //1 уровень 5 задача
            Console.WriteLine("Введите столбец матрицы: ");
            int n1_5 = int.Parse(Console.ReadLine());
            int[,] a1_5 = new int[5, 4];
            int ni1_5 = 0;
            int elem1_5 = 0;
            Console.WriteLine("Введите матрицу: ");
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 4; j++)
                {
                    a1_5[i, j] = int.Parse(Console.ReadLine());
                }

            for (int i = 0; i < a1_5.GetLength(0); i++)
            {
                if (a1_5[i, n1_5] < 0)
                {
                    elem1_5 = a1_5[i, n1_5];
                    ni1_5 = i;
                    break;
                }
            }
            if (ni1_5 >= 0)
            {
                Console.WriteLine($"Значение первого отрицательного элемента в столбце {n1_5} матрицы: {elem1_5}");
                Console.WriteLine($"Номер строки: {ni1_5}");
            }
            else
            {
                Console.WriteLine("отрицательных элементов в заданном столбце нет");
            }
            //1 уровень 9 задача
            int[,] a1_9 = new int[5, 7]
            {
                { 1, 2, 3, 4, 5, 6, 7 },
                { 8, 9, 10, 11, 12, 13, 14 },
                { 15, 16, 17, 18, 19, 20, 21 },
                { 22, 23, 24, 25, 26, 27, 28 },
                { 29, 30, 31, 32, 33, 34, 35 }
            };


            int max1_9 = a1_9[0, 0];
            int maxi1_9 = 0;
            int maxj1_9 = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (a1_9[i, j] > max1_9)
                    {
                        max1_9 = a1_9[i, j];
                        maxi1_9 = i;
                        maxj1_9 = j;
                    }
                }
            }
            int t = a1_9[0, 0];
            a1_9[0, 0] = max1_9;
            a1_9[maxi1_9, maxj1_9] = t;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(a1_9[i, j] + " ");
                }
                Console.WriteLine();
            }
            //1 уровень 13 задача
            int[,] a1_13 = new int[5, 5]
            {
                { 25, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 1 }
            };
            int max1_13 = a1_13[0, 0];
            int imax1_13 = 0;
            for (int i = 0; i < 5; i++)
            {
                if (a1_13[i, i] > max1_13)
                {
                    imax1_13 = i;
                    max1_13 = a1_13[i, i];
                }
            }
            for (int i = 0; i < 5; i++)
            {
                int ni1_13 = a1_13[i, 3];
                a1_13[i, 3] = a1_13[i, imax1_13];
                a1_13[i, imax1_13] = ni1_13;
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(a1_13[i, j] + " ");
                }
                Console.WriteLine();
            }
            //1 уровень 17 задача
            int[,] matrix =
            {
                            {5, 8, 3, 10, 7, 2, 1},
                            {12, 6, 9, 4, 15, 11, 8},

                        };
            ProcessMatrix(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void ProcessMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int minIndex = 0;
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < matrix[i, minIndex])
                    {
                        minIndex = j;
                    }
                }
                int minElement = matrix[i, minIndex];
                for (int j = minIndex; j > 0; j--)
                {
                    matrix[i, j] = matrix[i, j - 1];
                }
                matrix[i, 0] = minElement;
            }
            //1 уровень 21 задача
            int[,] a1_21 = new int[5, 7]
            {
                    { 25, 2, 3, 4, 5, 6, 0 },
                    { 6, 7, 8, 9, 10,6, 0},
                    { 11, 12, 13, 14, 15,7,0 },
                    { 16, 17, 18, 19, 20 ,8,0},
                    { 21, 22, 23, 24, 1 ,9,0}
             };
            for (int i = 0; i < 5; i++)
            {
                int max1_21 = a1_21[0, i];
                for (int j = 0; j < 7 - 1; j++)
                {
                    if (a1_21[i, j] > max1_21)
                    {
                        max1_21 = a1_21[i, j];
                    }
                }
                a1_21[i, a1_21.GetLength(1) - 1] = max1_21;
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(a1_21[i, j] + " ");
                }
                Console.WriteLine();
            }
            //1 уровень 25 задача
            int[,] a1_25 = new int[6, 5] {
                { -1, 2, 3, 4, 5 },
                { 8, 9, 10, 11, 12},
                { 15, -16, 17, 18, 19},
                { 22, 23, 24, -25, 26},
                { -29, 30, 31, 32, -33},
            {-1, -3, -4, 6, 7 } };
            int[] count1_25 = new int[6];
            int count = 0;
            int f = 0;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (a1_25[i, j] < 0)
                    {
                        count++;
                        count1_25[0] = count;
                    }
                }
            }
            count = 0;
            f++;
            for (int i = 1; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (a1_25[i, j] < 0)
                    {
                        count++;
                        count1_25[1] = count;
                    }
                }
            }
            count = 0;
            f++;
            for (int i = 2; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (a1_25[i, j] < 0)
                    {
                        count++;
                        count1_25[2] = count;
                    }
                }
            }
            count = 0;
            f++;
            for (int i = 3; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (a1_25[i, j] < 0)
                    {
                        count++;
                        count1_25[3] = count;
                    }
                }
            }
            count = 0;
            f++;
            for (int i = 4; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (a1_25[i, j] < 0)
                    {
                        count++;
                        count1_25[4] = count;
                    }
                }
            }
            count = 0;
            f++;
            for (int i = 5; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (a1_25[i, j] < 0)
                    {
                        count++;
                        count1_25[5] = count;
                    }
                }
            }
            int maxf = 0, minf = 7, maxi = 0, mini = 0;
            for (f = 0; f < 6; f++)
            {
                if (count1_25[f] > maxf)
                {
                    maxf = count1_25[f];
                    maxi = f;
                }
                if (count1_25[f] < minf)
                {
                    minf = count1_25[f];
                    mini = f;
                }
            }
            int t;
            for (int j = 0; j < 5; j++)
            {
                t = a1_25[maxi, j];
                a1_25[maxi, j] = a1_25[mini, j];
                a1_25[mini, j] = t;
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(a1_25[i, j] + " ");
                }
                Console.WriteLine();
            }
            //1 уровень 29 задача
            int[,] a1_29 = new int[5, 7] {
                { -1, 2, 3, 4, 5, -6, 7 },
                { 8, 9, 10, -1, -12, 13, 14 },
                { 15, -16, 17, 18, 19, 20, 21 },
                { 22, 23, 24, 25, 26, 27, 28 },
                { -29, 30, 31, 32, -33, 34, 35 }};
            int min1_29 = 100000000;
            int jmin = 0;
            for (int i = 1; i < 2; i++)
            {
                for (int j = 0; j < a1_29.GetLength(1); j++)
                {
                    if (Math.Abs(a1_29[i, j]) < min1_29)
                    {
                        min1_29 = a1_29[i, j];
                        jmin = j;
                    }
                }
            }
            int k = jmin + 1;
            for (int i = 0; i < a1_29.GetLength(0); i++)
                for (int j = k + 1; j < a1_29.GetLength(1); j++)
                    a1_29[i, j - 1] = a1_29[i, j];
            Console.WriteLine();
            for (int i = 0; i < a1_29.GetLength(0); i++)
            {
                for (int j = 0; j < a1_29.GetLength(1) - 1; j++)
                    Console.Write("{0:d} ", a1_29[i, j]);
                Console.WriteLine();
            }
            //1 уровень 33 задача
            int count1_33 = 0;
            int[,] a1_33 = new int[5, 7] {
                { -1, 2, 3, 4, 5, -6, 7 },
                { 8, 9, 10, 11, 12, 13, 14 },
                { 15, -16, 17, 18, 19, 20, 21 },
                { 22, 23, 24, 25, 26, 27, 28 },
                { -29, 30, 31, 32, -33, 34, 35 }};
            for (int i = 0; i < a1_33.GetLength(0); i++)
            {
                for (int j = 0; j < a1_33.GetLength(1); j++)
                {
                    if (a1_33[i, j] < 0)
                    {
                        count1_33++;
                    }

                }
            }
            if (count1_33 == 0)
            {
                Console.WriteLine("отрицательных элементов нет");
            }
            int[] A1_33 = new int[count1_33];
            int f = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (a1_33[i, j] < 0)
                    {
                        A1_33[f] = a1_33[i, j];
                        f++;
                    }

                }
            }
            for (int i = 0; i < count1_33; i++)
            {
                Console.Write(A1_33[i] + " ");
            }
            Console.WriteLine()
            //2 уровень 1 задача
            int[,] a2_1 = new int[5, 7]
            {
                    { 25, 2, 3, 4, 5, 6, 0 },
                    { 6, 7, 8, 9, 10,6, 0},
                    { 11, 12, 13, 14, 15,7,0 },
                    { 16, 17, 18, 19, 20 ,8,35},
                    { 21, 22, 23, 24, 1 ,9,0}
             };
            int[] nj2_1 = new int[5];
            int c = 0; int nj = 0;
            for (int i = 0; i < a2_1.GetLength(0); i++)
            {
                int max2_1 = a2_1[i, 0];
                for (int j = 0; j < a2_1.GetLength(1); j++)
                {
                    if (a2_1[i, j] > max2_1)
                    {
                        nj = j;
                    }
                }
                nj2_1[c] = nj;
                c++;
            }
            for (int i = 0; i < a2_1.GetLength(0); i++)
            {
                if (nj2_1[i] == 0)
                {
                    a2_1[i, nj2_1[i] + 1] *= 2;
                }
                if (nj2_1[i] == 6)
                {
                    a2_1[i, nj2_1[i] - 1] *= 2;
                }
                if (nj2_1[i] != 6 & nj2_1[i] != 0)
                {
                    if (a2_1[i, nj2_1[i] - 1] < a2_1[i, nj2_1[i] + 1])
                    {
                        a2_1[i, nj2_1[i] - 1] *= 2;
                    }
                    else
                    {
                        a2_1[i, nj2_1[i] + 1] *= 2;
                    }
                }
            }
            for (int i = 0; i < a2_1.GetLength(0); i++)
            {
                for (int j = 0; j < a2_1.GetLength(1); j++)
                {
                    Console.Write(a2_1[i, j] + " ");
                }
                Console.WriteLine();
            }
            //2 уровень 5 задача
            double[,] a2_1 = new double[7, 5]
            {
                    { 25, 2, -3, -4, 5},
                    { 6, 7, 8, 9, 10,},
                    { -11, 12, 13, 14, 15 },
                    { 16, 17, 1, 19, 20},
                    { 21, 22, -23, 24, 1},
                    {2, -14, 18,24,-3},
                    {2,7,8,-2,45}
             };
            double[] maxelem = new double[5];
            int[] imaxelem = new int[5];
            double[] sum = new double[5];
            int[] jmaxelem = new int[5];
            int ni = 0; int nj = 0;
            for (int j = 0; j < 5; j++)
            {
                double max = a2_1[0, j];
                for (int i = 0; i < 7; i++)
                {
                    if (a2_1[i, j] > max)
                    {
                        max = a2_1[i, j];
                        ni = i;
                        nj = j;

                    }
                    maxelem[j] = max;
                    imaxelem[j] = ni;
                    jmaxelem[j] = nj;
                    sum[j] = (a2_1[0, j] + a2_1[6, j]) / 2;
                }
            }

            for (int i = 0; i < a2_1.GetLength(0); i++)
            {
                for (int j = 0; j < a2_1.GetLength(1); j++)
                {
                    Console.Write(a2_1[i, j] + " ");
                }
                Console.WriteLine();
            }
            double[,] a2_1 = new double[7, 5]
        {
            { 25, 2, -3, -4, 5 },
            { 6, 7, 8, 9, 10 },
            { -11, 12, 13, 14, 15 },
            { 16, 17, 1, 19, 20 },
            { 21, 22, -23, 24, 1 },
            { 2, -14, 18, 24, -3 },
            { 2, 7, 8, -2, 45 }
        };

            double[] maxelem = new double[5];
            int[] imaxelem = new int[5];
            double[] sum = new double[5];
            int[] jmaxelem = new int[5];
            int ni = 0;
            int nj = 0;

            for (int j = 0; j < 5; j++)
            {
                double max = a2_1[0, j];

                for (int i = 0; i < 7; i++)
                {
                    if (a2_1[i, j] > max)
                    {
                        max = a2_1[i, j];
                        ni = i;
                        nj = j;

                    }
                    maxelem[j] = max;
                    imaxelem[j] = ni;
                    jmaxelem[j] = nj;
                    sum[j] = (a2_1[0, j] + a2_1[6, j]) / 2;
                }
            }

            for (int i = 0; i < a2_1.GetLength(0); i++)
            {
                for (int j = 0; j < a2_1.GetLength(1); j++)
                {
                    if (a2_1[i, j] == maxelem[j])
                    {
                        if (maxelem[j] < sum[j])
                        {
                            a2_1[i, j] = sum[j];
                        }
                        else
                        {
                            a2_1[i, j] = j;
                        }
                    }

                    Console.Write(a2_1[i, j] + " ");
                }
                Console.WriteLine();
            }
            //2 уровень 9 задача
            int[,] a2_9 = new int[6, 7]
            {
                {1, 2, 3, 4, 5, 6, 7},
                {8, 9, 10, 11, 12, 13, 14},
                {15, 16, 17, 18, 19, 20, 21},
                {22, 23, 24, 25, 26, 27, 28},
                {29, 30, 31, 32, 33, 34, 35},
                {36, 37, 38, 39, 40, 41, 42}
            };

            for (int i = 0; i < a2_9.GetLength(0); i++)
            {
                for (int j = 0; j < a2_9.GetLength(1) / 2; j++)
                {
                    int t = a2_9[i, j];
                    a2_9[i, j] = a2_9[i, a2_9.GetLength(1) - 1 - j];
                    a2_9[i, a2_9.GetLength(1) - 1 - j] = t;
                }
            }

            for (int i = 0; i < a2_9.GetLength(0); i++)
            {
                for (int j = 0; j < a2_9.GetLength(1); j++)
                {
                    Console.Write(a2_9[i, j] + " ");
                }
                Console.WriteLine();
            }
            //3 уровень 2 задача
            double[,] a3_2 = new double[4, 4] {
                { 1, 2, 3, 4 },
                { 4, 5, 6, 4 },
                { 7, 8, 9, 4 },
                { 7, 8, 9, 4 } };
            for (int i = 0; i < a3_2.GetLength(0); i++)
            {
                for (int j = 0; j < a3_2.GetLength(0); j++)
                {
                    if (i == 0 || j == 0 || i == a3_2.GetLength(0) - 1 || j == a3_2.GetLength(0) - 1)
                    {
                        a3_2[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < a3_2.GetLength(0); i++)
            {
                for (int j = 0; j < a3_2.GetLength(0); j++)
                {
                    Console.Write("{0} ", a3_2[i, j]);
                }
                Console.WriteLine();
            }
            //3 уровень 1 задача
            int[,] a3_1 = new int[7, 5]{
            {3, 7, 2, 9, 4},
            {5, 1, 8, 6, 0},
            {10, 3, 5, 2, 1},
            {4, 3, 6, 7, 2},
            {1, 9, 4, 2, 5},
            {6, 4, 5, 3, 8},
            {2, 5, 1, 3, 7}};
            int[] minelem = new int[7];
            for (int i = 0; i < 7; i++)
            {
                int min = a3_1[i, 0];
                for (int j = 1; j < 5; j++)
                {
                    if (a3_1[i, j] < min)
                    {
                        min = a3_1[i, j];
                    }
                }
                minelem[i] = min;
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = i + 1; j < 7; j++)
                {
                    if (minelem[j] > minelem[i])
                    {
                        int t = minelem[i];
                        minelem[i] = minelem[j];
                        minelem[j] = t;

                        for (int k = 0; k < 5; k++)
                        {
                            t = a3_1[i, k];
                            a3_1[i, k] = a3_1[j, k];
                            a3_1[j, k] = t;
                        }
                    }
                }
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(a3_1[i, j] + " ");
                }
                Console.WriteLine();
            }
        ////3 уровень 10 задача
                        int[,] a = new int[5, 3]
    {
        { 5, 11, 3 },
        { 4, 2, 10 },
        { 3, 7, 9 },
        { 9, 7, 3 },
        { 8, 1, 2 }
    };

            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = j + 1; k < 3; k++)
                        {
                            if (a[i, j] < a[i, k])
                            {
                                int temp = a[i, j];
                                a[i, j] = a[i, k];
                                a[i, k] = temp;
                            }
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = j + 1; k < 3; k++)
                        {
                            if (a[i, j] > a[i, k])
                            {
                                int temp = a[i, j];
                                a[i, j] = a[i, k];
                                a[i, k] = temp;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
