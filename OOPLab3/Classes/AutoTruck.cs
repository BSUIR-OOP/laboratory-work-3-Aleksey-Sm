namespace OOPLab3.Classes
{
    public abstract class AutoTruck : Car
    {
        public AutoTruck(int maxSpeed, string name)
        {
            this.maxSpeed = maxSpeed;
            doorCount = 2;
            wheelCount = 10;
            Name = name;
            CurrSpeed = 0;
            PassengerCount = 1;
        }
    }
}
