using System;

class program
{
    static void Main(String[] args)
    {
        string a;
        int b;
        Console.WriteLine("Укажите номер тролейбуса,для которого Вам нужно знать конечную остановку?(1-4)");

        a = Console.ReadLine();
        b=Convert.ToInt32(a);   

        if(b==1)
        {
            Console.WriteLine("Конечная остановка тролейбуса номер 1-Криулина.");
        }
        else if (b == 2)
        {
            Console.WriteLine("Конечная остановка тролейбуса номер 2-Бульвар Непокоренных.");
        }
        else if (b ==3)
        {
            Console.WriteLine("Конечная остановка тролейбуса номер 3-Шмидта.");
        }
        else if (b==4)
        {
            Console.WriteLine("Конечная остановка тролейбуса номер 4-Проспект Мира.");
        }
        else
        {
            Console.WriteLine("Вы ввели бред");
        }
    }
}

