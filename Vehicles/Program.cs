namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car tomsHyundai = new Car("Hyundai", "i10", 76, FuelType.Unleaded);
            Car chrisFerrari = new Car("Ferrari", "Spyder", 670, FuelType.Diesel);
            Motorcycle ducati = new Motorcycle("Ducati", "Monster", false, 111, FuelType.Diesel);
            Motorcycle harley = new Motorcycle("Harley Davidson", "FLTC1340", true, 70, FuelType.Leaded);
            Boat ferry = new Boat("P+O Cruise", "Indepenace", false, 400, FuelType.BoatFuel);

            List<Vehicle> vehicles = new List<Vehicle> { tomsHyundai, chrisFerrari, ducati, harley, ferry};
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.StartEngine();
                vehicle.Drive();
            }

            ferry.GetIntoTheWater();
            ferry.StartEngine();
            ferry.Drive();

            
        }
    }
}
