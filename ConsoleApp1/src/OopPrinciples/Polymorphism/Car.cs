using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.OopPrinciples.Polymorphism
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public override void Start() //Replace base class with new version in a derived class
        {
            Console.WriteLine("car starting");
        }
        public override void Stop()
        {
            Console.WriteLine("Car is stopping");
        }



        
        

        
        
    }
}