using System;

class program
{
    static void Main(String[] args)
    {
        string A;
        int c;
        Console.WriteLine("Введите A:");
        A = Console.ReadLine();
        c=Convert.ToInt32(A);

        string B;
        int d;
        Console.WriteLine("Введите B:");
        B = Console.ReadLine();
        d = Convert.ToInt32(B);
        int e = d + c;

        if(d>0 && c>0 && e<15)
        {
            int i;
            i = c * d;
            Console.WriteLine(i);
        }
        if(c<-3 || d<-3)
        {
            int o,p;
            o = c * c;
            p = d * d;
            Console.WriteLine(o + p);
        }
        else
        {
            if(c<d)
            {
                int y;
                y = d*d;
                c = 0;
                Console.WriteLine(y+c);
                
            }
            if (c > d)
            {
                int y;
                y = c * c;
                d = 0;
                Console.WriteLine(y + d);

            }
        }

    }

}

