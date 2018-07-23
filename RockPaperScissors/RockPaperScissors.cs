using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        
        {

            Console.WriteLine("Rock, Paper or Scissors?:");
            string hand1 = Console.ReadLine().ToLower();

            string hand2 = null;
            Random rnd = new Random();
                int rps = rnd.Next(0,2); 

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
                 
            
            Console.WriteLine("Computer played:");
            Console.WriteLine(hand2.ToString());
            Console.WriteLine(CompareHands(hand1, hand2));
        
        }
        
        public static string CompareHands(string hand1, string hand2)
        {    
            
            string win = null;
            if (hand1 == hand2)
            {
               win = "TIE!";
            }
            else if (hand1 == "paper" && hand2 == "rock" || hand1 == "rock" && hand2 == "scissors" || hand1 == "scissors" && hand2 == "paper")
            {
                win = "You Win!";
            }
            
            else if (hand1 == "rock" && hand2 == "paper" || hand1 == "scissors" && hand2 == "rock" || hand1 == "paper" && hand2 == "scissors")
            {
                win = "Computer Wins!";
            }
           
            return win;
            
        }
    }
}