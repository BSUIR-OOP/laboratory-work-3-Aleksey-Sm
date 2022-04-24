namespace OOPLab3.Classes
{
    public class Minivan : PassengerCar
    {
        public Minivan(int maxSpeed, string name)
            : base(maxSpeed, name)
        {
            maxPassengerCount = 6;
            doorCount = 4;
            wheelCount = 4;
        }

        public override string GetInfo()
            => $"Vehicle type: Minivan\nVehicle name: {Name}\nCurrent Speed: {CurrSpeed}\nCurrent number of passengers: {PassengerCount}Number of wheels: {wheelCount}\nNumber of doors: {doorCount}";
    }
}
