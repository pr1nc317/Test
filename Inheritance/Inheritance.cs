using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    ///  LEARNINGS:
    ///  Abstract methods cannot be inside a non-abstract class. If a class has abstract method, then that class should also be made abstract.
    ///  Abstract methods cannot be defined, but only declared. Child classes should define abstract methods strictly.
    ///  Static methods can only be called using the class type, not by the instance variable of that class.
    ///  Static member inside a abstract class cannot be marked as virtual, abstract or override.
    ///  Abstract types cannot be sealed or static.
    /// </summary>
    class Inheritance
    {
        public abstract class Vehicle
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

            public static void Method1()
            {
                Console.WriteLine("Base class static method");
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

        static void Main(string[] args)
        {
            Car car = new Car(4, 4);
            Bus bus = new Bus(30, 6);
        }
    }
}
