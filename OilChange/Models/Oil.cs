using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilChange
{
    public class Oil
    {
        string oilweight;
        string oilbrand;
        double quantity;
        double oilprice;
        string filterbrand;
        double filterprice;
        
        public Oil(string weight, string obrand, double quant, double oprice, string fbrand, double fprice)
        {
            oilweight = weight;
            oilbrand = obrand;
            quantity = quant;
            oilprice = oprice;
            filterbrand = fbrand;
            filterprice = fprice;
        }
    }
}
