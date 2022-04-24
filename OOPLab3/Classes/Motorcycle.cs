namespace OOPLab3.Classes
{
    public abstract class Motorcycle : Vehicle
    {
        public Motorcycle(int maxSpeed, string name)
        {
            doorCount = 0;
            this.maxSpeed = maxSpeed;
            CurrSpeed = 0;
            PassengerCount = 1;
            Name = name;
            wheelCount = 2;
        }
    }
}
