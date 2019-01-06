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
        static int checkBoards;


        static void Main(string[] args)
        {
            Console.WriteLine("Player 1 is by the Default X");
            Console.WriteLine("Player 2 is by the Default O\n");
            Console.WriteLine("This is Your Current Board");
            updateBoard();
            
            do
            {
                
                if (player %2 != 0)
                {
                    Console.Write("Player 1, please enter a slot: ");
                    board[0] = 'S';
                    int input = Int32.Parse(Console.ReadLine());
                    if (board[input] != 'X' && board[input] != 'O')
                    {
                        
                        board[input] = 'X';
                        checkBoards++;
                        player++;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a different slot");
                        continue;
                    }
                    
                }
                else
                {
                    Console.Write("Player 2, please enter a slot: ");
                    int input = Int32.Parse(Console.ReadLine());
                    if (board[input] != 'X' && board[input] != 'O')
                    {
                        board[input] = 'O';
                        checkBoards++;
                        player++;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a different slot");
                        continue;
                    }
                }
             
                 updateBoard();
                             

            } while (gameChecker() == false);

        }

       static bool gameChecker()
        {
            //Check if game is over
            for (int i = 0; i < board.Length; i++)
            {                            
                //check if all slots are checked
                if (checkBoards > 8)
                {
                    return gameOver = true;
                }
             
            }
            Console.WriteLine("Num of Missing Boards " + checkBoards);

            return gameOver = false;

        }

        static void updateBoard()
        {
            Console.WriteLine("|{0}|{1}|{2}|\n" +
               "|{3}|{4}|{5}|\n" +
               "|{6}|{7}|{8}|", board[1], board[2], board[3], board[4], board[5], board[6], board[7], board[8], board[9]);
        }
    }
}
