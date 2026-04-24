using CarFactoryDesign.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryDesign.ConcreteClasses
{
    internal class GasEngine : Engine
    {
        public override void Start()
        {
            Console.WriteLine("Gas Engine Starting...");
        }

        public override void Stop()
        {
            Console.WriteLine("Gas Engine Enging...");
        }

        public override string ToString()
        {
            return "[ Gas ]";
        }
    }
}
