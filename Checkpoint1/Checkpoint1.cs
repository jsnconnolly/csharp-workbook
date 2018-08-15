using System;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            //project selector menu
            Console.WriteLine("Select A Program");
            Console.WriteLine("1 - divBy3");
            Console.WriteLine("2 - sumCalc");
            Console.WriteLine("3 - factoral");
            Console.WriteLine("4 - guessNum");
            Console.WriteLine("5 - findMax");
            string input = Console.ReadLine();
            
            
            if (input == "1")
            {
                divBy3();
            }
            
            else if(input == "2")
            {
                sumCalc();
            }
            else if(input == "3")
            {
                factoral();
            }
            else if(input == "4")
            {
                guessNum();
            }
            else if(input == "5")
            {
                findMax();
            }

        }

        static void divBy3()
        {
        for (int i = 1; i <= 100; i++)
        
            if (i % 3 == 0)
        { 
            Console.WriteLine(i);
        }
        }
        
        static void sumCalc()
        {
        // next function here
        }
        
        
        
        static void factoral()
        {
        int sum=1;
        Console.WriteLine("enter a number:");
        int z = int.Parse(Console.ReadLine());
        for (int i = 1; i <= z; i++)
        {
        sum=sum*i; 
        }
        Console.WriteLine("the factorial of {0} is :{1} ",z,sum);
        Console.Read();
        }    
    

      static void guessNum()
        {  
        Random random = new Random();

        int returnValue = random.Next(1, 10);

        int Guess = 0;

        Console.WriteLine("Guess a Number Between 1 and 10");

        while (Guess != returnValue)
        {
            Guess = Convert.ToInt32(Console.Read());

            if (Guess < returnValue)
            {
                Console.WriteLine("No, Higher" + Guess + ". Can you guess what it is?");
            }
            else if (Guess > returnValue)
            {
                Console.WriteLine("No, Lower" + Guess + ". Can you guess what it is?");
            }

        }

        Console.WriteLine("Well done! The answer was " + returnValue);
        Console.ReadLine();     
         // next function here
        }

        static void findMax()
        {
        int[] maxArray = {5, 1, 3, 8, 4, 11011};
        Array.Sort (maxArray);
        Console.WriteLine ("The largest number is: \n" + maxArray [maxArray.Length - 1]);
        // next function here
        }


        
    }
}

