using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilChange.Services
{
    class VehicleService : IVehicle
    {
        public List<Vehicle> GetVehicles()
        {
            List<Vehicle> cars = new List<Vehicle>();

            //TEST: Fake cars data. Might remove it later and parse a file instead
            cars.Add(new Vehicle("Ford", "Explorer", 2014));
            cars.Add(new Vehicle("Mazda", "CX-5", 2015));

            return cars;
        }
    }
}
