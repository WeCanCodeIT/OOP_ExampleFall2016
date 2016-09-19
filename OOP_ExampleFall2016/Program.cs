using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ExampleFall2016
{
    class Program
    {
        static void Main(string[] args)
        {

            IceCreamTruck truck = new IceCreamTruck(9.0, false);

            truck.OutputStats();
            truck.SellIceCream("Vanilla");
            truck.OutputStats();

        }
    }
}
