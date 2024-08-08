using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class vegiResturant : Resturant
    {
        public override Burger CreateBurger()
        {
            return new VegiBurger();
        }
    }
}
