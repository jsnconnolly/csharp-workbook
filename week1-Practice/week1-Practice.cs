using System;

public class Program
{
    public static void Main()
    {

        int one = 0;
        int two = 0;

        Console.WriteLine("Please enter a whole number:");
        one = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter a whole number:");
        two = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0} + {1} = {2}", one, two, one + two);

        int yard = 12;
        int inch = 12;

        Console.WriteLine("12 yards is {0} inches", yard * inch);

        decimal num = 3.35m;
        // m suffix used with decimal

        Console.WriteLine("The product of NUM(3.35) is {0}", num * num);

        bool people = true;
        Console.WriteLine(people);

        bool f = false;
        Console.WriteLine(f);
        // you told me to use f as the variable

        string name = "";
        string lastname = "";
        int age = 0;
        int year = 2018;
        // adjust to current year
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
        Console.WriteLine("I was born in {1}.", age, year - age);
        Console.WriteLine("I work as a {0}.", job);
        Console.WriteLine("My favorite band is {0}.", band);
        Console.WriteLine("I support {0}! ", team);

        int hund = 100;
        int ten = 10;

        Console.WriteLine("The Sum of 100 and 10 = {0}", hund + ten);
        Console.WriteLine("The Product of 100 and 10 = {0}", hund * ten);
        Console.WriteLine("The Difference of 100 and 10 = {0}", hund - ten);
        Console.WriteLine("The Quotient of 100 and 10 = {0}", hund / ten);

    }
}
