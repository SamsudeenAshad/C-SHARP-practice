using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GpuSimpleFactory
{
    public class MSIManufacture : Company
    {
        public override Gpu CrateGpu()
        {
            return new MsiGpu();
        }
    }
}
