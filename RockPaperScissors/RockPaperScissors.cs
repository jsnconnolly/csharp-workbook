using System;

namespace RockPaperScissors
{
    class Program           
    {
        public static void Main()
        
        {	        
            Console.WriteLine("Enter hand 1:");	
            Console.WriteLine("Rock, Paper or Sissors?:");
            string hand1 = Console.ReadLine().ToLower();
            Console.WriteLine("Enter hand 2:");	            
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
                hand2 = "sissors";
            }
                 
            
            Console.WriteLine("Computer played: {0}", hand2);
            Console.WriteLine(CompareHands(hand1, hand2));
            // leave this command at the end so your program does not close automatically
            Console.ReadLine();	        
        }	        
        	        
        public static string CompareHands(string hand1, string hand2)
        {	
            Random rnd = new Random();
            int rock = rnd.Next(0,2); 
        
             
            
            string win = null;
            if (hand1 == hand2)
            {
               win = "TIE!";
            }
            else if (hand1 == "paper" && hand2 == "rock" || hand1 == "rock" && hand2 == "sissors" || hand1 == "sissors" && hand2 == "paper")
            {
                win = "You Win!";
            }
            
            else if (hand1 == "rock" && hand2 == "paper" || hand1 == "sissors" && hand2 == "rock" || hand1 == "paper" && hand2 == "sissors")
            {
                win = "Computer Wins!";
            }
           
            return win;
        }	        
    }	    
}	