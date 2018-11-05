using System;

public class Program
{
    public static string LabelGen(string First, string Second, string Third)
    {
        string Label = "Entry:" + First + "," + Second +"," + Third;
        
        return Label;
    }

    public static void Main()
    {

        Roster roster = new Roster();  
        Roster.RosterGenerator();
        
        Console.ReadLine();      
        
    }
    
    


class Roster
{
    
    public static void RosterGenerator(){
        
        Person luke = new Person("Luke", "Skywalker", "Rebel");
        Person leia = new Person("Leia", "Organa", "Rebel");
        Person han = new Person("Han", "Solo", "Rebel");
        Person darth = new Person("Darth", "Vader", "Imperial");
        Person emporer = new Person("Emporer", "Palpatine", "Imperial");
        Ship xWing = new Ship("Rebel", "Fighter", 1);
        Ship falcon = new Ship("Rebel", "Smuggling", 2);
        Ship tie = new Ship("Tie", "Fighter", 1);
        Station rebelSS = new Station("Rebel", "Station", 3);
        Station deathStar = new Station("Imperial", "Station", 2);

        Console.WriteLine(luke.label);
        Console.WriteLine(leia.label);
        Console.WriteLine(xWing.label);
    }

    
}


class Person
{
    private string firstName;
    private string lastName;
    private string alliance;
    
    public string label;
    
    
    public Person(string firstName, string lastName, string alliance)
    {
        
        this.firstName = firstName;
        this.lastName = lastName;
        this.alliance = alliance;
        this.label = LabelGen(firstName,lastName,alliance);
        
    }

    public string FullName
    {
        get
        {
            return this.firstName + " " + this.lastName;
        }

        set
        {
            string[] names = value.Split(' ');
            this.firstName = names[0];
            this.lastName = names[1];
        }
    }
}

class Ship
{
    private Person[] passengers;
    public string label;
    public Ship(string alliance, string type, int size)
    {
        this.Type = type;
        this.Alliance = alliance;
        this.passengers = new Person[size];

        string ConvertedPassengers = passengers.ToString();

        this.label = LabelGen(type, ConvertedPassengers, alliance);
    }

    public string Type
    {
        get;
        set;
    }

    public string Alliance
    {
        get;
        set;
    }
}
class Station
{
    private Person[] passengers;
    public Station(string alliance, string type, int size)
    {
        this.Type = type;
        this.Alliance = alliance;
        this.passengers = new Person[size];
    }

    public string Type
    {
        get;
        set;
    }

    public string Alliance
    {
        get;
        set;
    }



    public string Passengers
    {
        get
        {
            foreach (var person in passengers)
            {
                Console.WriteLine(String.Format("{0}", person.FullName));
            }

            return "That's Everybody!";
        }
    }

    public void EnterShip(Person person, int seat)
    {
        this.passengers[seat] = person;
    }

    public void ExitShip(int seat)
    {
        this.passengers[seat] = null;
    }
}
}
