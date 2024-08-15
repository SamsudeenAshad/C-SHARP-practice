using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleternPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            singletern instance1 = singletern.GetInstance();
            singletern instance2 = singletern.GetInstance();

            instance1.DisplayMsg();

            if (instance1 == instance2) {
                {
                    Console.WriteLine("borth instance are same");
                }

            else
                {
                    Console.WriteLine("Instance are differnent");
                }
        }
    }
}
