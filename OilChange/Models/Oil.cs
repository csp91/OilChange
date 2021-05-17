using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilChange
{
    public class Oil
    {
        public string Weight { get; }
        public string Brand {get;}
        public double Quantity {get;}
        public double OilPrice {get;}
        public string FBrand {get;}
        public double FPrice {get;}
        
        public Oil(string weight, string obrand, double quant, double oprice, string fbrand, double fprice)
        {
            Weight = weight;
            Brand = obrand;
            Quantity = quant;
            OilPrice = oprice;
            FBrand = fbrand;
            FPrice = fprice;
        }
    }
}
