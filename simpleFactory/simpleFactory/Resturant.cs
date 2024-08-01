using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleFactory
{
    public class Resturant
    {
        public simpleBurgerFactory OrderBurger(String type)
        {
            simpleBurgerFactory simpleBurgerFactory = new simpleBurgerFactory();
            Burger burger = simpleBurgerFactory.CreateBurger(type);
            burger.Prepare();

            return Burger;
        }
    }
}
