using System;

namespace Week7
{
    class Program
    {
        public static void Main()
        {
        primaryColor myColor = primaryColor.red ;
        Console.WriteLine(primaryColor.red);   

        }
        public static String combineColors(String color1, String color2)
        {
            if (color1 == "red")
            {
                if (color2 == "yellow")
                {
                    return "orange";
                }
                else if (color2 == "blue")
                {
                    return "purple";
                }
                else if (color2 == "red")
                {
                    return "red";
                }
                return null;
            }
            if (color1 == "yellow")
            {
                if (color2 == "blue")
                {
                    return  "green";
                }
                else if (color2 == "red")
                {
                    return "orange";
                }
                else if (color2 == "yellow")
                {
                    return "yellow";
                }
                return null;
            }
            if (color1 == "blue")
            {
                if (color2 == "red")
                {
                    return "purple";
                }
                else if (color2 == "yellow")
                {
                    return "green";
                }
                else if (color2 == "blue")
                {
                    return "blue";
                }
                return null;

            }
        }


        enum primaryColor
        {
            red, blue, yellow

        }
    }
}

   //struct FullName{
       //  String firstName;
        //String middleName;
        //String lastName;

    //}



