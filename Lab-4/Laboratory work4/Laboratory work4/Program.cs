using System;

namespace Program
{
    class Program
    {
        static void Main(String[] args)
        {
            uint First,i;
            uint ob;
            First = 10;
            double Second,p;
            Second = 9;

            Console.WriteLine("Изменение скорости первого:");
            for (i = 1; i <4;i++)
            {

               First++;
               System.Console.WriteLine(First);  
            }
            Console.WriteLine("Изменение скорости второго:");
            for (p=1;p<4;p++)
            {
                Second+=1.6;
                System.Console.WriteLine(Second); 
            }
            Console.WriteLine("Итоговая скорость первого:" + First + "\nИтоговая скорость второго:" + Second + "\nДогонит второй первого на втором часу.");
            }
        }
    }
