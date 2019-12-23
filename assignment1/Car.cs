using System;
using System.Collections.Generic;

namespace assignment1
{
    public class Car: IComparable<Car>
    {

        public int MaxSpeed { get; set; }
        public double Power { get; set; }
        public int OperatingSpeed { get; set; }
        public int Volume { get; set; }
        public double Acceleration { get; set; }
        public int Zylinder { get; set; }

        public int CompareTo(Car other)
        {
            return this.MaxSpeed.CompareTo(other.MaxSpeed);
        }

        public static int CompareByPower(Car car1, Car car2)
        {
            return car1.Power.CompareTo(car2.Power);
        }
    }
}
