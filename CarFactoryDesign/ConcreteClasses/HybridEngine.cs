using CarFactoryDesign.Abstractions;


namespace CarFactoryDesign.ConcreteClasses
{
    internal class HybridEngine : Engine
    {

        // private fields
        private readonly ElectricEngine _electricEngine = new();
        private readonly GasEngine _gasEngine = new();
        private Engine? _workingEngine;
        private int? _speed;

        
        public override int? Speed
        {
            // Getter method
            get
            {
                return _speed;
            }

            // setter method to handle cost optimization of engines
            set
            {
                Engine requiredEngine = value < 50 ? _electricEngine : _gasEngine;

                if(requiredEngine != _workingEngine)
                {
                    Console.WriteLine($"--- Switching to {requiredEngine.GetType().Name} for optimization ---");
                    _workingEngine?.Stop();
                    _workingEngine = requiredEngine;
                    _workingEngine.Start();
                }
                _speed = value;

            }
        }

        public override void Start()
        {
            _workingEngine = new ElectricEngine();
            _workingEngine.Start();
        }

        public override void Stop()
        {
            _workingEngine?.Stop();
        }

        public override string ToString()
        {
            return $" {_workingEngine} ";
        }
    }
}
