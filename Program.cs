using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 задача 1 уровень
            double c;
            Console.WriteLine("введите а: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            
            if (a > 0)
            {
                c = Math.Max(a, b);
            }
            else
            {
                c = Math.Min(a, b);
            }
            Console.WriteLine(c);
           
            //6 задача 1 уровень
            double r1 = 3.2;
            double s1 = 3.5;
            if (s1 < (r1 + r1))
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");

            }
            double r2 = 3.2;
            double s2 = 4.3;
            if (s2 < (r2 + r2))
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");

            }
            double r3 = 6;
            double s3 = 9;
            if (s3 < (r3 + r3))
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");

            }
            //9 задача 1 уровень
            Console.WriteLine("введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y;
            if (x <= (-1))
            {
                y = 0;
            }
            if(x > 0)
            {
                y = 1;
            }
            else
            {
                y = 1 + x;
            }
            Console.WriteLine(y);
            //3 задача 2 уровень
            Console.WriteLine("введите количество учеников в классе: ");
            double count_students = Convert.ToDouble(Console.ReadLine());
            double c3_2 = 0;
            for (int i3_2 = 0; i3_2 < count_students; i3_2++)
            {
                Console.WriteLine($"введите вес ученика: {i3_2 + 1}");
                double weight = Convert.ToDouble(Console.ReadLine());
                if(weight < 30)
                {
                    c3_2 += 0.2;
                }
            }
            Console.WriteLine($"добавить молока: {c3_2}");
            //6 задача 2 уровень
            Console.WriteLine("введите количество точек: ");
            double count_tocek = Convert.ToDouble(Console.ReadLine());
            for (int i6_2 = 0; i6_2 < count_tocek; i6_2++)
            {
                Console.WriteLine($"введите координату x точки:  {i6_2+1}");
                double x6_2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"введите координату y точки:  {i6_2+1}");
                double y6_2 = Convert.ToDouble(Console.ReadLine());
                if (x6_2 <= Math.PI && x6_2 > 0 && y6_2 >= 0 && y6_2 <= Math.Sin(x))
                {
                    Console.WriteLine($"точка {i6_2+1} подходит");

                }
                else
                {
                    Console.WriteLine($"точка {i6_2+1}  не подходит");
                }
            }


            //9 задача 2 уровень
            Console.WriteLine("введите количество участников: ");
            int count_plav = Int32.Parse(Console.ReadLine());
            double min_vreme = 10000;
            for (int i9_2 = 0; i9_2 < count_plav; i9_2++)
            {
                Console.WriteLine($"введите результат {i9_2+1} участника: ");
                double ckorost = Convert.ToDouble(Console.ReadLine());
                min_vreme = Math.Min(ckorost, min_vreme);

            }
            Console.WriteLine($"минимальный результат: {min_vreme}");
        }
    }
}