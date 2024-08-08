using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GpuSimpleFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MSIManufacture mSIManufacture = new MSIManufacture();
            mSIManufacture.AssembleGpu();


            AsuzMAnufacture asuzMAnufacture = new AsuzMAnufacture();
            asuzMAnufacture.AssembleGpu();
        }
    }
}
