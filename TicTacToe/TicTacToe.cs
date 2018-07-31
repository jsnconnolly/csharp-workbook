using System;

namespace TicTacToe
{
    class Program
    {
        public static string playerTurn = "X";
        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}

        };

        public static void Main()
        {
            do
            {
              /*swap player turn ? Does this make sence to execute*/
             
                DrawBoard();
                GetInput();
            /*loop */
            } while (!CheckForWin() && !CheckForTie());

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static void GetInput()
        {
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            
            string input = Console.ReadLine();
            // limits input to 0, 1, 2
             bool sweet = false;
            while(sweet == false) 
                Console.Write("Please Enter 0 ,1 or 2");
                if(input == "0" || input == "1" || input == "2")
                {
                    sweet = true;
                    Console.Write("Sweet");
                }
             int row = int.Parse(input);
            //int row = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());
            
            PlaceMark(row, column);
             if (playerTurn == "O")
            {
                playerTurn = "X";
            }
            else
            {
                playerTurn = "O";
            }
            DrawBoard();
        }
        /*update board with correct value and position */
        public static void PlaceMark(int row, int column)
        {
            board[row][column] = playerTurn;
        // your code goes here
    

        }

        public static bool CheckForWin()
        {
            // your code goes here
            bool won = false;
            if(HorizontalWin() || VerticalWin() || DiagonalWin())
            {
                won = true;
                Console.Write("You Won!");
            }

            return won;
        }

        public static bool CheckForTie()
        {
            // checking for Tie
            bool tie = false;
            if(board [0][0] != " " && board [0][1] != " " && board [0][2] != " " && board [1][0] != " " && board [1][1] != " " && board [1][2] != " " && board [2][0] != " " && board [2][1] != " " && board [2][2] != " ")
        {
                tie = true;
                Console.Write("Tie!");
        }
            return tie;
        }
        /*this method will return true when any row has three of a kind in said row otherwise it will return false */
        
        public static bool HorizontalWin()
        {
            /* if cells are empty what happens, make sure empty does not count as win */

            bool WonHorizontally = false;
            if(board [0][0] == board[0][1] && board [0][1] == board [0][2] && board [0][0] != " " && board [0][1] != " " && board [0][2] != " ")
            {
                //Console.Write("Horizon one");
                WonHorizontally = true;
            }
            else if(board [1][0] == board[1][1] && board [1][1] == board [1][2] && board [1][0] != " " && board [1][1] != " " && board [1][2] != " ")
            {
                //Console.Write("Horizon two");
                WonHorizontally = true;
            }
            else if(board [2][0] == board[2][1] && board [2][1] == board [2][2] && board [2][0] != " " && board [2][1] != " " && board [2][2] != " ")
            {
                //Console.Write("Horizon three");
                WonHorizontally = true;
            }
            //Console.Write("Horizontal Won");
            return WonHorizontally;

        }

        public static bool VerticalWin()
        {
            bool WonVertically = false;
            if(board [0][0] == board[1][0] && board [1][0] == board [2][0] && board [0][0] != " " && board [1][0] != " " && board [2][0] != " ")
            {
                WonVertically = true;
            } 
            else if(board [0][1] == board[1][1] && board [1][1] == board [2][1] && board [0][1] != " " && board [1][1] != " " && board [2][1] != " ")
            {
                WonVertically = true;
            }
            else if(board [0][2] == board[1][2] && board [1][2] == board [2][2] && board [0][2] != " " && board [1][2] != " " && board [2][2] != " ")
            {
                WonVertically = true;
            }
            //0Console.Write("Vertical Won");
            return WonVertically;
        }

        public static bool DiagonalWin()
        {
             bool WonDiagonally = false;
            if(board [0][0] == board[1][1] && board [1][1] == board [2][2] && board [0][0] != " " && board [1][1] != " " && board [2][2] != " ")
            {
                WonDiagonally = true;
            }
            else if(board [0][2] == board[1][1] && board [1][1] == board [2][0] && board [0][2] != " " && board [1][1] != " " && board [0][2] != " ")
            {
                WonDiagonally = true;
            }
            //Console.Write("Diagonal Won");
            return WonDiagonally;
        }


        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }
    }
}
