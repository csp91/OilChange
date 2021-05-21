using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilChange.Dto
{
    class OilChangeInfo
    {
        public string Weight { get; set; }
        public string Brand { get; set; }
        public double Quantity { get; set; }
        public double OilPrice { get; set; }
        public string FBrand { get; set; }
        public double FPrice { get; set; }
        public DateTime ServicedDate { get; set; }
        public int ServicedMileage { get; set; }
        public DateTime? NextService { get; set; }
        public int? NextServiceMileage { get; set; }

        public OilChangeInfo(string weight, string brand, double quantity, double oilPrice, string fBrand, double fPrice, DateTime servicedDate, int servicedMileage, DateTime? nextService, int? nextServiceMileage)
        {
            Weight = weight ?? throw new ArgumentNullException(nameof(weight));
            Brand = brand ?? throw new ArgumentNullException(nameof(brand));
            Quantity = quantity;
            OilPrice = oilPrice;
            FBrand = fBrand ?? throw new ArgumentNullException(nameof(fBrand));
            FPrice = fPrice;
            ServicedDate = servicedDate;
            ServicedMileage = servicedMileage;
            NextService = nextService;
            NextServiceMileage = nextServiceMileage;
        }

        public OilChangeInfo(Oil oil, DateTime servicedDate, int servicedMileage, DateTime? nextService, int? nextServiceMileage)
        {
            Weight = oil.Weight ?? throw new ArgumentNullException();
            Brand = oil.Brand ?? throw new ArgumentNullException();
            Quantity = oil.Quantity;
            OilPrice = oil.OilPrice;
            FBrand = oil.FBrand ?? throw new ArgumentNullException();
            FPrice = oil.FPrice;
            ServicedDate = servicedDate;
            ServicedMileage = servicedMileage;
            NextService = nextService;
            NextServiceMileage = nextServiceMileage;
        }
    }
}
