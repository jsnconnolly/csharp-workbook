using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            string word = "";
            
            
            Console.WriteLine("Translate to Pig Latin, Enter a word {0}", word);
            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        public static string TranslateWord(string word)
        {
            Console.WriteLine(word + "ay");
            return word;
        }
    }
}
