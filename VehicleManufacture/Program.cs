using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManufacture
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the engine type (Gasoline/Electric): ");
            string engineType = Console.ReadLine();

            IVehicleFactory factory = null;

            if (engineType.Equals("Gasoline", StringComparison.OrdinalIgnoreCase))
            {
                factory = new GasolineVehicleFactory();
            }
            else if (engineType.Equals("Electric", StringComparison.OrdinalIgnoreCase))
            {
                factory = new ElectricVehicleFactory();
            }
            else
            {
                Console.WriteLine("Unknown engine type");
                return;
            }

            Console.WriteLine("Enter the vehicle type (Car/Truck): ");
            string vehicleType = Console.ReadLine();

            IVehicle vehicle = factory.CreateVehicle(vehicleType);
            IEngine engine = factory.CreateEngine();

            vehicle.ShowDetails();
            engine.Start();
        }
    }
}
