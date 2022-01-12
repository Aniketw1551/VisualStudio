using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Inheritance
{

    public class Car : Vehicle //Derived class car inhereting base class Vehicle
    {
        /// <summary>
        /// creating Method inside car class which is inhereting Vehicle class 
        /// </summary>
        public void CarBrand()
        {
            Car car = new Car();
            car.brand = "Audi";
            car.model = 2020;
            Console.WriteLine("Car is: " + car.brand + " and Model is: " + car.model);
            vehicle.Run(); // calling base class Method which is Vehicle
        }
    }
}
 

