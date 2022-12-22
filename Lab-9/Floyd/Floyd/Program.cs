using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System;

namespace FloydWarshallAlgorithm
{
    class FloydWarshallAlgo
    {

        public const int cst = 9999;

        private static void Print(int[,] distance, int verticesCount)
        {
            Console.WriteLine("Кратчайшее расстояния между каждой парой вершин:");

            for (int i = 0; i < verticesCount; ++i)
            {
                for (int j = 0; j < verticesCount; ++j)
                {
                    if (distance[i, j] == cst)
                        Console.Write("cst".PadLeft(7));
                    else
                        Console.Write(distance[i, j].ToString().PadLeft(7));
                }

                Console.WriteLine();
            }
        }

        public static void FloydWarshall(int[,] graph, int verticesCount)
        {
            int[,] distance = new int[verticesCount, verticesCount];

            for (int i = 0; i < verticesCount; ++i)
                for (int j = 0; j < verticesCount; ++j)
                    distance[i, j] = graph[i, j];

            for (int k = 0; k < verticesCount; ++k)
            {
                for (int i = 0; i < verticesCount; ++i)
                {
                    for (int j = 0; j < verticesCount; ++j)
                    {
                        if (distance[i, k] + distance[k, j] < distance[i, j])
                            distance[i, j] = distance[i, k] + distance[k, j];
                    }
                }
            }

            Print(distance, verticesCount);
        }
        static void Main(string[] args)
        {
            int[,] graph = 

            {
            { 0,cst,cst,3,1,cst},
            { cst,0,3,1,5,6},
            { cst,3,0,4,cst,2},
            { 3,1,4,0,cst,cst},
            { 1,5,cst,cst,0,cst},
            { cst,6,2,cst,cst,0}
        };



            FloydWarshall(graph, 6);
            Console.ReadKey();

        }
    }
}