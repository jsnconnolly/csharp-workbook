using System;

namespace RockPaperScissors
{
    class Program           
    {
        public static int score1 = 0;
        public static int score2 = 0;  //default values

        public static void Main()
        
        {

                // run tests and print out if tests passed or not
            if(tests()){
                Console.WriteLine("Tests passed.");
            } else {
                Console.WriteLine("Tests failed.");
            }

            //your code to get user input and call CompareHands method here

            Console.WriteLine("Hello");
            Console.WriteLine("Enter Rock, Paper or Scissors");
            string hand1 = Console.ReadLine().ToLower();

            string hand2 = null;
            Random rnd = new Random();
                int rps = rnd.Next(0,3);  //hand2 is played by computer random

            //defines hand2 response to hand1 entry
            if (rps == 0)
            {
                hand2 = "rock";
            }
            else if (rps == 1)
            {
                hand2 = "paper";
            }
            else if (rps == 2)
            {
                hand2 = "scissors";
            }
                 
            
            
            Console.WriteLine(CompareHands(hand1, hand2));
            Console.WriteLine("Your Score:" + score1);
            Console.WriteLine("Computer Score:" + score2);
            Console.WriteLine("Play again Yes or No");
            string hand = Console.ReadLine().ToLower();
            if (hand=="yes")
            {
                Main(); //recurssion
            }
            else
            {
                Console.Read();
            }

        }
        
        public static string CompareHands(string hand1, string hand2)
        {    
            //all possibilities for palys, with win answer
            string win = null;
            if (hand1 == hand2)
            {
                Console.WriteLine("Computer played:");
                Console.WriteLine(hand2.ToString());
                win = "TIE!";
            }
            else if (hand1 == "paper" && hand2 == "rock" || hand1 == "rock" && hand2 == "scissors" || hand1 == "scissors" && hand2 == "paper")
            {
                Console.WriteLine("Computer played:");
                Console.WriteLine(hand2.ToString());
                score1++;
                win = "You Win!";
            }
            
            else if (hand1 == "rock" && hand2 == "paper" || hand1 == "scissors" && hand2 == "rock" || hand1 == "paper" && hand2 == "scissors")
            {
                Console.WriteLine("Computer played:");
                Console.WriteLine(hand2.ToString());
                score2++;
                win = "Computer Wins!";
            }
            else
            {
                //returns line without computer play
                Console.WriteLine("Invalid Selection");
                Main();
            }
           
            return win;
            
            
        }
         public static bool tests()
        {
            return
            CompareHands("Paper", "Paper") == "0" &&
            CompareHands("Paper", "Rock") == "1" &&
            CompareHands("Paper", "Sissors") == "2" &&
            CompareHands("Sissors", "Sissors") == "0" &&
            CompareHands("Sissors", "Paper") == "1" &&
            CompareHands("Sissors", "Rock") == "2" &&
            CompareHands("Rock", "Rock") == "0" &&
            CompareHands("Rock", "Sissors") == "1" &&
            CompareHands("Rock", "Paper") == "2";
        }
    }
}

