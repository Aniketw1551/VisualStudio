using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Polymorphism.MethodOverriding
{

    public class Parrot : Animal //Class derived from inherited base class
    {
        // Method to show Animal Detail
        public void ParrotDetail()
        {
            // Creating Object of Base Class
            Animal a = new Animal();
            a.color = "Green";
            Console.WriteLine("\nParrot color is: " + a.color);
        }
        // Method Overriding of Sound Method of Base class
        public new void Sound()
        {
            Console.WriteLine("Parrot make squawk sound");
        }
    }
}
