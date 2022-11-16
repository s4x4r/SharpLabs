using System;

class Program
{
     static void Main(string[]args)
    {
        Random rnd = new Random(DateTime.Now.Millisecond);
        int[] msv = (new int[10]).Select(i => rnd.Next(-50, 50)).ToArray();
        Console.WriteLine("Исходный массив:");
        foreach (int i in msv) Console.Write("{0} ", i);

        double count = 0;
        for (int i = 0; i < msv.Length; ++i)
        {
            if (msv[i] % 2 != 0)
                count += msv[i];
        }
        Console.Write("\n\nCуммa элементов массива с нечетными номерами : {0}\n\n", count);
    }
}