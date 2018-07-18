using System;
					
public class Program
{
	public static void Main()
	{
		string name = "";
		string lastname = "";
		int age = 0;
		int year = 7;
		string band = "";
		string team = "";
		

		
		Console.WriteLine("Please enter your first name: ");
		name = Console.ReadLine();
		Console.WriteLine("Please enter your last name: ");
		lastname = Console.ReadLine();
		Console.WriteLine("Please enter your age: ");
		age = Convert.ToInt32(Console.ReadLine());
		//Console.WriteLine("Please enter 7: ");
		//year = Convert.ToInt32(Console.ReadLine());
		//comment: put divisibale into line 10
		Console.WriteLine("Who is your favorite band: ");
		band = Console.ReadLine();
		Console.WriteLine("What sports team do you cheer for: ");
		team = Console.ReadLine();
		
		
		Console.WriteLine(@"Hello! 
		My name is {0} {1}. 
		I am {3} in dog years. 
		My favorite band is {4}. 
		I support {5}! ", name, lastname, age, year*age, band, team,);



	}
}
