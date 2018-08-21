using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        public static void Main(String[] args){
           Console.WriteLine("Interfaces Practice");

            Car merc = new Car ("AAAA", 140.40);
            Car lambo = new Car ("BBBB", 2000.01);
            Car fiesta = new Car ("CCCC", 20);

            HotelRoom suite = new HotelRoom ("100", 300);
            HotelRoom std1 = new HotelRoom ("10", 30);
            HotelRoom std2 = new HotelRoom ("20", 300);

            // goes through rentableThigns and compute list
            List<Rentable> rentableThings = new List<Rentable>();
                rentableThings.Add(merc);
                rentableThings.Add(lambo);
                rentableThings.Add(fiesta);

            foreach(Rentable thing in rentableThings) {
                Console.WriteLine("If you rent {0} the amount due for 1 day of rent is {1}",
                thing.GetType().Name,
                thing.calculateRent(1));
            }
        

             Console.WriteLine("For car {0} for one day the amount due is {1}",
                merc.liceseNo, merc.calculateRent(1));
             Console.WriteLine("For car {0} for one day the amount due is {1}",
                lambo.liceseNo, lambo.calculateRent(1));

        

        }
    }

    public interface Rentable {
    
        double calculateRent(double daysToRent);

    }

        public class Car : Rentable
        {
            public String liceseNo {get; private set;}
            public double hourlyRate {get; private set;}
             
            public Car(String liceseNo, double rate){
                this.liceseNo = liceseNo;
                this.hourlyRate = rate;

        }
            public double calculateRent(double daysToRent){
            double dailyRate = 24+hourlyRate;
            return dailyRate * daysToRent;

            
        }
        }
        
        public class HotelRoom : Rentable {
            public String roomNo {get; private set;}
            public double dailyRate {get; private set;}
        
            public HotelRoom(String roomNumber, double rate){
                this.dailyRate = rate;
                this.roomNo = roomNumber;
            }
            public double calculateRent( double daysToRent){
                return dailyRate * daysToRent;
            }
        }    
}

