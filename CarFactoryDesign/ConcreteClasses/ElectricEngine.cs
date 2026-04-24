using CarFactoryDesign.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryDesign.ConcreteClasses
{
    internal class ElectricEngine : Engine
    {
        public override void Start()
        {
            Console.WriteLine("Electric Engine Starting...");
        }

        public override void Stop()
        {
            Console.WriteLine("Electric Engine Stoping...");
        }

        public override string ToString()
        {
            return "[ Electric ]";
        }
    }
}
