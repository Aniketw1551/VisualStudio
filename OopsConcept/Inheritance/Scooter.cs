﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Inheritance
{
    /*Bike is a Derived class inheriting Car and Vechile class
 * This is Multilevel Inhereting example. 
 * */
    public class Scooter : Vehicle
    {
        /// <summary>
        /// creating Method inside scooter class which is inhereting Car and Vehicle class
        /// </summary>
        public void ScooterBrand()
        {
            //creating object to access properties of Vechile Class
            Vehicle vehicle = new Vehicle();
            vehicle.brand = "TVS";
            vehicle.model = 2016;
            Console.WriteLine("Scooter is: " + vehicle.brand + " and Model is: " + vehicle.model);
            vehicle.Run(); // calling base class Method that is Vehicle
        }
    }
}