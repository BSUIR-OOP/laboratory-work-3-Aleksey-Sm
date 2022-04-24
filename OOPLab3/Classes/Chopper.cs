namespace OOPLab3.Classes
{
    public class Chopper : Motorcycle
    {
        public Chopper(int maxSpeed, string name)
            : base(maxSpeed, name)
        {
            maxPassengerCount = 3;
        }

        public override string GetInfo()
            => $"Vehicle type: Chopper\nVehicle name: {Name}\nCurrent Speed: {CurrSpeed}\nCurrent number of passengers: {PassengerCount}\nNumber of wheels: {wheelCount}\nNumber of doors: {doorCount}";
    }
}
