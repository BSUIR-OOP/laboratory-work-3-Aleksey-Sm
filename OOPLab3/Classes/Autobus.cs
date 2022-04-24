namespace OOPLab3.Classes
{
    public class Autobus : PassengerCar
    {
        public Autobus(int maxSpeed, string name)
            : base(maxSpeed, name)
        {
            maxPassengerCount = 30;
            doorCount = 3;
            wheelCount = 6;
        }

        public override string GetInfo()
            => $"Vehicle type: Autobus\nVehicle name: {Name}\nCurrent Speed: {CurrSpeed}\nCurrent number of passengers: {PassengerCount}\nNumber of wheels: {wheelCount}\nNumber of doors: {doorCount}";
    }
}
