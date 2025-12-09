using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Двумерные_Массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {                     
                int[,] array = new int[4, 4];
                int value = 1;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        array[i, j] = value++;
                    }
                }
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }

                    Console.WriteLine();
                }
            }
        }

    }


