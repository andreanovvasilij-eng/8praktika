using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int M = 4;
                int N = 4;
                int[,] matrix = new int[M, N];
                Random random = new Random();
                Console.WriteLine("Матрица M на N");
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        matrix[i, j] = random.Next(1, 101);
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                bool SaddleDot = false;
                for (int i = 0; i < M; i++)
                {
//строка
                    int min = matrix[i, 0];
                    for (int j = 1; j < N; j++)
                    {
                        if (matrix[i, j] < min)
                        {
                            min = matrix[i, j];
                        }
                    }
                    for (int j = 0; j < N; j++)
                    {
                        if (matrix[i, j] == min)
                        {
// столбец
                            bool Max = true;
                            for (int k = 0; k < M; k++)
                            {
                                if (matrix[k, j] > matrix[i, j])
                                {
                                    Max = false;
                                    break;
                                }
                            }
                            if (Max)
                            {
                                Console.WriteLine($"Седловая точка в строке{i}, столбце {j}, значение = {matrix[i, j]}");
                                SaddleDot = true;
                            }
                        }
                    }
                }
                if (!SaddleDot)
                {
                    Console.WriteLine("Седловых точек нет");
                }
            }
        }
    }
        

   

