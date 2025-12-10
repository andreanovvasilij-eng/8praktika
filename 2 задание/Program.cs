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
            Console.WriteLine("Введите размерность вашего массива N x N");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = random.Next(1, 101);
                }
            }
            Console.WriteLine("Массив");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            int sum1 = 0;
            for (int i = 0; i < N; i++)
            {
                sum1 += array[i, i];
            }
            Console.WriteLine("Сумма главной диагонали равна: " + sum1);
            int sum2 = 0;
            for (int i = 0; i < N; i++)
            {

                sum2 += array[i, N - 1 - i];

            }
            Console.WriteLine("Сумма побочной диагонали равна: " + sum2);

        }
    }
}
