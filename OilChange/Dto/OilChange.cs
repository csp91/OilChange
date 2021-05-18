using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilChange.Dto
{
    class OilChangeInfo
    {
        public Oil Oil {get; }
        public DateTime ServicedDate { get; set; }
        public int ServicedeMileage { get; set; }
        public DateTime NextService { get; set; }
        public int NextServiceMileage { get; set; }

    }
}
