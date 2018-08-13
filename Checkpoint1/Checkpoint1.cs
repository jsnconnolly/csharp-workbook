using System;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
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
                //the next function
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
    




        
    }
}

