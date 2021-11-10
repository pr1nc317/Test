using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Inheritance
    {
        public class Vehicle
        {
            private string vehicleId;
            private string color;
            private int licenceId;
            public Vehicle()
            {
                vehicleId = "DL 1234 ";
                color = "Black";
                licenceId = 1234;
            }
        }

        public class Car : Vehicle
        {
            private int numberOfWheels;
            private int numberOfPassengers;
            public Car(int P, int W)
            {
                numberOfPassengers = P;
                numberOfWheels = W;
            }
        }

        public class Bus: Vehicle
        {
            private int numberOfWheels;
            private int numberOfPassengers;
            public Bus(int P, int W)
            {
                numberOfPassengers = P;
                numberOfWheels = W;
            }
        }

        //static void Main(string[] args)
        //{
        //    Car car = new Car(4, 4);
        //    Bus bus = new Bus(30, 6);
        //}
    }
}
