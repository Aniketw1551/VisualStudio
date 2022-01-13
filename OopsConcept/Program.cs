using OopsConcept.Encapsulation;
using OopsConcept.Polymorphism.MethodOverriding;
using OopsConcept.Polymorphism.MethodOverloading;
using OopsConcept.Inheritance;
using OopsConcept.Inheritance.SingleInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OopsConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");

            //cat cat = new cat();
            //cat.breed = "persian cat";
            //cat.color = "White";
            //cat.sleep();
            //cat.meow();
          
            //Encapsulation
            EncapsulationProgram encapsulation = new EncapsulationProgram(); //creating object of EncapulationProgram class
            encapsulation.Bankbalance();  // calling method in EncapulationProgram class using object variable

            //Method Overriding/Dyanamic polymorphism implementation
            Parrot parrot = new Parrot(); // Creating Object of parrot class
            parrot.ParrotDetail(); // calling Method of parrot class
            parrot.Sound();  // calling overriden method in parrot class

            //Method Overloading/Static Polymorphism implemetation
            MethodOverloadingprogram a = new MethodOverloadingprogram();  //creating object of MethodOverloadingprogram class
            a.Add();                                                      // calling method in MethodOverloadingprogram class using object variable
            a.Sub();

            // Inheritance 
            Scooter vehicle = new Scooter();
            vehicle.ScooterBrand();      // calling Method of scooter class
            vehicle.CarBrand();

            // Object for SingleInheritance
            Tiger tiger = new Tiger();
            tiger.Sleep();
            tiger.breed = "Bengali Tiger";
            tiger.age = 6;
            Console.WriteLine("Anmial is: " + tiger.breed + "\t, Age: " + tiger.age + "yrs");
            tiger.Eat();
            tiger.Walk();
        }
    }
}
