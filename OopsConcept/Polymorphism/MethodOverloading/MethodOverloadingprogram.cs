using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Polymorphism.MethodOverloading
{
    internal class MethodOverloadingprogram
    {
        public void Add()
        {
            Addition a = new Addition();
            Console.WriteLine("\n" + a.Add(10));
            Console.WriteLine(a.Add(10, 30));
            Console.WriteLine(a.Add(20, 40, 60));
            Console.WriteLine(a.Add(46.46f, 30));
            Console.WriteLine(a.Add(20, 15.15f));
        }
        public void Sub()
        {
            Subtraction s = new Subtraction();
            Console.WriteLine("\n" + s.Sub(30));
            Console.WriteLine(s.Sub(30, 10));
            Console.WriteLine(s.Sub(50, 25, 15));
            Console.WriteLine(s.Sub(33.33f, 22));
            Console.WriteLine(s.Sub(40, 28.22f));
        }

    }
}
