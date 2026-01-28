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
                    Console.Write($"{board[row, col]}");
                    if (col < 2)
                    {
                        Console.WriteLine("|"); // this will seperate the columns 
                    }
                    Console.WriteLine();

                    if (row < 2)
                    {
                        Console.WriteLine("---+---+---"); // row separator
                    }
                }
            }
        }
    public bool ValidInput(string userInput) // validate 1 letter, not a number
        {
            bool result = true;

            if (userInput.Length > 1 || userInput.Length < 0)
            {
                Console.WriteLine("Guess cant be more than 1 letter");
                result = false;
            }
            else if (!userInput.All(char.IsLetter))
            {
                Console.WriteLine("Input must be a letter");
                result = false;
            }

                return result;
        }
    public string GameResults(string[] gameboard)
        {
            string gameResults = "";


            return gameResults;

        }

    }
}
