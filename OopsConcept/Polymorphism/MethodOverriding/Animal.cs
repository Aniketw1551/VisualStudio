using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Polymorphism.MethodOverriding
{
    public class Animal // Base Class
    {
        public string color; // public Member

        public void Sound() // Method
        {
            Console.WriteLine("Animal Sound");
        }
    }
}
