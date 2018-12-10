using System;
using System.Collections.Generic;

namespace PigLatin
{
    class Program
    {
        public static void Main(string[] args)
        {
               // run tests and print out if tests passed or not
            if(tests()){
                Console.WriteLine("Tests passed.");
            } else {
                Console.WriteLine("Tests failed.");
            }

            //your code to get user input and call TranslateWord method here

            string word = "";


            Console.WriteLine("Translate to Pig Latin, Enter a word {0}", word);
            word = Console.ReadLine();
            string pigLatin = ToPigLatin(word);
            Console.WriteLine(pigLatin);
            
        }

        public static string ToPigLatin(string word)
        {
            string vowels = "AEIOUaeio";
            string PigWorded = "";


            string firstLetter = word.Substring(0,1);
            
            Console.WriteLine(firstLetter);

            string restOfWord = word.Substring(1, word.Length -1);
            Console.WriteLine(restOfWord);

            int currentLetter = vowels.IndexOf(firstLetter);
            Console.WriteLine(currentLetter);
            if (currentLetter == -1)
            {
                PigWorded += (restOfWord + firstLetter + "ay");
            }
            else 
            {
                PigWorded += (word + "yay");
            }

            
            return PigWorded;

        }
         /**
            This method tests some examples against the 5 following rules,
            and returns true if all tests pass, otherwise returns false.

            rule 1: if it starts with a vowel add "yay" to the end
            rule 2: move all letter before the first vowel to the end, then add "ay" to the end
            rule 3: if it starts with a "y", treat the "y" as a consonant
            rule 4: if it does not start with a "y", treat the "y" as a vowel
            rule 5: if there are no vowels, add "ay" to the end (this is the same as rule 2) 
         */
        public static bool tests(){
            return 
                ToPigLatin("elephant") == "elephantyay" &&
                ToPigLatin("fox") == "oxfay" &&
                ToPigLatin("choice") == "oicechay" && 
                ToPigLatin("dye") == "yeday" && 
                ToPigLatin("bystander") == "ystanderbay" &&
                ToPigLatin("yellow") == "ellowyay" &&
                ToPigLatin("tsktsk") == "tsktskay";
        }
    }
}
