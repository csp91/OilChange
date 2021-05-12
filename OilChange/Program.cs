using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OilChange
{
    public class Vehicle {
        string make;
        string model;
        int year;
        Vehicle( string inmake, string inmodel, int inyear )
        {
            make = inmake;
            model = inmodel;
            year = inyear;
        }
    }
    public class Oil
    {
        string oilweight;
        string oilbrand;
        double quantity;
        double oilprice;
        string filterbrand;
        double filterprice;
        Oil(string weight, string obrand, double quant, double oprice, string fbrand, double fprice)
        {
            oilweight = weight;
            oilbrand = obrand;
            quantity = quant;
            oilprice = oprice;
            filterbrand = fbrand;
            filterprice = fprice;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
