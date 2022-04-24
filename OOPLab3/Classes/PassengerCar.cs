namespace OOPLab3.Classes
{
    public abstract class PassengerCar : Car
    {
        public PassengerCar(int maxSpeed, string name)
        {
            this.maxSpeed = maxSpeed;
            Name = name;
            PassengerCount = 1;
            CurrSpeed = 0;
        }
    }
}
