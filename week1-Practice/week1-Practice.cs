﻿using System;

public class Program
{
    public static void Main()
    {
        int one = 0;
        int two = 0;
        int yard = 12;
        int inch = 12;
        decimal num = 3.35m;
        string name = "";
        string lastname = "";
        int age = 0;
        int year = 7;
        string job = "";
        string band = "";
        string team = "";
        int hund = 100;
        int ten = 10;


        
        Console.WriteLine("Please enter a whole number:");
        one = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter a whole number:");
        two = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0} Pluse {1} equals {2}", one, two, one + two);
        
        Console.WriteLine("12 yards is {0} inches", yard * inch);
        Console.WriteLine("The product of NUM is {0}", num * num);
        
        Console.WriteLine("Please enter your first name:");
        // ReadLine enters the string
        name = Console.ReadLine();
        Console.WriteLine("Please enter your last name:");
        lastname = Console.ReadLine();
        Console.WriteLine("Please enter your age:");
        // Convert.ToInt32 takes in the numbers 
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is your Job?");
        job = Console.ReadLine();
        Console.WriteLine("Who is your favorite band?");
        band = Console.ReadLine();
        Console.WriteLine("What sports team do you cheer for?");
        team = Console.ReadLine();


        Console.WriteLine(@"Hello! My name is {0} {1}.", name, lastname); 
		Console.WriteLine("I am {1} in dog years.", age, year * age);
        Console.WriteLine("I work as a {0}.", job);
		Console.WriteLine("My favorite band is {0}.", band);
		Console.WriteLine("I support {0}! ", team);

        Console.WriteLine("The Sum of 100 and 10 is {0}", hund + ten);
        Console.WriteLine("The Product of 100 and 10 is {0}", hund * ten);
        Console.WriteLine("The Difference of 100 and 10 is {0}", hund - ten);
        Console.WriteLine("The Quotient of 100 and 10 is {0}", hund / ten);

    }
}
