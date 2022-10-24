using System;

class program
{
    static void Main(String[] args)
    {
        string x;
        int y;
        Console.WriteLine("Введите x");
        x=Console.ReadLine();
       
        
        switch(x)
        {
            case 0 <= x && x < 5:
                {
                    y = (Math.Sqrt (x + 1) * (x + 1) + 5);
                    Console.WriteLine(y); 
                    break;
                }
            case 5 <= x < 10:
                {
                    y = Math.Log * (x / 2);
                    Console.WriteLine(y);
                    break;
                }
            case 10 <= x < 15:
                {
                    y = (Math.Tan * x);
                    Console.WriteLine(y);
                    break;
                }
            case 15 <= x < 20:
                {
                    y = (Math.Sqrt(x + (Math.PI / 2)));
                    Console.WriteLine(y);
                    break;
                }

        }
        

    }
}

