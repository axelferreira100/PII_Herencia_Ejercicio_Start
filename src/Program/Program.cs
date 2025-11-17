using Library;

namespace Ucu.Poo.RideShare
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Car("Volkswagen", "Golf", "Blanco");
            Vehicle vehicle2 = new Motorcycle("Kawasaki", "Ninja 400", "Verde");
            
            Passenger passanger = new Passenger("Rick", "Moranis", "3.948.453-2", "rick.jpg");
            CommonDriver driver = new CommonDriver("Bill", "Caddyshack", "3.565.235-4", "bill.jpg", vehicle2, "Conductor responsable y puntual, siempre ofrece viajes seguros en su vehículo Caddyshack.");
            PoolDriver poolDriver = new PoolDriver("Dan"," Aykroyd", "4.566.785-6", "dan.jpg", vehicle1, "Especialista en viajes compartidos, optimiza rutas y transporta hasta 3 pasajeros con eficiencia.", 3);
            UcuRideShare rideShare = new UcuRideShare();

            rideShare.AddUser(passanger);
            rideShare.AddUser(driver);
            rideShare.AddUser(poolDriver);
        }
    }
}