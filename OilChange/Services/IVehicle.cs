using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilChange.Services
{
    public interface IVehicle
    {
        List<Vehicle> GetVehicles(); 
    }
}
