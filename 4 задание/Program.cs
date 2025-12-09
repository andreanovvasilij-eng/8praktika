using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
                   // Создаём игровое поле 3×3
                int[,] board = new int[3, 3];        
                board[0, 0] = 1; board[0, 1] = 1; board[0, 2] = 1;  
                board[1, 0] = 2; board[1, 1] = 0; board[1, 2] = 2;
                board[2, 0] = 0; board[2, 1] = 2; board[2, 2] = 0;
                Console.WriteLine("Игровое поле:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(board[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            int winner = 0;
                for (int i = 0; i < 3; i++)
                {
                    if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != 0)
                    {
                        winner = board[i, 0];
                        break;
                    }
                }
                if (winner == 0)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[0, j] == board[1, j] && board[1, j] == board[2, j] && board[0, j] != 0)
                        {
                            winner = board[0, j];
                            break;
                        }
                    }
                }

                if (winner == 0)
                {                 
                    if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != 0)
                    {
                        winner = board[0, 0];
                    }
                    else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != 0)
                    {
                        winner = board[0, 2];
                    }
                }
                Console.WriteLine();
                if (winner == 1)
                {
                    Console.WriteLine("Победитель — крестики (1)!");
                }
                else if (winner == 2)
                {
                    Console.WriteLine("Победитель — нолики (2)!");
                }
                else
                {
                    Console.WriteLine("Победителя нет.");
                }
            }
        }

    }


