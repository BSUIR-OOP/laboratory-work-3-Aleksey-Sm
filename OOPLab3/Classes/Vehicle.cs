namespace OOPLab3.Classes
{
    public abstract class Vehicle
    {
        protected string Name { get; set; }

        protected int maxSpeed { get; set; }

        protected int maxPassengerCount { get; set; }

        protected int doorCount { get; set; }

        protected int wheelCount { get; set; }

        protected int CurrSpeed { get; set; }

        protected int PassengerCount { get; set; }

        public void SpeedUp(int value)
            => CurrSpeed = (CurrSpeed + value > maxSpeed) ? maxSpeed : CurrSpeed + value;

        public void SpeedDown(int value)
            => CurrSpeed = (CurrSpeed - value < 0) ? 0 : CurrSpeed - value;

        public void AddPassengers(int count)
            => PassengerCount = (PassengerCount + count > maxPassengerCount) ? maxPassengerCount : PassengerCount + count;

        public void DropOffPassengers(int count)
            => PassengerCount = (PassengerCount - count < 0) ? 0 : PassengerCount - count;

        public abstract string GetInfo();
    }
}
