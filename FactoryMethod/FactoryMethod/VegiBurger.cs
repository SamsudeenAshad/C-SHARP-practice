﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class VegiBurger : Burger
    {
        public override void Prepare()
        {
            Console.WriteLine("prepare vegi burger");
        }


    }
}
