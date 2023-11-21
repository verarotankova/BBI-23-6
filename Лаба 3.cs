using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 уровень 1 задача
            double[] a = new double[6];
            double s1_1 = 0;
            Console.WriteLine("№1_1 Введите массив: ");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = double.Parse(Console.ReadLine());
                s1_1 += a[i];
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0:f} ", a[i] / s1_1);
            }
            Console.WriteLine();
            //1 уровень 2 задача 
            double[] a1_2 = new double[8] { 17, -1, 53, -5, 7, 8, 6, 4 };
            double s1_2 = 0;
            int m1_2 = 0;
            for (int i = 0; i < 8; i++)
            {
                if (a1_2[i] > 0)
                {
                    s1_2 = s1_2 + a1_2[i];
                    m1_2 += 1;
                }
            }
            double sr1_2 = s1_2 / m1_2;
            Console.WriteLine($"№1.2: {sr1_2}");
            //1 уровень 3 задача
            double[] a1_3 = new double[4];
            Console.WriteLine("%1_3 Введите массив 1: ");
            for (int i = 0; i < a1_3.Length; i++)
            {
                a1_3[i] = double.Parse(Console.ReadLine());
            }
            double[] A1_3 = new double[4];
            Console.WriteLine("Введите массив 2: ");
            for (int i = 0; i < a1_3.Length; i++)
            {
                A1_3[i] = double.Parse(Console.ReadLine());
            }
            double[] sum1_3 = new double[4];
            double[] r1_3 = new double[4];
            for (int i = 0; i < sum1_3.Length; i++)
            {
                sum1_3[i] = a1_3[i] + A1_3[i];
                r1_3[i] = a1_3[i] - A1_3[i];
            }
            for (int i = 0; i < sum1_3.Length; i++)
            {
                Console.WriteLine("{0:f} ", sum1_3[i] + " " + r1_3[i]);
            }
            //1 уровень 4 задача
            double sr1_4 = 0;
            double sum1_4 = 0;
            double[] a1_4 = new double[5];
            Console.WriteLine("%1_4 Введите массив: ");
            for (int i = 0; i < a1_4.Length; i++)
            {
                a1_4[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a1_4.Length; i++)
            {
                sum1_4 += a1_4[i];
            }
            sr1_4 = sum1_4 / a1_4.Length;
            Console.WriteLine("№1_4");
            for (int i = 0; i < a1_4.Length; i++)
            {
                a1_4[i] -= sr1_4;
                Console.Write(a1_4[i] + " ");
            }
            Console.WriteLine();
            //1 уровень 5 задача
            double sum1_5 = 0;
            double[] a1_5 = new double[4];
            Console.WriteLine("№1_5 Введите массив 1: ");
            for (int i = 0; i < a1_5.Length; i++)
            {
                a1_5[i] = double.Parse(Console.ReadLine());
            }
            double[] A1_5 = new double[4];
            Console.WriteLine("Введите массив 2: ");
            for (int i = 0; i < A1_5.Length; i++)
            {
                A1_5[i] = double.Parse(Console.ReadLine());
            }
            double[] y = new double[4];
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = a1_5[i] * A1_5[i];
                sum1_5 += y[i];
            }
            Console.WriteLine($"№1_5: {sum1_5}");
            //1 уровень 6 задача
            double sum1_6 = 0;
            double l = 0;
            double[] a1_6 = new double[5];
            Console.WriteLine("%1_6 Введите х-ы вектора: ");
            for (int i = 0; i < a1_6.Length; i++)
            {
                a1_6[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a1_6.Length; i++)
            {
                sum1_6 += a1_6[i] * a1_6[i];
            }
            l = Math.Sqrt(sum1_6);
            Console.WriteLine($"№1_6: {l}");
            //1 уровень 7 задача
            double sr1_7 = 0;
            double sum1_7 = 0;
            double[] a1_7 = new double[7];
            Console.WriteLine("%1_7 Введите массив: ");
            for (int i = 0; i < a1_7.Length; i++)
            {
                a1_7[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a1_7.Length; i++)
            {
                sum1_7 += a1_7[i];
            }
            sr1_7 = sum1_7 / a1_7.Length;
            Console.WriteLine("№1_7:");
            for (int i = 0; i < a1_7.Length; i++)
            {
                if (a1_7[i] > sr1_7)
                {
                    a1_7[i] = 0;
                }
                Console.Write(a1_7[i] + " ");
            }
            Console.WriteLine();
            //1 уровень 8 задача
            int countotr = 0;
            double[] a1_8 = new double[6];
            Console.WriteLine("%1_8 Введите массив: ");
            for (int i = 0; i < a1_8.Length; i++)
            {
                a1_8[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a1_8.Length; i++)
            {
                if (a1_8[i] < 0)
                {
                    countotr++;
                }
            }
            Console.WriteLine($"№1_8: {countotr}");
            //1 уровень 9 задача
            double sr1_9 = 0;
            int count1_9 = 0;
            double summ1_9 = 0;
            double[] a1_9 = new double[8];
            Console.WriteLine("%1_9 Введите массив: ");
            for (int i = 0; i < a1_9.Length; i++)
            {
                a1_9[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a1_9.Length; i++)
            {
                summ1_9 += a1_9[i];
            }
            sr1_9 = summ1_9 / a1_9.Length;
            for (int i = 0; i < a1_9.Length; i++)
            {
                if (a1_9[i] > sr1_9)
                {
                    count1_9++;
                }
            }
            Console.WriteLine($"№1_9: {count1_9}");
            //1 уровень 10 задача
            Console.WriteLine("Введите р: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите q: ");
            double q = Convert.ToDouble(Console.ReadLine());
            int count1_10 = 0;
            double[] a1_10 = new double[10];
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a1_10.Length; i++)
            {
                a1_10[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a1_10.Length; i++)
            {
                if (a1_10[i] > p & a1_10[i] < q)
                {
                    count1_10++;
                }
            }
            Console.WriteLine($"№1_10: {count1_10}");
            //1 уровень 11 задача
            int[] array = new int[10];
            int[] a1_11 = new int[10];
            int m = 0;
            Console.WriteLine("№1_11 Введите массив: ");
            for (int i = 0; i < a1_11.Length; i++)
            {
                a1_11[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a1_11.Length; i++)
            {
                if (a1_11[i] > 0)
                {
                    array[m] = a1_11[i];
                    m++;
                }
            }
            for (int i = 0; i < m; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            //1 уровень 12 задача
            int number = 0;
            int cget1_12 = 0;
            int[] a1_12 = new int[8];
            Console.WriteLine("№1_12 Введите массив: ");
            for (int i = 0; i < a1_12.Length; i++)
            {
                a1_12[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a1_12.Length; i++)
            {
                if (a1_12[i] < 0)
                {
                    number = a1_12[i];
                    cget1_12 = i;

                }
            }
            Console.WriteLine(number + " " + cget1_12);
            //1 уровень 13 задача
            int[] a1_13 = new int[10];
            int[] chet1_13 = new int[10];
            int[] nechet1_13 = new int[10];
            int m1_13 = 0;
            int n1_13 = 0;
            Console.WriteLine("%1_13 Введите массив: ");
            for (int i = 0; i < a1_13.Length; i++)
            {
                a1_13[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a1_13.Length; i++)
            {
                if (i % 2 == 0)
                {
                    chet1_13[m1_13] = a1_13[i];
                    m1_13++;
                }
                else
                {
                    nechet1_13[n1_13] = a1_13[i];
                    n1_13++;
                }
            }
            for (int i = 0; i < m1_13; i++)
            {
                Console.Write($"{chet1_13[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < n1_13; i++)
            {
                Console.Write($"{nechet1_13[i]} ");
            }
            //1 уровень 14 задача
            int[] a1_14 = new int[11];
            int m1_14 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a1_14.Length; i++)
            {
                a1_14[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a1_14.Length; i++)
            {
                if (a1_14[i] >= 0)
                {
                    a1_14[i] = a1_14[i] + a1_14[i];
                    m1_14 += a1_14[i];
                }
                else { break; }
            }
            Console.WriteLine($"№1_14: {m1_14}");
            //1 уровень 15 задача
            double[] x = new double[10];
            double[] y1_15 = new double[10];
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = double.Parse(Console.ReadLine());
            }
            int j = 0;
            for (int i = 0; i < y1_15.Length; i++)
            {
                y1_15[i] = 0.5 * Math.Log(x[i]);
                j++;
            }
            Console.WriteLine("№1_15: ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"{x[i]}    {y1_15[i]}");
            }
            //2 уровень 1 задача
            int min2_1 = 100000;
            int[] a2_1 = new int[5];
            int ni2_1 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_1.Length; i++)
            {
                a2_1[i] = int.Parse(Console.ReadLine());
                if (a2_1[i] < min2_1)
                {
                    min2_1 = a2_1[i];
                    ni2_1 = i;
                }
            }
            if (min2_1 >= 0)
            {
                min2_1 = min2_1 * 2;
            }
            else
            {
                min2_1 = min2_1 / 2;
            }
            Console.WriteLine(min2_1);
            //2 уровень 2 задача
            int[] a2_2 = new int[5];
            double max = -100000;
            int ni = 0;
            double sum2_1 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_2.Length; i++)
            {
                a2_2[i] = int.Parse(Console.ReadLine());
                if (a2_2[i] > max)
                {
                    max = a2_2[i];
                    ni = i;
                }
            }
            for (int i = 0; i < ni; i++)
            {
                sum2_1 += a2_2[i];
            }
            Console.WriteLine(sum2_1);
            //2 уровень 3 задача
            int min2_3 = 100000;
            int[] a2_3 = new int[5];
            int ni2_3 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_3.Length; i++)
            {
                a2_3[i] = int.Parse(Console.ReadLine());
                if (a2_3[i] < min2_3)
                {
                    min2_3 = a2_3[i];
                    ni2_3 = i;
                }
            }
            for (int i = 0; i < ni2_3; i++)
            {
                a2_3[i] *= 2;
                Console.Write($"{a2_3[i]} ");
            }
            Console.WriteLine();
            //2 уровень 4 задача
            double[] a2_4 = new double[5];
            double max2_4 = -100000;
            int ni2_4 = 0;
            double sr2_4 = 0;
            double sum2_4 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_4.Length; i++)
            {
                a2_4[i] = double.Parse(Console.ReadLine());
                if (a2_4[i] > max2_4)
                {
                    max2_4 = a2_4[i];
                    ni2_4 = i;
                }
            }
            for (int i = 0; i < a2_4.Length; i++)
            {
                sum2_4 += a2_4[i];
            }
            sr2_4 = sum2_4 / a2_4.Length;
            for (int i = ni2_4; i < a2_4.Length; i++)
            {
                a2_4[i] = sr2_4;
            }
            for (int i = 0; i < a2_4.Length; i++)
            {
                Console.Write($"{a2_4[i]} ");
            }
            Console.WriteLine();
            //2 уровень 5 задача
            int[] a2_5 = new int[7];
            int ni2_5 = 0;
            int nii2_5 = 0;
            int min2_5 = 100000;
            int max2_5 = -100000;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_5.Length; i++)
            {
                a2_5[i] = int.Parse(Console.ReadLine());
                if (a2_5[i] < min2_5)
                {
                    min2_5 = a2_5[i];
                    ni2_5 = i;
                }
                if (a2_5[i] > max2_5)
                {
                    max2_5 = a2_5[i];
                    nii2_5 = i;
                }
            }
            for (int i = nii2_5; i < ni2_5; i++)
            {
                if (a2_5[i] < 0)
                {
                    Console.Write($"{a2_5[i]} ");
                }
            }
            Console.WriteLine();
            //2 уровень 6 задача
            double[] a2_6 = new double[5];
            double P = 11;
            double sum2_6 = 0;
            int k2_6 = 0;
            int ni2_6 = 0;
            double maxb = 10000;
            for (int i = 0; i < a2_6.Length; i++)
            {
                a2_6[i] = double.Parse(Console.ReadLine());
                sum2_6 += a2_6[i];
                k2_6++;
            }
            double sr2_6 = sum2_6 / k2_6;
            for (int i = 0; i < a2_6.Length; i++)
            {
                if (Math.Abs(P - a2_6[i]) < maxb)
                {
                    maxb = Math.Abs(P - a2_6[i]);
                    ni2_6 = i;
                }
            }
            for (int i = ni2_6 + 1; i <= ni2_6 + 1; i++)
            {
                a2_6[i] = P;
            }
            for (int i = 0; i < a2_6.Length; i++)
            {
                Console.WriteLine("{0:f}", a2_6[i]);
            }
            Console.WriteLine();
            //2 уровень 7 задача
            int[] a2_7 = new int[5];
            int max2_7 = -100000;
            int ni2_7 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_7.Length; i++)
            {
                a2_7[i] = int.Parse(Console.ReadLine());
                if (a2_7[i] > max2_7)
                {
                    max2_7 = a2_7[i];
                    ni2_7 = i;
                }
            }
            Console.WriteLine($"№2_7: {a2_7[ni2_7 + 1] * 2}");
            //2 уровень 8 задача
            int[] a2_8 = new int[5];
            int max2_8 = -100000;
            int min2_8 = 100000;
            int nii2_8 = 0;
            int ni2_8 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_8.Length; i++)
            {
                a2_8[i] = int.Parse(Console.ReadLine());
                if (a2_8[i] > max2_8)
                {
                    max2_8 = a2_8[i];
                    ni2_8 = i;
                }
            }
            for (int i = ni2_8; i < a2_8.Length; i++)
            {
                if (a2_8[i] < min2_8)
                {
                    min2_8 = a2_8[i];
                    nii2_8 = i;
                }
            }
            for (int i = 0; i < a2_8.Length; i++)
            {
                a2_8[nii2_8] = max2_8;
                Console.Write($"{a2_8[i]} ");
            }
            Console.WriteLine();
            //2 уровень 9 задача
            int[] a2_9 = new int[7];
            int ni2_9 = 0;
            int nii2_9 = 0;
            int min2_9 = 100000;
            int max2_9 = -100000;
            double sum2_9 = 0;
            double sr2_9 = 0;
            double count2_9 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_9.Length; i++)
            {
                a2_9[i] = int.Parse(Console.ReadLine());
                if (a2_9[i] < min2_9)
                {
                    min2_9 = a2_9[i];
                    ni2_9 = i;
                }
                if (a2_9[i] > max2_9)
                {
                    max2_9 = a2_9[i];
                    nii2_9 = i;
                }
            }
            for (int i = ni2_9 + 1; i < nii2_9; i++)
            {
                sum2_9 += a2_9[i];
                count2_9++;
            }
            sr2_9 = sum2_9 / count2_9;
            Console.WriteLine($"№2_9: {sr2_9}");
            //2 уровень 10 задача
            double[] a2_10 = new double[7];
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < 7; i++)
            {
                a2_10[i] = Convert.ToDouble(Console.ReadLine());
            }
            double min2_10 = 0;
            int ni2_10 = 0;
            for (int i = 0; i < 7; i++)
            {
                if (a2_10[i] < min2_10 & a2_10[i] > 0)
                {
                    min2_10 = a2_10[i];
                    ni2_10 = i;
                }
            }
            double[] new_a = new double[7 - 1];
            for (int i = 0; i < 7 - 1; i++)
            {
                if (i != ni2_10)
                {
                    new_a[i] = a2_10[i];
                }
            }

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"{a2_10[i]} ");
            }
            Console.WriteLine();
            //2 уровень 11 задача
            Console.WriteLine("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a2_11 = new int[n];
            Console.WriteLine("Введите число P: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите элементы массива: ");
            int lastIndex = -1;
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                a2_11[i] = int.Parse(s);
                if (a2_11[i] > 0)
                {
                    lastIndex = i;
                }
            }
            if (lastIndex >= 0)
            {
                int[] b = new int[n + 1];
                for (int i = 0; i <= lastIndex; i++)
                {
                    b[i] = a2_11[i];
                }
                b[lastIndex + 1] = p;
                for (int i = lastIndex + 2; i < n + 1; i++)
                {
                    b[i] = a2_11[i - 1];
                }
                a2_11 = b;
                n++;

                Console.WriteLine("Массив после вставки: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0} ", a2_11[i]);
                }
            }
            else
            {
                Console.WriteLine("В массиве нет положительных элементов.");
            }
            //2 уровень 12 задача
            int[] a2_12 = new int[5];
            int ni2_12 = 0;
            int max2_12 = -1000000;
            int sum2_12 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_12.Length; i++)
            {
                a2_12[i] = int.Parse(Console.ReadLine());
                if (a2_12[i] > max2_12)
                {
                    max2_12 = a2_12[i];
                    ni2_12 = i;
                }
            }
            for (int i = ni2_12 + 1; i < a2_12.Length; i++)
            {
                sum2_12 += a2_12[i];
            }
            for (int i = 0; i < a2_12.Length; i++)
            {
                if (a2_12[i] < 0)
                {
                    a2_12[i] = sum2_12;
                    break;
                }
            }
            for (int i = 0; i < a2_12.Length; i++)
            {
                Console.Write($"{a2_12[i]} ");
            }
            Console.WriteLine();
            //2 уровень 13 задача
            int[] a2_13 = new int[7];
            int[] chet2_13 = new int[4];
            int m2_13 = 0;
            int max2_13 = -1000000;
            int ni2_14 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_13.Length; i++)
            {
                a2_13[i] = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    chet2_13[m2_13] = a2_13[i];
                    m2_13++;
                }
            }
            for (int i = 0; i < chet2_13.Length; i++)
            {
                if (chet2_13[i] > max2_13)
                {
                    max2_13 = chet2_13[i];
                }
            }
            for (int i = 0; i < a2_13.Length; i++)
            {
                if (a2_13[i] == max2_13)
                {
                    Console.WriteLine($"%2_13: {i}");
                }
            }
            //2 уровень 14 задача
            Console.WriteLine("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите массив: ");
            int[] a2_14 = new int[n];
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                a2_14[i] = int.Parse(s);
            }
            int a2_14max = a2_14[0];
            int imax = 0;
            for (int i = 0; i < n; i++)
            {
                if (a2_14[i] > a2_14max)
                {
                    a2_14max = a2_14[i];
                    imax = i;
                }
            }
            int k = -1;
            for (int i = 0; i < n; i++)
            {
                if (a2_14[i] < 0)
                {
                    k = i;
                    break;
                }
            }
            if (imax >= 0 && k >= 0)
            {
                int t = a2_14[imax];
                a2_14[imax] = a2_14[k];
                a2_14[k] = t;
                Console.WriteLine("Получившийся массив: ");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(a2_14[i]);
                }
            }
            else
            {
                Console.WriteLine("В массиве нет максимальных или отрицательных элементов.");
            }
            //2 уровень 15 задача
            Console.WriteLine("Введите количество элементов в массиве A: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите массив: ");
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                a[i] = int.Parse(s);
            }
            Console.WriteLine("Введите количество элементов в массиве В: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите массив: ");
            int[] b = new int[m];
            for (int i = 0; i < m; i++)
            {
                string s1 = Console.ReadLine();
                b[i] = int.Parse(s1);
            }
            int[] c = new int[n + m];
            Console.WriteLine("Введите k: ");
            int k = int.Parse(Console.ReadLine());
            if (k >= a.Length)
            {
                Console.WriteLine("Не существует такого элемента в массиве А");
            }
            else
            {
                for (int i = 0; i <= k; i++)
                {
                    c[i] = a[i];
                }
                for (int i = 0; i < m; i++)
                {
                    c[k + i + 1] = b[i];
                }
                for (int i = k + m + 1; i < m + n; i++)
                {
                    c[i] = a[i - m];
                }
                for (int i = 0; i < m + n; i++)
                {
                    Console.WriteLine(c[i]);
                }
            }
            //2 уровень 16 задача
            int[] a2_16 = new int[7];
            double sr2_16 = 0;
            double sum2_16 = 0;
            int t2_16 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < 7; i++)
            {
                a2_16[i] = int.Parse(Console.ReadLine());
                sum2_16 += a2_16[i];
            }
            sr2_16 = sum2_16 / 7;
            for (int i = 0; i < 7; i++)
            {
                if (a2_16[i] < sr2_16)
                {
                    t2_16++;
                }
            }
            int[] A2_16 = new int[t2_16];
            int j2_16 = 0;
            for (int i = 0; i < 7; i++)
            {
                if (a2_16[i] < sr2_16)
                {
                    A2_16[j2_16] = i;
                    Console.Write(A2_16[j2_16] + " ");
                    j2_16++;
                }
            }
            Console.WriteLine();
            //2 уровень 17 задача
            double[] a2_17 = new double[5];
            double sr = 0;
            int k = 0;
            double sum = 0;
            double max = -10000;
            double min = 100000;
            int ni1 = 0;
            int ni2 = 0;
            for (int i = 0; i < a2_17.Length; i++)
            {
                a2_17[i] = double.Parse(Console.ReadLine());
                if (a2_17[i] > max)
                {
                    max = a2_17[i];
                    ni1 = i;
                }
                if (a2_17[i] < min)
                {
                    min = a2_17[i];
                    ni2 = i;
                }
            }
            if (ni1 < ni2)
            {
                for (int i = 0; i < a2_17.Length; ++i)
                {
                    if (a2_17[i] > 0)
                    {
                        sum += a2_17[i];
                        k++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < a2_17.Length; ++i)
                {
                    if (a2_17[i] < 0)
                    {
                        sum += a2_17[i];
                        k++;
                    }
                }
            }
            if (k == 0)
            {
                Console.WriteLine("Нет положительных или отрицательных элементов");
            }
            else
            {
                sr = sum / k;
                Console.WriteLine(sr);
            }
            //2 уровень 18 задача
            Console.Write("Введите количество элементов в массиве: ");
            int N = Int32.Parse(Console.ReadLine());
            double[] a2_18 = new double[N];
            double max1 = -10000000;
            double max2 = -10000000;
            int start, end;
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < N; i++)
            {
                a2_18[i] = double.Parse(Console.ReadLine());
                if (i % 2 == 0 & a2_18[i] > max1) max1 = a2_18[i];
                if (i % 2 == 1 & a2_18[i] > max2) max2 = a2_18[i];
            }
            if (max1 > max2)
            {
                start = 0;
                end = (N - N % 2) / 2;
            }
            else
            {
                start = (N - N % 2) / 2;
                end = N;
            }

            for (int i = start; i < end; i++)
            {
                a2_18[i] = 0;
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(a2_18[i] + " ");
            }
            Console.WriteLine();
            //2 уровень 19 задача
            int sum2_19 = 0;
            int ni2_19 = 0;
            int max2_19 = -10000000;
            int[] a2_19 = new int[7];
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_19.Length; i++)
            {
                a2_19[i] = int.Parse(Console.ReadLine());
                if (a2_19[i] > max2_19)
                {
                    max2_19 = a2_19[i];
                    ni2_19 = i;
                }
                sum2_19 += a2_19[i];
            }
            for (int i = 0; i < a2_19.Length; i++)
            {
                if (max2_19 > sum2_19)
                {
                    a2_19[ni2_19] = 0;
                }
                else
                {
                    a2_19[ni2_19] = a2_19[ni2_19] * 2;
                }
            }
            for (int i = 0; i < a2_19.Length; i++)
            {
                Console.Write($"{a2_19[i]} ");
            }
            Console.WriteLine();
            //2 уровень 20 задача
            double[] a2_20 = new double[7];
            double min2_20 = 10000000;
            double sum2_20 = 0;
            int i11 = 0, i22 = 0;
            int start1 = -1;
            bool flag1 = true;
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < 8; i++)
            {
                a2_20[i] = double.Parse(Console.ReadLine());
                if (a2_20[i] < min2_20)
                {
                    min2_20 = a2_20[i];
                    i11 = i;
                }
                if (a2_20[i] < 0 & flag1 == true)
                {
                    i22 = i;
                    flag1 = false;
                }
            }
            if (i22 < i11) start1 = 0;
            else start1 = 1;
            for (int i = start1; i < 8; i += 2)
            {
                sum2_20 += a2_20[i];
            }
            Console.Write(sum2_20);
            //3 уровень 2 задача
            Console.WriteLine("Введите n: ");
            int n3_2  = int.Parse(Console.ReadLine());
            double[] a3_2 = new double[n3_2];
            double max3_2 = -1000000000;
            int ni3_2 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < n3_2; i++)
            {
                a3_2[i] = Convert.ToDouble(Console.ReadLine());
                if (a3_2[i] > max3_2)
                {
                    max3_2 = a3_2[i];
                    ni3_2 = i;
                }
            }
            for (int i = 0; i < n3_2; i++)
            {
                if (a3_2[i] == max3_2)
                {
                    a3_2[i] += ni3_2;
                    ni3_2++;
                }
            }
            for (int i = 0; i < n3_2; i++)
            {
                Console.Write($"{a3_2[i]} ");
            }
            Console.WriteLine();
            ////3 уровень 3 задача
            int number1 = int.Parse(Console.ReadLine());
            double[] a3_3 = new double[number1];
            for (int i = 0; i < number1; i++)
            {
                a3_3[i] = Convert.ToDouble(Console.ReadLine());
            }
            double max_number = 0;
            int max_number_index = 0;
            for (int i = 0; i < number1; i++)
            {
                if (a3_3[i] > max_number)
                {
                    max_number = a3_3[i];
                    max_number_index = i;
                }
            }
            double number_nazad = 0;
            for (int i = 1; i < max_number_index; i += 2)
            {
                number_nazad = a3_3[i];
                a3_3[i] = a3_3[i - 1];
                a3_3[i - 1] = number_nazad;
            }
            for (int i = 0; i < number1; i++)
            {
                Console.Write($"{a3_3[i]} ");
            }
        }

    }
}
