using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OilChange.Util
{
    static class CsvParser
    {
        public static List<Vehicle> ParseFile(IEnumerable<string> enumLines)
        {
            List<Vehicle> cars = new List<Vehicle>();
            try
            {
                foreach (string line in enumLines)
                {
                    string[] carData = line.Split(',');

                    if (carData.Length >= 4 && carData[1] is string make && carData[2] is string model && Int32.TryParse(carData[3], out int year))
                    {
                        Vehicle temp = new Vehicle(make, model, year);
                        cars.Add(temp);
                    }
                }
            }
            catch { }

            return cars;
        }
    }
}
