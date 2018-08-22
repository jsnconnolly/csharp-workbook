using System;
using System.Collections.Generic;

namespace Practice {

    class Program {
        public static void Main(String[] args){
            Console.WriteLine("Interfaces Practice");

            Car mercedes = new Car("AAAA", 140.67);
            Vehicle lamborghini = new Car("BBBB", 1000);
            Car fiesta = new Car("CCCC", 30.5);
            
            HotelRoom suite = new HotelRoom("1001", 650);
            HotelRoom standard1 = new HotelRoom("201", 30);
            HotelRoom standard2 = new HotelRoom("202", 30);

            Boat speed = new Boat("TX123", 500.65);
            Boat seaDoo = new Boat("TX122", 200);
            Boat canoe = new Boat("TX111", 25.25);



            List<Rentable> rentablThings = new List<Rentable>();
            rentablThings.Add(mercedes);
            rentablThings.Add(lamborghini);
            rentablThings.Add(fiesta);
            rentablThings.Add(suite);
            rentablThings.Add(standard1);
            rentablThings.Add(standard2);
            rentablThings.Add(speed);
            rentablThings.Add(seaDoo);
            rentablThings.Add(canoe);

            
            //Console.WriteLine("James' way");
            //Clean way to pull each class
            foreach(Rentable thing in rentablThings) {
                Console.WriteLine("if you rent this {0} for 1 day, the ammount due is ${1}", 
                thing.GetType().Name,
                thing.calculateRent(1));
            }
        }        
    }

    // 1. implement a Car class with an hourly rent rate attribute
    // 2. implement a HotelRoom class with a nightly rent rate attribute
    // 3. implement a calculateRent method that takes in number of days to rent, and return the amount due

    public interface Rentable {

        //double getDailyRate();
        String getType();
        double calculateRent(double daysToRent);
    }

    public abstract class Vehicle: Rentable {
        public abstract double calculateRent(double daysToRent);
        public virtual String getType(){
            return "Vehicle";
        }

    }

    public class Car : Vehicle{
        public String licenseNo {get; private set;}
        public double hourlyRate {get; private set;}

        public Car(String licenseNo, double rate) {
            this.licenseNo = licenseNo;
            this.hourlyRate = rate;
        }

        public override String getType(){
            return "Car";
        }

        /**
         * Returns the amount due to rent this car for the number of days passed in
         * daysToRent: the number of days to rent this car
         */
        public override double calculateRent(double daysToRent){
            double dailyRate =  24*hourlyRate;
            return dailyRate * daysToRent;
        }
    }

    public class HotelRoom : Rentable{
        public String roomNo {get; private set;}
        public double dailyRate {get; private set;}

        public HotelRoom(String roomNumber, double rate){
            this.dailyRate = rate;
            this.roomNo = roomNumber;
        }

        public String getType(){
            return "Hotel Room";
        }
         /**
         * Returns the amount due to rent this room for the number of days passed in
         * daysToRent: the number of days to rent this room
         */
         public double calculateRent(double daysToRent){
            return dailyRate * daysToRent;
        }
    }
    public class Boat : Rentable{
        public String typeOfBoat {get; private set;}
        public double dailyRate {get; private set;}

        public Boat(String typeOfBoat, double rate){
            this.dailyRate = rate;
            this.typeOfBoat = typeOfBoat;
        }

            public String getType(){
            return "Boat";
        }
         /**
         * Returns the amount due to rent this room for the number of days passed in
         * daysToRent: the number of days to rent this room
         */
         public double calculateRent(double daysToRent){
            return dailyRate * daysToRent;
        }
    }
}
