using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleternPattern
{
    public class singletern
    {
        private static singletern instance = new singletern();

        private singletern()
        {
            Console.WriteLine(" singletern ");
        }

        public staic singletern () {
    }
}
