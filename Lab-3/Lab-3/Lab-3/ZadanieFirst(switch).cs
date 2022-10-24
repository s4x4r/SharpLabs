using System;

class Program
{



    static void Main(String[] args)
    {
        string a;
        

        Console.WriteLine("Укажите номер тролейбуса,для которого Вам нужно знать конечную остановку?(1-4)");

        a=Console.ReadLine();
        

        switch(a)
        {
            case "1":
                {
                    Console.WriteLine("Конечная остановка тролейбуса номер 1-Криулина.");
                    break;
                }
            case "2":
                {
                    Console.WriteLine("Конечная остановка тролейбуса номер 2-Бульвар Непокоренных.");
                    break;
                }
            case "3":
                {
                    Console.WriteLine("Конечная остановка тролейбуса номер 3-Шмидта.");
                    break;
                }
            case "4":
                {
                    Console.WriteLine("Конечная остановка тролейбуса номер 4-Проспект Мира.");
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



