using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OilChange;

//Data Transfer Object
namespace OilChange.Dto
{
    class CarServiceLog
    {
        public Vehicle Car { get; }
        public List<OilChange> OilChanges {get; }
    }
}
