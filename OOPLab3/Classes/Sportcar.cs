namespace OOPLab3.Classes
{
    public class Sportcar : PassengerCar
    {
        public Sportcar(int maxSpeed, string name)
            : base(maxSpeed, name)
        {
            maxPassengerCount = 2;
            doorCount = 2;
            wheelCount = 4;
        }

        public override string GetInfo()
            => $"Vehicle type: Sportcar\nVehicle name: {Name}\nCurrent Speed: {CurrSpeed}\nCurrent number of passengers: {PassengerCount}Number of wheels: {wheelCount}\nNumber of doors: {doorCount}";
    }
}
