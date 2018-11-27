using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()

        {

               // run tests and print out if tests passed or not
            if(tests()){
                Console.WriteLine("Tests passed.");
            } else {
                Console.WriteLine("Tests failed.");
            }

            //your code to get user input and call CompareHands method here

            Console.WriteLine("Enter hand 1:");
            Console.WriteLine("Rock, Paper or Sissors?:");
            string hand1 = Console.ReadLine().ToLower();
            //Console.WriteLine("Enter hand 2:");	            
            string hand2 = null;
            

            Random rnd = new Random();
            int rps = rnd.Next(0, 3);
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
                hand2 = "sissors";
            }

            


            Console.WriteLine("Computer played: {0}", hand2);
            int compare = CompareHands(hand1, hand2);
            if (compare == 0)
            {
                Console.WriteLine("It's a Tie!");
            }
            else if (compare == 1)
            {
                Console.WriteLine("You Win!");
            }
            else if (compare ==2)
            {
                Console.WriteLine("The Computer Won!");
            }    
        }
// this method returns 1 if hand1 returns 2 if hand 2 returns 0 if a tie
        public static int CompareHands(string hand1, string hand2)
        {

            string win = null;
            if (hand1 == hand2)
            {
                //win = "TIE!";
                return 0;
            }
            else if (hand1 == "paper" && hand2 == "rock" || hand1 == "rock" && hand2 == "sissors" || hand1 == "sissors" && hand2 == "paper")
            {
                //win = "The Human Won!";
                return 1;
            }

            else if (hand1 == "rock" && hand2 == "paper" || hand1 == "sissors" && hand2 == "rock" || hand1 == "paper" && hand2 == "sissors")
            {
               // win = "The Computer Won!";
                return 2;
            }

            return 0;
        }

        public static bool tests()
        {
            return
            CompareHands("paper", "paper") == 0 &&
            CompareHands("paper", "rock") == 1 &&
            CompareHands("paper", "sissors") == 2 &&
            CompareHands("sissors", "sissors") == 0 &&
            CompareHands("sissors", "paper") == 1 &&
            CompareHands("sissors", "rock") == 2 &&
            CompareHands("rock", "rock") == 0 &&
            CompareHands("rock", "sissors") == 1 &&
            CompareHands("rock", "paper") == 2;
        }
    }
}