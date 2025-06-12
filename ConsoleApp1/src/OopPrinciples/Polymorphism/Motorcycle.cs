using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.OopPrinciples.Polymorphism
{
    public class Motorcycle : Vehicle
    {
        public override void Start() //virtual methods can be overwirtten by any sub/child classes
        {
            Console.WriteLine("Motorcycle is starting");
        }

        public override void Stop()
        {
            Console.WriteLine("Motorcycle is stopping");
        }

    }
}