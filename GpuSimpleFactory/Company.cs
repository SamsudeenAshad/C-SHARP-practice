using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GpuSimpleFactory
{
    public class Company
    {
        public void Gpu AssembleGpu()
        {
            Gpu gpu = new Gpu();
            gpu.Assember();
            return gpu;

        }
        public abstract Gpu CreateGpu();
        
    }
}
