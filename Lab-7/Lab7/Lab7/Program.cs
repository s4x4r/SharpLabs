using System;

class Lab7
{
    static void Main(string[] args)
    {
        double m, M,i;

        string[] array0 = { "5", "541", "0", "1", "2", "875" };
        int[] array1=array0.Select(int.Parse).ToArray();
        Array.Sort(array1);

        Console.WriteLine(string.Join(", ", array1));

        m = array1.Max();
        M = array1.Min();
        i = array1.Average();

        Console.WriteLine( m-M );
        Console.WriteLine(i);
    }
}