using CarFactoryDesign.ConcreteClasses;
using CarFactoryDesign.Abstractions;


namespace CarFactoryDesign.Factories
{
    public class EngineFactory
    {
        // in the future any new engine if exist just make a class inherit form Engine abstract class.
        // then in creation pass NewEngine class to the Generic method CreateEngine<T>()
        // instead of switch case or if-else conditions (open-closed principle achieved)

        /// <summary>
        /// Generic method that takes T as type of engine and return object of (T) which is type of engine
        /// </summary>
        /// <typeparam name="T">Any type of Engine</typeparam>
        /// <returns>object instance of given T type</returns>
        public static Engine CreateEngine<T>() where T : Engine , new()
        {
            T engine = new T();
            return engine;
        }


        // there is another approach we can create a Factory for each engine type but there is will be alot of code 
        // so this Generic method is more better 
    }
}
