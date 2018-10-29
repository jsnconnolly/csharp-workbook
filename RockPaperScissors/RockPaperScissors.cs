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
            Console.WriteLine(CompareHands(hand1, hand2));
        }

        public static int CompareHands(string hand1, string hand2)
        {

            string win = null;
            if (hand1 == hand2)
            {
                win = "TIE!";
            }
            else if (hand1 == "paper" && hand2 == "rock" || hand1 == "rock" && hand2 == "sissors" || hand1 == "sissors" && hand2 == "paper")
            {
                win = "The Human Won!";
            }

            else if (hand1 == "rock" && hand2 == "paper" || hand1 == "sissors" && hand2 == "rock" || hand1 == "paper" && hand2 == "sissors")
            {
                win = "The Computer Won!";
            }

            return 0;
        }

        public static bool tests()
        {
            return
            CompareHands("Paper", "Paper") == 0 &&
            CompareHands("Paper", "Rock") == 1 &&
            CompareHands("Paper", "Sissors") == 2 &&
            CompareHands("Sissors", "Sissors") == 0 &&
            CompareHands("Sissors", "Paper") == 1 &&
            CompareHands("Sissors", "Rock") == 2 &&
            CompareHands("Rock", "Rock") == 0 &&
            CompareHands("Rock", "Sissors") == 1 &&
            CompareHands("Rock", "Paper") == 2;
        }
    }
}