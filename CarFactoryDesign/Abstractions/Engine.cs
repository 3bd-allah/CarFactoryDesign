
using System.Reflection.Metadata.Ecma335;

namespace CarFactoryDesign.Abstractions
{
    public abstract class Engine
    {
        private int? _speed;
        public virtual int? Speed
        {
            get => _speed;
            // setter method to check non negative speed values
            set
            {
                if (value < 0)
                    _speed = 0;
                else
                    _speed = value;
            }
        }



        protected Engine()
        {
            Speed = 0;
        }
        public virtual void Increase() => this.Speed += 1;
        public virtual void Decrease() => this.Speed -= 1;

        public abstract void Start();
        public abstract void Stop();

        
    }
}
