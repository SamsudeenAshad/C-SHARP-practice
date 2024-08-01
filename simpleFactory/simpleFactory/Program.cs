using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleFactory
{
     class Program
    {
        static void Main(string[] args)
        {
            Resturant resturant1 = new Resturant();
            resturant1.OrderBurger("beef");
        }
    }
}
