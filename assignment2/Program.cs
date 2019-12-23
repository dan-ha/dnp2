using System;
using assignment1;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            IntList xs = new IntList(2, 5, 9, 12, 18, 22, 30, 45, 50, 60, 90, 100);
            xs.Act(Console.WriteLine);

            Console.WriteLine("Even Numbers:");
            xs.Filter(x => x % 2 == 0).Act(Console.WriteLine);

            Console.WriteLine("Greater than or equal 25:");
            xs.Filter(x => x>=25).Act(Console.WriteLine);

            int sum = 0;
            xs.Act(x => sum += x);
            Console.WriteLine("Sum of all IntList's elements: {0}", sum);


            // Generic solution
            MyList<Car> cars = new MyList<Car>() {
            new Car() {MaxSpeed = 265,Power = 220.5, OperatingSpeed = 5900, Volume = 2994, Acceleration = 6, Zylinder = 6 },
            new Car() {MaxSpeed = 120,Power = 100, OperatingSpeed = 3200, Volume = 1200, Acceleration = 4, Zylinder = 3 },
            new Car() {MaxSpeed = 150,Power = 180.5, OperatingSpeed = 4000, Volume = 1800, Acceleration = 5, Zylinder = 5 }
            };

            Console.WriteLine("Cars with max speed more than 130:");
            cars.Filter(car => car.MaxSpeed > 130).Act(car => Console.WriteLine(car.MaxSpeed));

            Console.ReadLine();
        }
    }
}
