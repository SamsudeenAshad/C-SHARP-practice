using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleFactory
{
    internal class simpleBurgerFactory
    {
        public Burger CreateBurger(string type)
        {

            Burger burger = null;
            if (type == "Beef")
            {
                burger = new BeefBurger();
            }
            else if (type == "vegi")
            {
                burger = new VegiBurger();
            }
            else
            {
                burger = new chickenBurger();
            }

        }
    }
}
