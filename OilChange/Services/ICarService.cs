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
        CarMaintLog GetCarMaintLog(int id);

        void AddVehicleService(string make, string model, string year);
    }
}
