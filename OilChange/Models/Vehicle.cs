using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilChange

{
    public class Vehicle
    {
        string make;
        string model;
        int year;

        public Vehicle(string inmake, string inmodel, int inyear)
        {
            make = inmake;
            model = inmodel;
            year = inyear;
        }
    }
}
