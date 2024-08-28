using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManufacture
{
    public class GasolineEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting Gasoline Engine");
        }
    }
}
