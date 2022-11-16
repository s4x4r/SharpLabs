using System;

class Program
{
    static void Main()
    {
        double[] x = new double[3];
        double[] y = new double[3];
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Координата {0}-ой точки треугольника:", i + 1);
            Console.Write("X = ");
            x[i] = double.Parse(Console.ReadLine());
            Console.Write("Y = ");
            y[i] = double.Parse(Console.ReadLine());
        }
        double a = GetSide(x[0], y[0], x[1], y[1]);
        double b = GetSide(x[1], y[1], x[2], y[2]);
        double c = GetSide(x[2], y[2], x[0], y[0]);
        double p = a + b + c;
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
        Console.WriteLine("c = {0}", c);
        Console.WriteLine("P = {0}", p);
        p /= 2d;
        Console.WriteLine("S = {0}", Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
    }

    static double GetSide(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}