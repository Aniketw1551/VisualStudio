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
            Vehicle vehicle = new Vehicle();
            vehicle.brand = "Audi";
            vehicle.model = 2020;
            Console.WriteLine("Car is: " + vehicle.brand + "and Model is: " + vehicle.model);
            vehicle.Run(); // calling base class Method which is Vehicle
        }
    }
}
 

