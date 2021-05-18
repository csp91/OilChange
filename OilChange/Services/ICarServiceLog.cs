using OilChange.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilChange.Services
{
    interface ICarServiceLog
    {
        CarServiceLog GetCarServiceLog(int id);
    }
}
