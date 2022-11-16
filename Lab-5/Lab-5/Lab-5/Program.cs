using System;

class Triangle
{
    public void GetSquare()//вычислить площадь
    {
        double[] x=new double[3];//объявление переменной
        double[] y = new double[3];//объявление переменной

        Console.WriteLine("Координата 1 точки треугольника:");
        Console.Write("X = ");
        x[1] = double.Parse(Console.ReadLine());
        Console.Write("Y = ");
        y[1] = double.Parse(Console.ReadLine());

        Console.WriteLine("Координата 2 точки треугольника:");
        Console.Write("X = ");
        x[2] = double.Parse(Console.ReadLine());
        Console.Write("Y = ");
        y[2] = double.Parse(Console.ReadLine());

        Console.WriteLine("Координата 3 точки треугольника:");
        Console.Write("X = ");
        x[3] = double.Parse(Console.ReadLine());
        Console.Write("Y = ");
        y[3] = double.Parse(Console.ReadLine());

        double a = GetSide(x[0], y[0], x[1], y[1]);//точка а
        double b = GetSide(x[1], y[1], x[2], y[2]);//точка б
        double c = GetSide(x[2], y[2], x[0], y[0]);//точка с
        double P = a + b + c;//периметр треугольника
        double p = P / 2;
        double s=Math.Sqrt(p)*(p-a)*(p-b)*(p-c);
    }

        
    public void GetXPos()//вернуть координату X вершины прямоугольника
    {

    }
    public void GetYPos()//вернуть координату Y вершины прямоугольника
    {

    }
    public void GetTriangleAngle()//вернуть значение угла прямоугольника
    {

    }
    public void SetClassName()//задать имя класса
    {

    }
    public void AllMetod()//исп.все методы в одном
    {

    }

    static double GetSide(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}

