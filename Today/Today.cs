using System;
using System.IO;

namespace Today
{
    class Today
    {
        static void Main(string[] args)
        {
           String file = @"/Users/jasonconnolly/Desktop/words.txt";
           String[] lines = File.ReadAllLines(file);
           //reading all lines and putting in an array

           int lineNo =0;
           foreach(String line in lines){
               lineNo +=1;
               Console.WriteLine(lineNo+"+line");
            //reading each line and then writing to the console
           }
            
            String copy= @"/Users/jasonconnolly/Desktop/.txt";
            File.WriteAllLines(copy, lines);
            //creates new file and puts into new file
        }
    }
}
