using OilChange.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilChange.Services
{
    interface ICarService
    {
        void AddVehicleService(Vehicle car, Oil oil, double labor, DateTime sDate, int sMileage, DateTime nextService, int nextMileage);

        //void AddOilLogToCar(int carId, OilChangeInfo ocInfo);
    }
}
