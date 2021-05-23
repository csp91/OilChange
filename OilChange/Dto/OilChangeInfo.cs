using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilChange.Dto
{
    class OilChangeInfo
    {
        [System.ComponentModel.Browsable(false)] //Id will not be passed to the table
        public int Id { get; set; }
        public Vehicle Car { get; set; }
        public Oil Oil { get; set; }
        public double LaborHours { get; set; }
        public DateTime ServicedDate { get; set; }
        public int ServicedMileage { get; set; }
        public DateTime NextService { get; set; }
        public int NextServiceMileage { get; set; }

        public OilChangeInfo(int id, string make, string model, int year, string weight, string brand, double quantity, double oilPrice, string fBrand, double fPrice, double laborHours, DateTime servicedDate, int servicedMileage, DateTime nextService, int nextServiceMileage)
        {
            Id = id;

            Vehicle car = new Vehicle(make, model, year);
            this.Car = car;

            Oil oil = new Oil(weight, brand, quantity, oilPrice, fBrand, fPrice);
            this.Oil = oil;

            LaborHours = laborHours;
            ServicedDate = servicedDate;
            ServicedMileage = servicedMileage;
            NextService = nextService;
            NextServiceMileage = nextServiceMileage;
        }

        public OilChangeInfo(int id, Vehicle car, Oil oil, double laborHours, DateTime servicedDate, int servicedMileage, DateTime nextService, int nextServiceMileage)
        {
            Id = id;
            Car = car;
            Oil = oil;
            LaborHours = laborHours;
            ServicedDate = servicedDate;
            ServicedMileage = servicedMileage;
            NextService = nextService;
            NextServiceMileage = nextServiceMileage;
        }
    }
}
