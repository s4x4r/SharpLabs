using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double p;
            Console.WriteLine("Write A:");
            string a=Console.ReadLine();
            p=Convert.ToDouble(a);

            double o;
            Console.WriteLine("Write B:");
            string b = Console.ReadLine();
            o = Convert.ToDouble(b);

            double n;
            Console.WriteLine("Write B:");
            string c = Console.ReadLine();
            n = Convert.ToDouble(c);

            double v;
            Console.WriteLine("Write B:");
            string d = Console.ReadLine();
            v = Convert.ToDouble(d);


            M: Console.WriteLine("Write Operation(+,-,*,/)");
            string e= Console.ReadLine();

            switch (e)
            {
                case "+":
                    {
                        double E = (p / o) + (n / v);
                        Console.WriteLine(E);

                        Console.WriteLine("Do you want to perform another operation with these numbers?(1-yes, no-any other number)");
                        double u = int.Parse(Console.ReadLine());

                        if (u == 1)
                        {
                            goto M;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                        break;
                    }
                case "-":
                    {
                        double E = (p / o) - (n / v);
                        Console.WriteLine(E);

                        Console.WriteLine("Do you want to perform another operation with these numbers?(1-yes, no-any other number)");
                        double u = int.Parse(Console.ReadLine());

                        if (u == 1)
                        {
                            goto M;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                        break;
                    }
                case "*":
                    {
                        double E = (p / o) * (n / v);
                        Console.WriteLine(E);

                        Console.WriteLine("Do you want to perform another operation with these numbers?(1-yes, no-any other number)");
                        double u = int.Parse(Console.ReadLine());

                        if (u == 1)
                        {
                            goto M;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                        break;
                    }
                case "/":
                    {
                        double E = (p / o) / (n / v);
                        Console.WriteLine(E);

                        Console.WriteLine("Do you want to perform another operation with these numbers?(1-yes, no-any other number)");
                        double u = int.Parse(Console.ReadLine());

                        if (u == 1)
                        {
                            goto M;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error operation.");

                        Console.WriteLine("Do you want to perform another operation with these numbers?(1-yes, no-any other number)");
                        double u = int.Parse(Console.ReadLine());

                        if (u == 1)
                        {
                            goto M;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                        break;
                    }

            }
            
        }
    }
}