using System;

namespace Inheretance
{
    class Animal {
        int numAppendages;
         public Animal(int numAppendages){
             this.numAppendages = numAppendages;
         }
    }
    class Vertebrates : Animal {
            public Vertebrates(int numAppendages){
                this. numAppendages = numAppendages;
    }
    class Invertebrates : Animal{

    }
    class WarmBlooded : Vertebrates{

    }
    class ColdBlooded : Vertebrates{

    }
    class WithJointedLegs : Invertebrates{

    }
    class WithOutLegs : Invertebrates{

    }
    class Mammals : WarmBlooded{
        bool liveOnLand;

    }
    class Birds : WarmBlooded{
        bool canFly;

    }
    class Fish : ColdBlooded{

    }
    class Reptiles : ColdBlooded{
        bool hasLegs;

    }
    class Amphibians : ColdBlooded{

    }
    class Whith3PairsofLegs : WithJointedLegs{

    }
    class WithMoreThan3PairsofLegs : WithJointedLegs{

    }
    class WormLike : WithOutLegs{

    }
    class NotWormLike : WithOutLegs{

    }


    class Program 
    {
        static void Main(string[] args)
        {
            Invertebrates  aLadyBug= new Invertebrates();
            Vertebrates me = new Vertebrates();
        }
    }
}
