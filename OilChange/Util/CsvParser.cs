using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using OilChange.Dto;

namespace OilChange.Util
{
    static class CsvParser
    {
        public static List<CarMaintLog> ParseFile(IEnumerable<string> enumLines)
        {
            List<CarMaintLog> cars = new List<CarMaintLog>();
            try
            {
                foreach (string line in enumLines)
                {
                    string[] carData = line.Split(',');

                    if (carData.Length >= 4 
                        && Int32.TryParse(carData[0], out int id)
                        && carData[1] is string make
                        && carData[2] is string model
                        && Int32.TryParse(carData[3], out int year))
                    {
                        Vehicle tempVehicle = new Vehicle(make, model, year);
                        cars.Add(new CarMaintLog(id, tempVehicle, new List<OilChangeInfo>()));
                    }
                }
            }
            catch { }

            return cars;
        }
    }
}
