using System;
class demo
{
    static void Main()
    {
        Console.WriteLine("введите строку : ");
        string str = Console.ReadLine();
        int begin = str.IndexOf('(') + 1;
        int end = str.LastIndexOf(')');
        if (begin != -1 && end != -1)
            for (; begin < end; begin++) Console.Write(str[begin]);
        else Console.WriteLine("неверный формат");
        Console.WriteLine();
        Console.ReadKey(true);
    }
}