namespace lab2Bondarkov
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            double x, y,d;

            Console.WriteLine("Введите x(-0.35 & 1,5):\n");

            str = Console.ReadLine();

            x = Convert.ToDouble(str);

            Console.WriteLine("Введите y(-1,318):\n");

            str = Console.ReadLine();

            y = Convert.ToDouble(str);

            d =  -Math.Pow(Math.E, -Math.Cos(Math.Sqrt(x + (5 / 3))))  -  1.7 * (Math.Atan((x/5)-(3/4)))*Math.Sin(1.7)*x;
            Console.WriteLine("Ответ"+d);
        }
    }
}


