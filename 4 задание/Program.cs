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
            char[,] game = new char[3, 3];
            game[0, 0] = '·'; game[0, 1] = '·';  game[0, 2] = 'O';
            game[1, 0] = 'X'; game[1, 1] = 'X';  game[1, 2] = 'X';
            game[2, 0] = 'O'; game[2, 1] = '·';  game[2, 2] = 'O';
            Console.WriteLine("Крестики нолики");   
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(game[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                int winner = 0;
            //строка
            for (int i = 0; i < 3; i++)
            {
                if (game[i, 0] != '·' && game[i, 0] == game[i, 1] && game[i, 1] == game[i, 2])
                {
                    winner = game[i, 0];
                    break; 
                }
            }
            //столбец 
            if (winner == '0')
            {
                for (int j = 0; j < 3; j++)
                {
                    if (game[0, j] != '·' && game[0, j] == game[1, j] && game[1, j] == game[2, j])
                    {
                        winner = game[0, j];
                        break;
                    }
                }
            }
            //Главная диагональ
            if (winner == '0' && game[0, 0] != '·' && game[0, 0] == game[1, 1] && game[1, 1] == game[2, 2])
            {
                winner = game[0, 0];
            }
            //Побочная диагональ 
            if (winner == '0' && game[0, 2] != '·' && game[0, 2] == game[1, 1] && game[1, 1] == game[2, 0])
            {
                winner = game[0, 2];
            }
            if (winner == 'X')
            {
                Console.WriteLine("Победитель — крестики");
            }
            else if (winner == 'O')
            {
                Console.WriteLine("Победитель — нолики");
            }
            else
            {
                Console.WriteLine("Победителя нет");
            }
        }

    }
}


