using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GpuSimpleFactory
{
    public abstract class Company
    {
        public Gpu AssembleGpu()
        {
            Gpu gpu = CreateGpu();
            gpu.Assemble;
            return gpu;

        }
        public abstract Gpu CreateGpu();
        
    }
}
