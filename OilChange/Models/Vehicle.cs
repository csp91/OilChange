using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilChange

{
    public class Vehicle
    {
        public string make { get; }
        public string model { get; }
        public int year { get; }

        public Vehicle(string inmake, string inmodel, int inyear)
        {
            make = inmake;
            model = inmodel;
            year = inyear;
        }
    }
}
