using System;
using System.Collections.Generic;

namespace assignment1
{
    public class Hand
    {
        public List<Car> Cars { get; set; }

        public Hand()
        {
            this.Cars = new List<Car>();
        }

        public List<Car> carsWithMaxSpeedMoreThan(int speed)
        {
            List<Car> result = new List<Car>();
            foreach(Car car in Cars)
            {
                if(car.MaxSpeed > speed)
                {
                    result.Add(car);
                }
            }
            return result;
        }
    }
}
