namespace OOPLab3.Classes
{
    public class Truck : AutoTruck
    {
        public Truck(int maxSpeed, string name)
            : base(maxSpeed, name)
        {
            maxPassengerCount = 2;
        }

        public override string GetInfo()
            => $"Vehicle type: Truck\nVehicle name: {Name}\nCurrent Speed: {CurrSpeed}\nCurrent number of passengers: {PassengerCount}\nNumber of wheels: {wheelCount}\nNumber of doors: {doorCount}";
    }
}
