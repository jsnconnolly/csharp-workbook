using System;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
    {
        Console.WriteLine("Enter a word/sentence to convert to PigLatin:");
        string sentence = Console.ReadLine();
        string pigLatin = ToPigLatin(sentence);
        Console.WriteLine(pigLatin);
    }

    static string ToPigLatin (string sentence)
    {            
        string firstLetter,
               restOfWord,
               vowels = "AEIOUaeio";
        int currentLetter;

        foreach (string word in sentence.Split())
        {
            firstLetter = sentence.Substring(0, 1);
            restOfWord = sentence.Substring(1, sentence.Length - 1);
            currentLetter = vowels.IndexOf(firstLetter);

            if (currentLetter == -1)
            {
                sentence = restOfWord + firstLetter + "ay";
            }
            else
            {
                sentence = word + "yay";
            }
        }
    
            return sentence;
        }
    }
}
            //leave this command at the end so your program does not close automatically
            //Console.ReadLine();
        //}
        
        //public static string TranslateWord(string word)
        //{
            // your code goes here
           // return word;
        //}
   // }
//}
