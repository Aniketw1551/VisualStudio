using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Inheritance.SingleInheritance
{

    public class Animal   // Base Class
    {

        public string breed;  //Members of Base Class
        public int age;

        public void Walk()  // Method of Base Class
        {
            Console.WriteLine("Walking");
        }
        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
}
