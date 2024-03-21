using System;
using System.Drawing;

class Programm
{
    public struct Rectangle
    {
        private double _dlina = 0;
        private double _shirina = 0;
        public double Dlina { get { return _dlina; } set { _dlina = value; } }
        public double Shirina { get { return _shirina; } set { _shirina = value; } }
        public Rectangle(double[] arr)
        {
            Dlina = arr[0];
            Shirina = arr[1];
        }

        static void SP(double dlina, double shirina)
        {
            double P = (dlina + shirina) * 2;
            double S = dlina * shirina;
        }
        static void Sravnenie(Rectangle a, Rectangle b)
        {
            if (a._dlina > b._dlina)
            {
                Console.WriteLine($"Длиннее: {a}");
            }
            else { Console.WriteLine($"Длиннее: {b}"); }
            if (a._shirina > b._shirina)
            {
                Console.WriteLine($"Шире: {a}");
            }
            else { Console.WriteLine($"Шире: {b}"); }
        }

    }
    static void Main()
    {
        double[] rectangleA = new double[] { 1, 1 };
        double[] rectangleB = new double[] { 2, 3 };
        double[] rectangleC = new double[] { 3, 5 };

        Rectangle[] arr = { new Rectangle(rectangleA), new Rectangle(rectangleB), new Rectangle(rectangleC) };
        for(int i = 0; i < arr.Length - 1; i++)
        {
            Point.Sravnenie(arr[i], arr[i + 1]);
            Console.WriteLine();
        }

    }
}
//public abstract class Embrasure
//{
//    public string _name { get; set; }
//    public double _shirina { get; set; }
//    public double _length { get; set; }
//    public double _tolshina { get; set; }
//    public abstract double Cost();
//}

//class Door : Embrasure
//{
//    private bool _uzor = true;
//    private bool _glass = true;

//    public override double Cost()
//    {
//        double doorcost = _shirina * _length * _tolshina;
//        if (_uzor)
//        {
//            doorcost = _shirina * _length * _tolshina*5;
//        }
//        if (_glass)
//        {
//            doorcost = _shirina * _length * _tolshina * 10;
//        }
//        return doorcost;
//    }
//}

//class Window : Embrasure
//{
//    public int _sloi { get; set; }

//    public override double Cost()
//    {
//        _sloi++;
//        double windowCost = _sloi * _shirina * _length * _tolshina;
//        return windowCost;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {

//            Embrasure[] embrasures = new Embrasure[10];
//            for (int i = 0; i < 5; i++)
//            {
//                Door door = new Door();
//                door._name = "Door " + (i + 1);
//                door._shirina = 1.5 + i;
//                door._length = 2.0 + i;
//                door._tolshina = 0.1 + i * 0.05;

//                embrasures[i] = door;

//                Window window = new Window();
//                window._name = "Window " + (i + 1);
//                window._shirina = 1.0 + i;
//                window._length = 1.5 + i;
//                window._tolshina = 0.05 + i * 0.03;
//                window._sloi = 2 + i;
//                embrasures[i + 5] = window;
//            }


//        Console.WriteLine("{0, -10} {1, -10} {2, -10} {3, -10} {4, -10}", "Name", "Width", "Length", "Thickness", "Price");
//        foreach (Embrasure embrasure in embrasures)
//        {
//            Console.WriteLine("{0, -10} {1, -10} {2, -10} {3, -10} {4, -10}", embrasure._name, embrasure._shirina, embrasure._length, embrasure._tolshina, embrasure.Cost());
//        }

//    }
//}


