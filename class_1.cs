using System;

namespace class_1{
    public class Car{
        // Car properties
        public string Color{get; set;}
        public int Mileage{get; set;}
        public int Year{get; set;}

        // total cars variable
        private static int instances = 0;

        public Car(string color, int year){
            this.Color = color;
            this.Year = year;
            instances++;
        }

        public Car(){
            instances++;
        }

        public Car(int mileage, int year){
            this.Mileage = mileage;
            this.Year = year;
            instances++;
        }

        public static int CountCars(){
            return instances;
        }
    }    
}