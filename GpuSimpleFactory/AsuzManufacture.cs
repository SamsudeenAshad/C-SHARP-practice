using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GpuSimpleFactory
{
    public class AsuzManufacture : Company
    {
        public override Gpu CreateGpu()
        {
            return new AssuGpu();
        }
    }
}
