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
        public int Id { get; set; }
        public Vehicle Car { get; }
        public List<OilChange> OilChanges {get; }

        public override bool Equals(object obj)
        {
            return this.GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return 123512 + Id.GetHashCode();
        }
    }
}
