using System;
using System.Collections.Generic;
using System.Text;
// need method that prints the board based on the info passed to it (x or o string from user)

namespace Mission4
{
    internal class TicTacTools
    {
    public void PrintBoard(char[,] board) // method to print the board based on what is passed to it (array)
        { // we need to print the board, 
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($" {board[row, col]} ");
                    if (col < 2)
                    {
                        Console.Write("|"); // this will seperate the columns 
                    }
                }

                Console.WriteLine();

                if (row < 2)
                {
                    Console.WriteLine("---+---+---"); // row separator
                }

            }
        }
  
    public char GameResults(char[,] board)
        {
            // check rows
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] != ' ' && board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2]) return board[row, 2];
            }
            // check column
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] != ' ' && board[0, col] == board[1, col] && board[1, col] == board[2, col]) return board[0, col];
            }
            // Check diagonals
            if (board[0, 0] != ' ' &&
                board[0, 0] == board[1, 1] &&
                board[1, 1] == board[2, 2])
                return board[0, 0];

            if (board[0, 2] != ' ' &&
                board[0, 2] == board[1, 1] &&
                board[1, 1] == board[2, 0])
                return board[0, 2];

            // No winner
            return ' ';
        }

    }
}
