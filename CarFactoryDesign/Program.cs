

using CarFactoryDesign.ConcreteClasses;
using CarFactoryDesign.Factories;

namespace CarFactoryDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create car based on the type of enigne
            var car = CarFactory.CreateCar(EngineFactory.CreateEngine<HybridEngine>());
            Console.WriteLine(car); // hybrid [electric or gas based on the current speed]

            car.Start();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            Console.WriteLine(car);
            car.Brake();
            Console.WriteLine(car);
            car.Stop();
            car.Brake();
            car.Brake();
            car.Brake();
            car.Brake();
            car.Brake();
            car.Stop();

            // replcaed the engine of an existing car
            CarFactory.ReplaceCarEngine(car, EngineFactory.CreateEngine<ElectricEngine>());
            car.Stop();
            car.Start();
            car.Accelerate();
            car.Accelerate();
            car.Stop();
            car.Brake();
            car.Brake();
            car.Stop();
            Console.WriteLine(car);

        }


    }
}
