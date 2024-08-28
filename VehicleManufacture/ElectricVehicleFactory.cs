using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManufacture
{
    public class ElectricVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new ElectricCar();  
        }

        public IEngine CreateEngine()
        {
            return new ElectricEngine();
        }
    }
}
