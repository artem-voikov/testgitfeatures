using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class CarRepository
    {
        public Car Get(int id)
        {
            Console.WriteLine("Get car");

            return new Car { Id = id, Model = "T", Name = "Car" };
        }

        public bool Create(Car car)
        {
            return true;
        }
    }
}
