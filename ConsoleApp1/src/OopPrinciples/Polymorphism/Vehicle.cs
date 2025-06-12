using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.OopPrinciples.Polymorphism
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public virtual void Start() //virtual methods can be overwirtten by any sub/child classes
        {
            Console.WriteLine("Vehicle is starting");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vechile is stopping");
        } 

    }
}