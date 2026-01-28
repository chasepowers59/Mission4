// See https://aka.ms/new-console-template for more information
// Team 11, tic tac toe game!! 
// Backend is Chase and Jay / supporting class
// Driver class is Josh and Spencer

using System;
using Mission4;

namespace Mission4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Welcome the user
            Console.WriteLine("Welcome to the Team 11 Tic-Tac-Toe Showdown!");
            Console.WriteLine("-------------------------------------------");

            // 2. Create the game board array (3x3)
            // Initializing with spaces so the board doesn't look empty/null
            char[,] gameBoard = new char[3, 3] 
            { 
                { ' ', ' ', ' ' }, 
                { ' ', ' ', ' ' }, 
                { ' ', ' ', ' ' } 
            };

            // Instantiate the supporting class
            TicTacTools tools = new TicTacTools();

            char currentPlayer = 'X';
            bool gameOver = false;
            int turns = 0;

            // 3. Game Loop
            while (!gameOver)
            {
                // Print the current board
                tools.PrintBoard(gameBoard);

                Console.WriteLine($"\nPlayer {currentPlayer}, it's your turn.");
                
                int row, col;
                while (true)
                {
                    try
                    {
                        Console.Write("Enter row (0-2): ");
                        row = int.Parse(Console.ReadLine());
                        Console.Write("Enter column (0-2): ");
                        col = int.Parse(Console.ReadLine());

                        if (row >= 0 && row <= 2 && col >= 0 && col <= 2 && gameBoard[row, col] == ' ')
                        {
                            break; // Valid input
                        }
                        Console.WriteLine("Invalid move! Try again.");
                    }
                    catch { Console.WriteLine("Please enter a valid number (0, 1, or 2)."); }
                }

                // Update the board
                gameBoard[row, col] = currentPlayer;
                turns++;

                // 4. Check for a winner
                char winner = tools.GameResults(gameBoard);

                if (winner != ' ')
                {
                    tools.PrintBoard(gameBoard);
                    Console.WriteLine($"\nHOORAY! Player {winner} wins the game!");
                    gameOver = true;
                }
                else if (turns == 9)
                {
                    tools.PrintBoard(gameBoard);
                    Console.WriteLine("\nIt's a draw! Nobody wins, but everyone had fun.");
                    gameOver = true;
                }
                else
                {
                    // Switch players
                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                }
            }

            Console.WriteLine("\nGame Over. Thanks for playing!");
        }
    }
}