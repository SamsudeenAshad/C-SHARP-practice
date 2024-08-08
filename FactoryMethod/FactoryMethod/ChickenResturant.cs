using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ChickenResturant : Resturant
    {
        public override Burger CreateBurger()
        {

        return new ChickenBurger(); 
        }
    }
}
