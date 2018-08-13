using System;

namespace DL
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Drivers License");

            String someName = "Jason";
            int someHeight = 75;
            String someEye = "Brown";

        


            DL  myLicense = new DL(someName, someHeight, someEye);

            DL otherLicense = new DL("John" , 75, "Blue");

            otherLicense.eyecolor = "brown";

            //Console.WriteLine("{0} is {1} inches tall", otherLicense.name, otherLicense.heightInches);
            Console.WriteLine("{0} is {1} feet tall and has {2} eyes", otherLicense.name, otherLicense.heightInFeet(), otherLicense.eyecolor);
            Console.WriteLine("We have created {0} licenses", DL.numberLicense);
        
        }
    }
    class DL
    {
    // This variable belongs to the entire class
        public static int numberLicense=0;
    
        public string name {get; set;}
        public int heightInches {get; set;} 
        public string eyecolor {get; set;}
        public string haircolor {get; set;}
        public char gender {get; set;}
        //public string DOB {get; set:}
        public char DlClass {get; set;}
        public string DLnumber {get; private set;}
        public bool organ {get; set;}
        public string state {get; set;}


        //Things you need to make a DL
        //x is name
        //h is height so on and so forth
        public DL(string xName, int xHeight, string xEye)
        {
            this.name = xName;
            this.heightInches = xHeight;
            this.eyecolor = xEye;
            numberLicense ++;
        
        }
        public double heightInFeet()
        {
            double feet = this.heightInches/12.0;
            return feet;
        }


    }
}
