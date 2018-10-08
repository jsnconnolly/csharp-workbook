using System;
using System.Threading;

namespace TextGame
{
    class Program
    {
        static void Main(string[] args)
        {

            int stick = 0;

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Welcome to the cavern of secrets!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Thread.Sleep(3000);
            //time pause method in C#(millsec)

            Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor.");
            Console.WriteLine("Do you take it? [Y/N]");

            String ch1 = Console.ReadLine();

            if (ch1 == "Y" || ch1 == "y" || ch1 == "Yes" || ch1 == "YES" || ch1 == "yes")
            {
                Console.WriteLine("You have taken the stick");
                Thread.Sleep(2000);
                stick = 1;
            }
            else
            {
                Console.WriteLine("You did not take the stick");
                stick = 0;
            }

            Console.WriteLine("As you proceed further into the cave, you see a small glowing object");
            Console.WriteLine("Do you approach the object? [Y/N]");

            String ch2 = Console.ReadLine();

            if (ch2 == "Y" || ch2 == "y" || ch2 == "Yes" || ch2 == "YES" || ch2 == "yes")
            {
                Console.WriteLine("You approach the object...");
                Thread.Sleep(2000);
                Console.WriteLine("As you draw closer, you begin to make out the object as an eye!");
                Thread.Sleep(1);
                Console.WriteLine("The eye belongs to a giant spider!");
            }

            Console.WriteLine("Do you try to fight it? [Y/N]");

            String ch3 = Console.ReadLine();

            if (ch3 == "Y" || ch3 == "y" || ch3 == "Yes" || ch3 == "YES" || ch3 == "yes")
            {
                if (stick == 1)
                    Console.WriteLine("You only have a stick to fight with!");
                Console.WriteLine("You quickly jab the spider in it's eye and gain an advantage");
                Thread.Sleep(2000);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("                  Fighting...                   ");
                Console.WriteLine("   YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER    ");
                Console.WriteLine("IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Thread.Sleep(2000);

                Random rnd = new Random();
                int fdmg1 = rnd.Next(3, 10);
                int edmg1 = rnd.Next(1, 5);

                Console.WriteLine("you hit a {0}", fdmg1);
                Console.WriteLine("the spider hits a {0}", edmg1);
                Thread.Sleep(2000);
                //generates random ints in the range entered after .Next

                int complete = 0;

                if (edmg1 > fdmg1)
                {
                    Console.WriteLine("The spider has dealt more damage than you!");
                    complete = 0;
                    return;
                }
                else if (fdmg1 < 5)
                {
                    Console.WriteLine("You didn't do enough damage to kill the spider, but you manage to escape");
                    complete = 1;
                    return;
                }
                else
                {
                    Console.WriteLine("You killed the spider!");
                    complete = 1;
                    return;
                }
            }

            else
            {
                Console.WriteLine("You don't have anything to fight with!");
                Thread.Sleep(2000);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("                  Fighting...                   ");
                Console.WriteLine("   YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER    ");
                Console.WriteLine("IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Thread.Sleep(2000);

                Random rnd = new Random();
                int fdmg1 = rnd.Next(1, 8);
                int edmg1 = rnd.Next(1, 5);

                Console.WriteLine("you hit a {0}", fdmg1);
                Console.WriteLine("the spider hits a {0}", edmg1);
                Thread.Sleep(2000);

                int complete = 0;

                if (edmg1 > fdmg1)
                {
                    Console.WriteLine("The spider has dealt more damage than you!");
                    complete = 0;
                    return;
                }
                else if (fdmg1 < 5)
                {
                    Console.WriteLine("You didn't do enough damage to kill the spider, but you manage to escape");
                    complete = 1;
                    return;
                }
                else
                {
                    Console.WriteLine("You killed the spider!");
                    complete = 1;
                    return;
                }
            
            Console.WriteLine("You choose not to fight the spider.");
            Thread.Sleep(1000);
            Console.WriteLine("As you turn away, it ambushes you and impales you with it's fangs!!!");
            //complete = 0;
            return;
            }
        }
    }
}
