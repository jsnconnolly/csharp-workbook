using System;
using System.IO;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = System.IO.File.ReadAllText(@"C:\Users\jasonconnolly\Desktop\words.txt");
            //System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

        
        // Read each line of the file into a string array. Each element
        // of the array is one line of the file
        string[] lines = System.IO.File.ReadAllLines(@"//Users/jasonconnolly/Desktop/words.txt");

        // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of words.txt = ");
            foreach (string line in lines)
            {
            // Use a tab to indent each line of the file.
            Console.WriteLine("\t" + line);
            }
            //Create a new random that grabs a random string from the file's list
            Random hiddenRand = new Random();
            string hiddenAnswer = lines[hiddenRand.Next(lines.Length)]; 
            var answerIndex = Array.FindIndex(lines, line => line.Contains(hiddenAnswer));
            Console.WriteLine(answerIndex);


            Console.WriteLine(hiddenAnswer);

            Console.WriteLine("Make A Guess...");
            string hiddenGuess = Console.ReadLine().ToLower();

            var guessIndex = Array.FindIndex(lines, line => line.Contains(hiddenGuess));
            Console.WriteLine(guessIndex);
            if

        // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
