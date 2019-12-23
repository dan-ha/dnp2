using System;
using System.Collections.Generic;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car() { MaxSpeed = 265, Power = 220.5, OperatingSpeed = 5900, Volume = 2994, Acceleration = 6, Zylinder = 6 });
            cars.Add(new Car() { MaxSpeed = 120, Power = 120.5, OperatingSpeed = 4900, Volume = 1994, Acceleration = 3, Zylinder = 4 });
            cars.Add(new Car() { MaxSpeed = 100, Power = 100.5, OperatingSpeed = 2000, Volume = 1000, Acceleration = 2, Zylinder = 2 });
            cars.Add(new Car() { MaxSpeed = 180, Power = 200.5, OperatingSpeed = 5100, Volume = 2000, Acceleration = 5, Zylinder = 5 });
            cars.Sort();

            Console.WriteLine("Sort by speed:");
            foreach(Car car in cars)
            {
                Console.WriteLine(car.MaxSpeed);
            }

            Console.WriteLine("Sort by power:");
            cars.Sort(Car.CompareByPower);
            foreach (Car car in cars)
            {
                Console.WriteLine(car.Power);
            }

            Console.WriteLine("Fast cars");
            Hand hand = new Hand();
            hand.Cars = cars;
            List<Car> fastCars = hand.carsWithMaxSpeedMoreThan(120);
            foreach(Car car in fastCars)
            {
                Console.WriteLine(car.MaxSpeed);
            }

            Console.ReadLine();
        }
    }
}
