using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManufacture
{
    public class GasolineVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new GasolineCar();  
        }

        public IEngine CreateEngine()
        {
            return new GasolineEngine();
        }
    }
}
