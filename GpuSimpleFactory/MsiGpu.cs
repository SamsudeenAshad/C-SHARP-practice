using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GpuSimpleFactory
{
    public class MsiGpu :Gpu
    {
        public void Assemble()
        {
            Console.WriteLine(" I am a MSI GPU");
        }
    }
}
