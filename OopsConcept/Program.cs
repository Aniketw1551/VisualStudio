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

            cat cat = new cat();
            cat.breed = "persian cat";
            cat.color = "White";
            Console.WriteLine("cat details: "+cat.breed+" "+cat.color);
            cat.sleep();
            cat.meow();
            Console.ReadLine();

        }
    }
}
