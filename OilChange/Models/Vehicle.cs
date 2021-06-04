using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilChange

{
    public class Vehicle
    {
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }

        public Vehicle(string inmake, string inmodel, int inyear)
        {
            Make = inmake;
            Model = inmodel;
            Year = inyear;
        }
        public override string ToString()
        {
            return Year + " " + Make + " " + Model + " ";
        }
    }   
}
