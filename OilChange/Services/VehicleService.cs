using OilChange.Dto;
using OilChange.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using OilChange.Util;

namespace OilChange.Services
{
    class VehicleService : ICarService
    {
        FileStream fsw = null;
        FileStream fsr = null;
        StreamWriter sw = null;
        StreamReader sr = null;

        public async void AddVehicleService(Vehicle car, Oil oil, double labor, DateTime sDate, int sMileage, DateTime nextService, int nextMileage)
        {
            try
            {
                //Append to the file
                FileUtils.OpenFileStreamers(ref fsw, ref fsr, ref sr, ref sw);

                //Generate new ID by reading the highest id number from the file and adding 1.
                int nextId = 0;
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (Int32.TryParse(line.Split(',')[0], out int id))
                    {
                        if (id >= nextId) nextId = id + 1;
                    }
                }

                //Check for invalid values and empty string
                if (car.Make == "" ||
                    car.Model == "" ||
                    car.Year.ToString() == "" ||
                    oil.Weight == "" ||
                    oil.Brand == "")
                {
                    throw new InvalidValueException("No empty string");
                }


                await sw.WriteLineAsync(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}",
                    nextId,
                    car.Make,
                    car.Model,
                    car.Year,
                    oil.Weight,
                    oil.Brand,
                    oil.Quantity,
                    oil.OilPrice,
                    oil.FBrand,
                    oil.FPrice,
                    labor,
                    sDate.ToString("MM/dd/yyyy"),
                    sMileage,
                    nextService.ToString("MM/dd/yyyy"),
                    nextMileage
                    ));

            }
            catch (InvalidValueException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Write/Read Streamer objects 
                FileUtils.CloseFileStreamers(sr,sw,fsw,fsr);
            };
        }

    }
}
