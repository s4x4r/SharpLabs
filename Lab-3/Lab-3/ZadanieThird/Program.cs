using System;


class program
{
    static void Main(String[] args)
    {
        string x, Condition;
        double y,X;
        Console.WriteLine("Введите x");
        x=Console.ReadLine();
        X= Convert.ToDouble(x);
        Console.WriteLine("Выберите условие:\n 1)0 <= x && x < 5\n2)5 <= x < 10\n3)10 <= x < 15\n4)15 <= x < 20");
        Condition =Console.ReadLine();

        switch (Condition)
        {
            case "1":
                {
                    Console.WriteLine("0 <= x && x < 5");
                    y = (Math.Sqrt (X + 1) * (X + 1) + 5);
                    Console.WriteLine(y); 
                    break;
                }
            case "2":
                {
                    Console.WriteLine("5 <= x < 10");
                    y = (Math.Log  (X / 2));
                    Console.WriteLine(y);
                    break;
                }
            case "3":
                {
                    Console.WriteLine("10 <= x < 15");
                    y = Math.Tan(X);
                    Console.WriteLine(y);
                    break;
                }
            case "4":
                {
                    Console.WriteLine("15 <= x < 20");
                    y = (Math.Sqrt(X + (Math.PI / 2)));
                    Console.WriteLine(y);
                    break;
                }
            default:
                {
                    Console.WriteLine("Вы ввели бред");
                    break;
                }


        }
        

    }
}

