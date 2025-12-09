using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 5;

            int[,] array = new int[N,N];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 101);
                }              
            }
        
            Console.WriteLine("Массив");
            for (int i = 0;i < array.GetLength(0); i++)
            {
                for (int j = 0;j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            int sumDiagonal1 = 0;
            for (int i = 0; i < N; i++)
            {
                sumDiagonal1 += array[i, i];
            }

            int sumDiagonal2 = 0;
            for (int i = 0; i < N; i++)
            {
                sumDiagonal2+= array[i, N - 1 - i];
            }
            Console.WriteLine("Сумма главной диагонали:" + sumDiagonal1);
            Console.WriteLine("Сумма побочной диагонали:" + sumDiagonal2);
        }
    }
}
