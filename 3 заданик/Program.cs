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
            Console.WriteLine("Введите значение M (Строка)");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение N (Столбец)");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[M, N];
            Random random = new Random();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = random.Next(1, 101);
                }
            }
            Console.WriteLine($"Массив {M} на {N}");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }           
            int[,] transposed = new int[N, M];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    transposed[j, i] = array[i, j];
                }
            }
            Console.WriteLine($"Транспортированный массив {N} на {M}");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(transposed[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}








    







