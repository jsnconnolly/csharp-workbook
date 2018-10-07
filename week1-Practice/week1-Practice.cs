using System;

public class Program
{
    public static void Main()
    {
        string name = "";
        string lastname = "";
        int age = 0;
        int year = 7;
        string job = "";
        string band = "";
        string team = "";


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
    }
}
