

using CarFactoryDesign.ConcreteClasses;
using CarFactoryDesign.Factories;

namespace CarFactoryDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = CarFactory.CreateCar(EngineFactory.CreateEngine<HybridEngine>());
            Console.WriteLine(car); // hybrid

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
