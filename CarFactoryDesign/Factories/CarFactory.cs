using CarFactoryDesign.ConcreteClasses;
using CarFactoryDesign.Abstractions;
using System.Net.NetworkInformation;


namespace CarFactoryDesign.Factories
{
    public class CarFactory
    {

        public static Car CreateCar(Engine engineType)
        {
            Car car = new Car();
            InstallEngine(car, engineType);
            return car;
        }


        static void InstallEngine(Car car, Engine engineType)
        {
            car.Engine = engineType;
        }

        public static Car ReplaceCarEngine(Car existingCar, Engine newEngine)
        {
            existingCar.Engine = newEngine;
            return existingCar;
        }
    }
}
