using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using OilChange.Services;

namespace OilChange.Controller
{
    class CarController
    {
        public void AddCar(string make, string model, string year)
        {
            VehicleService server = new VehicleService();

            try
            {
                server.AddVehicleService(make, model, year);
            }
            catch { }
            
        }

        //Update the selected car + oilchange history associated with it

        //Delete the car entirety

        //Delete the oilChangelog

        //GetAllData - Parses a specific line. 
                //Parse Car, Parse array 
    }
}
