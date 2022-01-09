using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7_TicTacToe_challenge
{
    class TicTacToe
    {
        private string[] boardArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private bool player = true;
        private int move = 0;
        private bool continueGame = true;

        public void PlayGame()
        {
            // Draw board at the beginning
            DrawBoard();
            Console.WriteLine("Insert exit to quit the game");
            while (continueGame)
            {
                // Start game
                SelectField();
            }
        }

        private void DrawBoard()
        {
            string[,] board = {
                { "   |   |  " },
                {$" {boardArray[0]} | {boardArray[1]} | {boardArray[2]}"},
                { "___|___|___" },
                { "   |   |  " },
                {$" {boardArray[3]} | {boardArray[4]} | {boardArray[5]}"},
                { "___|___|___" },
                { "   |   |  " },
                {$" {boardArray[6]} | {boardArray[7]} | {boardArray[8]}"},
                { "   |   |  " }
            };
            // Clear console before drawing new board
            Console.Clear();
            // Print board in the terminal
            foreach (string element in board)
            {
                Console.WriteLine(element);
            }
        }

        private void SelectField()
        {
            Console.WriteLine("Player {0}: Choose your field!", player ? "X" : "O");
            while (true)
            {
                string chosenField = Console.ReadLine();
                // Check if player entered an exit word:
                if (chosenField.Equals("exit")) 
                { 
                    continueGame = false;
                    break;
                }
                else
                {
                    // Check if chosenField is in boardArray
                    int idx = Array.IndexOf(boardArray, chosenField);
                    if (idx != -1)
                    {
                        boardArray.SetValue(player ? "X" : "O", idx);
                        player = !player;
                        move++;
                        DrawBoard();
                        CheckWin();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You have entered an invalid field! Try again...");
                    }
                }
            }
        }

        private void CheckWin()
        {
            if (move > 4)
            {
                // Check first row
                if (boardArray[0].Equals(boardArray[1]) && boardArray[1].Equals(boardArray[2]))
                {
                    Console.WriteLine("Player {0} won!", !player ? "X" : "O");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    ResetGame();
                }
                // Check second row
                else if (boardArray[3].Equals(boardArray[4]) && boardArray[4].Equals(boardArray[5]))
                {
                    Console.WriteLine("Player {0} won!", !player ? "X" : "O");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    ResetGame();
                }
                // Check third row
                else if (boardArray[6].Equals(boardArray[7]) && boardArray[7].Equals(boardArray[8]))
                {
                    Console.WriteLine("Player {0} won!", !player ? "X" : "O");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    ResetGame();
                }
                // Check first column
                else if (boardArray[0].Equals(boardArray[3]) && boardArray[3].Equals(boardArray[6]))
                {
                    Console.WriteLine("Player {0} won!", !player ? "X" : "O");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    ResetGame();
                }
                // Check second column
                else if (boardArray[1].Equals(boardArray[4]) && boardArray[4].Equals(boardArray[7]))
                {
                    Console.WriteLine("Player {0} won!", !player ? "X" : "O");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    ResetGame();
                }
                // Check third column
                else if (boardArray[2].Equals(boardArray[5]) && boardArray[5].Equals(boardArray[8]))
                {
                    Console.WriteLine("Player {0} won!", !player ? "X" : "O");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    ResetGame();
                }
                // Check first diagonal
                else if (boardArray[0].Equals(boardArray[4]) && boardArray[4].Equals(boardArray[8]))
                {
                    Console.WriteLine("Player {0} won!", !player ? "X" : "O");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    ResetGame();
                }
                // Check second diagonal
                else if (boardArray[2].Equals(boardArray[4]) && boardArray[4].Equals(boardArray[6]))
                {
                    Console.WriteLine("Player {0} won!", !player ? "X" : "O");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    ResetGame();
                }
                // There is a draw in the game!
                else if (move == 9)
                {
                    Console.WriteLine("Draw! Nobody won!");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    ResetGame();
                }
            }
        }

        private void ResetGame()
        {
            // Reset moves number
            move = 0;
            // Reset boardArray
            boardArray = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            // Draw new board
            DrawBoard();
        }
    }
}
