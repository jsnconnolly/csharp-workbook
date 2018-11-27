using System;

namespace PolyMorph
{
    class Program
    {
        public static void Main()
        {
            Music music = new Music();
            Console.WriteLine(music.bandName());
            Console.WriteLine(music.genre());
            
            jazzband jazzMessengers = new jazzband();
            Console.WriteLine(jazzMessengers.bandName());
            Console.WriteLine(jazzMessengers.genre());
            
        }
    
    public class Music
    {
        public virtual String bandName (){ return "Default Music";}
        public virtual String genre (){ return "Default Genre";}
        

        
        public virtual String greetings()
        {
            return "hello there!";
        }
    }

    public class jazzband : Music
    {
        public override string genre() {return "Jazz";}
        public override string bandName() {return "the jazz boyes";}
         public override string  greetings() {return  "Bebop" ;}

        }   
    }
}



