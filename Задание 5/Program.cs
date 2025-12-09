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
                Random rand = new Random();
                Console.WriteLine("Матрица:");
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        matrix[i, j] = rand.Next(1, 101);
                        Console.Write($"{matrix[i, j],4}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Седловые точки:");
                bool hasSaddle = false;

                for (int i = 0; i < M; i++) 
                {
                    int minInRow = matrix[i, 0];
                    int colOfMin = 0;

                    for (int j = 1; j < N; j++)
                    {
                        if (matrix[i, j] < minInRow)
                        {
                            minInRow = matrix[i, j];
                            colOfMin = j;
                        }
                    }
                    bool isMaxInCol = true;
                    for (int k = 0; k < M; k++)
                    {
                        if (matrix[k, colOfMin] > minInRow)
                        {
                            isMaxInCol = false;
                            break;
                        }
                    }
                    if (isMaxInCol)
                    {
                        Console.WriteLine($"Координаты: ({i}, {colOfMin}), значение: {minInRow}");
                        hasSaddle = true;
                    }
                }
                if (!hasSaddle)
                {
                    Console.WriteLine("Седловых точек нет.");
                }
            }
        }

   }


