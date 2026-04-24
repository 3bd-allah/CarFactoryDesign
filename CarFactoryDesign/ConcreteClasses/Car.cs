using CarFactoryDesign.Abstractions;


namespace CarFactoryDesign.ConcreteClasses
{
    public class Car
    {
 
        public Engine Engine { get; set; }


        // Car SPeed property reflected the engine spr
        public int? CarSpeed => Engine.Speed;

        public void Start()
        {
            Engine.Start();
            Engine.Speed = 0;
        }
        

        public void Stop()
        {
            if(Engine is null ) Console.WriteLine("You must start the car engine first.");
            if(Engine.Speed == 0)
            {
                Console.WriteLine("The car is fully stoped now.");
            }
            else
            {
                Console.WriteLine($"Cannot stop: Speed is {CarSpeed}. Please brake first.");
            }
        }

        public void Accelerate()
        {
            if(Engine.Speed < 200 && Engine.Speed >= 0)
            {
                Engine.Speed += 20;
                Console.WriteLine($"Accelerating..., Current Speed {CarSpeed} km/h");
            }
        }

        public void Brake()
        {
            if(Engine.Speed > 0 && Engine.Speed >=20)
            {
                Engine.Speed -= 20 ;
                Console.WriteLine($"Braking..., Current Speed {CarSpeed} km/h");
            } 

        }

        public override string ToString()
        {
            return $"The Current working Engine: {Engine} - Current Speed: {CarSpeed} km/h";
        }
    }
}
