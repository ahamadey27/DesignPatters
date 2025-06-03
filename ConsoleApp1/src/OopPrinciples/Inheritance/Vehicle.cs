using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ConsoleApp1.src.OopPrinciples.Inheritance
{
    /*Inheritance invlolves creating new classes (subclasses or derived classes) based on existing classes
    (base classes or super classes). Subclasses inherit properties and behaviors from their superclass
    and can also add new features or override existing ones. Considered an "as-is" relationship*/

    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Start()
        {
            Console.WriteLine("Vehicle is starting");
        }

        public void Stop()
        {
            Console.WriteLine("Vehicle is stopping");
        }
    } 
}