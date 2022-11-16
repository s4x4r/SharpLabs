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
            for (i = 1; i <5;i++)
            {

               First++;
               System.Console.WriteLine(First);  
            }
            Console.WriteLine("Изменение скорости второго:");
            for (p=1;p<5;p++)
            {
                Second+=1.6;
                System.Console.WriteLine(Second); 
            }
            Console.WriteLine("Через 1 час первый спортсмен преодалеет больший путь, но на втором часу его нагонит второй и соответственно на 4 часу будет лидировать.");
            }
        }
    }
