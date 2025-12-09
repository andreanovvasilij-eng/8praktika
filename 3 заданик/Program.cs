using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_заданик
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
           
                int M = 3;
                int N = 4; 
                int[,] original = new int[M, N];
          Random rand = new Random();
                Console.WriteLine("Исходный массив ({0} на {1}):", M, N);
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        original[i, j] = rand.Next(1, 101);
                        Console.Write($"{original[i, j],4}");
                    }
                    Console.WriteLine();
                }
                int[,] transposed = new int[N, M];
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        transposed[j, i] = original[i, j];
                    }
                }
                Console.WriteLine("Транспонированный массив ({0} на {1}):", N, M);
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        Console.Write($"{transposed[i, j],4}");
                    }
                    Console.WriteLine();
                }
            }
        }



    }







