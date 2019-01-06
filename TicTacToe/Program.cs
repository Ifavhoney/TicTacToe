using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static char[] board = { '0', '1', '2','3','4','5','6','7','8','9'};
        static int player = 1;
        static bool gameOver = false;
        static int turn;


        static void Main(string[] args)
        {
            Console.WriteLine("Player 1 is by the Default X");
            Console.WriteLine("Player 2 is by the Default O\n");
            Console.WriteLine("This is Your Current Board");
            updateBoard();


            do
            {
                
                    updateBoard();

                



            } while (gameOver == false);

        }

        static void updateBoard()
        {
            Console.WriteLine("|{0}|{1}|{2}|\n" +
               "|{3}|{4}|{5}|\n" +
               "|{6}|{7}|{8}|", board[1], board[2], board[3], board[4], board[5], board[6], board[7], board[8], board[9]);
        }
    }
}
