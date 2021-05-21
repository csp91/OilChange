using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using OilChange.Dto;
using System.Globalization;
using System.Windows.Forms;

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
                    string[] carData = line.Split(new char[] {','}, 5, StringSplitOptions.None);
                    if (carData.Length >= 4 
                        && Int32.TryParse(carData[0], out int id)
                        && carData[1] is string make
                        && carData[2] is string model
                        && Int32.TryParse(carData[3], out int year))
                    {
                        Vehicle tempVehicle = new Vehicle(make, model, year);

                        List<OilChangeInfo> ociList = new List<OilChangeInfo>();
                        try
                        {
                            string[] ociLists = carData[4]
                                 .TrimStart('[')
                                 .TrimEnd(']')
                                 .Split('|');


                            ociList = ociLists.Select(x =>
                            {
                                string[] s = x.Split(',');

                                double quant = Double.TryParse(s[2], out double d) ? d : 0;
                                double oprice = Double.TryParse(s[3], out double o) ? o : 0;
                                double fprice = Double.TryParse(s[3], out double f) ? f : 0;
                                DateTime sd = DateTime.TryParse(s[6] + " " + DateTime.Now.TimeOfDay, out DateTime sdt) ? sdt : DateTime.Now;
                                int sm = Int32.TryParse(s[7], out int i) ? i : 0;
                                DateTime? nsd = null;
                                if (DateTime.TryParse(s[8], out DateTime nsdGood)) nsd = nsdGood;
                                int? nsm = null;
                                if (Int32.TryParse(s[9], out int nsmGood)) nsm = nsmGood;
                                Oil oil = new Oil(s[0], s[1], quant, oprice, s[4], fprice);

                                return new OilChangeInfo(oil, sd, sm, nsd, nsm);
                            }).ToList<OilChangeInfo>();

                        } catch {}

                        cars.Add(new CarMaintLog(id, tempVehicle, ociList));
                    }
                  
                }
            }
            catch {  }

            return cars;
        }
    }
}
