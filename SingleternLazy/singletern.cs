using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleternLazy
{
    internal class singletern
    {
        private static singletern instance;

        private singletern() 
        {
            Console.WriteLine("singletern is Instantiated");
        }

        public static singletern GetSinstance()
        {
            if (instance == null)
            {
                instance = new singletern();
            }
            return instance;
        }
        public void display () {
            Console.WriteLine(
    }
}
