using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TextGame
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Welcome to the cavern of secrets!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            takerofstick();

        }

        static void takerofstick()
        {
            
            Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor.");
            Console.WriteLine("Do you take it? [y/n]: ");
            string userInput = Console.ReadLine();
            int stick;

            if (userInput.ToLower() == "yes")
            /*converts all inputs to lower case */
            {
                Console.WriteLine("You have taken the stick!");    
                stick = 1;
            }
            else
            {
                Console.WriteLine("You did not take the stick");
                stick = 0;
            }
        

            Console.WriteLine ("As you proceed further into the cave, you see a small glowing object");
            Console.WriteLine ("Do you approach the object? [y/n]");
        
        string chapter2 = Console.ReadLine();

       
            Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor.");
            Console.WriteLine("Do you take it? [y/n]: ");
       
/*# STICK TAKEN*/
            if (userInput.ToLower() == "yes")
            {
                Console.WriteLine("You have taken the stick!");
                stick = 1;
             }
/*# STICK NOT TAKEN*/
            else
            {
                Console.WriteLine("You did not take the stick");
                stick = 0;
            }
            Console.WriteLine("As you proceed further into the cave, you see a small glowing object");
            Console.WriteLine("Do you approach the object? [y/n]");
        }
    }
}

/*# APPROACH SPIDER
            if (userInput.ToLower() == "yes");
            {
                Console.WriteLine("You approach the object...");
                userInput = Console.ReadLine();
                Console.WriteLine("As you draw closer, you begin to make out the object as an eye!");
                userInput = Console.ReadLine();
                Console.WriteLine("The eye belongs to a giant spider!");
            }
            
        string chapter3 = Console.ReadLine("Do you try to fight it? [Y/N]");

   /* # FIGHT SPIDER
    if ch3 in ['y', 'Y', 'Yes', 'YES', 'yes']:

        # WITH STICK
        if stick == 1:
            Console. WriteLine ("You only have a stick to fight with!");
            Console.WriteLine ("You quickly jab the spider in it's eye and gain an advantage");
            time.sleep(2)
            Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine ("                  Fighting...                   ");
            Console.WriteLine ("   YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER    ");
            Console.WriteLine ("IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE");
            Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            time.sleep(2)
            fdmg1 = int(random.randint(3, 10))
            edmg1 = int(random.randint(1, 5))
            Console.WriteLine ("you hit a", fdmg1);
            Console.WriteLine ("the spider hits a", edmg1);
            time.sleep(2)

            if edmg1 > fdmg1:
                Console.WriteLine ("The spider has dealt more damage than you!");
                complete = 0
                return complete

            elif fdmg1 < 5:
                Console.WriteLine ("You didn't do enough damage to kill the spider, but you manage to escape");
                complete = 1
                return complete

            else:
                Console.WriteLine ("You killed the spider!");
                complete = 1
                return complete

        # WITHOUT STICK
        else:
            Console.WriteLine ("You don't have anything to fight with!");
            Console.WriteLinesleep(2);
            Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine ("                  Fighting...                   ");
            Console.WriteLine ("   YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER    ");
            Console.WriteLine ("IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE");
            Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            time.sleep(2)
            fdmg1 = int(random.randint(1, 8))
            edmg1 = int(random.randint(1, 5))
            Console.WriteLine ("you hit a", fdmg1)
            Console.WriteLine ("the spider hits a", edmg1)
            time.sleep(2)

            if edmg1 > fdmg1:
                Console.WriteLine ("The spider has dealt more damage than you!")
                complete = 0
                return complete

            elif fdmg1 < 5:
                Console.WriteLine ("You didn't do enough damage to kill the spider, but you manage to escape")
                complete = 1
                return complete

            else:
                Console.WriteLine ("You killed the spider!")
                complete = 1
                return complete

    #DON'T FIGHT SPIDER
    Console.WriteLine ("You choose not to fight the spider.")
    time.sleep(1)
    Console.WriteLine ("As you turn away, it ambushes you and impales you with it's fangs!!!")
    complete = 0
    return complete

# DON'T APPROACH SPIDER
else:
        Console.WriteLine ("You turn away from the glowing object, and attempt to leave the cave...")
        time.sleep(1)
        Console.WriteLine ("But something won't let you....")
        time.sleep(2)
        complete = 0
        return complete

# game loop
alive = True
while alive:

complete = game()
if complete == 1:
    alive = input('You managed to escape the cavern alive! Would you like to play again? [y/n]: ')
    if alive in ['y', 'Y', 'YES', 'yes', 'Yes',]:
        alive

    else:
        break

else:
    alive = input('You have died! Would you like to play again? [y/n]: ')
    if alive in ['y', 'Y', 'YES', 'yes', 'Yes',]:
        alive

    else:
        break

        }
    }
}
 */