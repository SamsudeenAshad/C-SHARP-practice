using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BeefResturant beefResturant = new BeefResturant();
            beefResturant.OrderBurger();

            vegiResturant vegiResturant = new vegiResturant();
            vegiResturant.OrderBurger();

            ChickenResturant chickenResturant = new ChickenResturant();
            chickenResturant.OrderBurger();
        }
    }
}
