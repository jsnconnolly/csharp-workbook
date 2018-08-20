using System;

namespace Checkpoint1
{
    class Program
    {
        public static int sumTotal = 0;
        public static Random random = new Random();
        public static int returnValue = random.Next(1, 10);

        
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

        //run numbers 1-100 divisible by 3
        static void divBy3()
        {
        for (int i = 1; i <= 100; i++)
        
            if (i % 3 == 0)
        { 
            Console.WriteLine(i);
        }
        }
        //enter a number and calculate sum of that number
        static void sumCalc()
        {            

        Console.WriteLine("Enter a number or OK");
        string input = Console.ReadLine();

        if (input.ToLower() == "ok")
        {
        Console.ReadLine();
        }
        else 
        {
        int numVal = Int32.Parse(input);        
        sumTotal = numVal + sumTotal;
        Console.WriteLine(sumTotal);
        sumCalc();
        }
    }
        
        
        
        //enters number and calculates and multiplys by all lower numbers
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

        ///int returnValue = random.Next(1, 10); made int public static in main class so string names can be used again

        
        Console.WriteLine(returnValue);
        Console.WriteLine("Guess a Number Between 1 and 10");
        string randomInput = Console.ReadLine();
        int Guess = Convert.ToInt32(randomInput);

        if (Guess != returnValue)
        {

            if (Guess < returnValue)
            {
                Console.WriteLine("No, Higher than " + Guess + ". Can you guess what it is?");
                guessNum();
            }
            else if (Guess > returnValue)
            {
               Console.WriteLine("No, Lower than " + Guess + ". Can you guess what it is?");
               guessNum();
            }

        }
        else if (Guess == returnValue)
        {
            Console.WriteLine("Well done! The answer was " + returnValue);
            Console.ReadLine();     
        }

        
        }

        //finding max number, while converting a string into an array
        static void findMax()
        {
        Console.WriteLine("Enter a range of numbers separatd by commas");
        string maxInput = Console.ReadLine();
        
        string[] tokens = maxInput.Split(',');
        int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);

        Array.Sort (convertedItems);
        Console.WriteLine ("The largest number is: \n" + convertedItems [convertedItems.Length - 1]);
        }


        
    }
}

