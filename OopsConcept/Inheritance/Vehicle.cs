using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Inheritance
{
    public class Vehicle // Base class 
    {
       
        public string brand; // Vehicle class public members
        public int model;
       
        public void Run()  // Method to Run Vehicle
        {
            Console.WriteLine("Vehicle is in Running Condition \n ");
        }
    }
}