using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OilChange;

//Data Transfer Object
namespace OilChange.Dto
{
    class CarMaintLog
    {
        [System.ComponentModel.Browsable(false)]
        public int Id { get; set; }
        public string Make { get; }
        public string Model { get; }
        public string Year { get; }
        public List<OilChangeInfo> OilChanges {get; }

        public CarMaintLog(int id, Vehicle car, List<OilChangeInfo> oilChanges)
        {
            Id = id;
            Make = car.Make;
            Model = car.Model;
            Year = car.Year.ToString();
            OilChanges = oilChanges;
        }

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
