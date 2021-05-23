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
        public static List<OilChangeInfo> ParseFile(IEnumerable<string> enumLines)
        {
            List<OilChangeInfo> cars = new List<OilChangeInfo>();
            try
            {
                foreach (string line in enumLines)
                {
                    string[] carData = line.Split(new char[] { ',' }, StringSplitOptions.None);

                    //Check for proper format
                    if (carData.Length == 15
                            && Int32.TryParse(carData[0], out int id)
                            && carData[1] is string make
                            && carData[2] is string model
                            && Int32.TryParse(carData[3], out int year)
                            && carData[4] is string weight
                            && carData[5] is string brand
                            && Double.TryParse(carData[6], out double qty)
                            && Double.TryParse(carData[7], out double oPrice)
                            && carData[8] is string FBrand
                            && Double.TryParse(carData[9], out double FPrice)
                            && Double.TryParse(carData[10], out double labor)
                            && DateTime.TryParseExact(carData[11], "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime sDate)
                            && Int32.TryParse(carData[12], out int sMileage)
                            && DateTime.TryParseExact(carData[13], "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime nextDate)
                            && Int32.TryParse(carData[12], out int nextMileage)
                        )
                    {

                        Vehicle tempVehicle = new Vehicle(make, model, year);
                        Oil oil = new Oil(weight, brand, qty, oPrice, FBrand, FPrice);


                        cars.Add(new OilChangeInfo(id, tempVehicle, oil, labor, sDate, sMileage, nextDate, nextMileage));

                    }



                    //if (carData.Length >= 4 
                    //    && Int32.TryParse(carData[0], out int id)
                    //    && carData[1] is string make
                    //    && carData[2] is string model
                    //    && Int32.TryParse(carData[3], out int year))
                    //{
                    //    Vehicle tempVehicle = new Vehicle(make, model, year);

                    //    List<OilChangeInfo> ociList = new List<OilChangeInfo>();
                    //    try
                    //    {
                    //        string[] ociLists = carData[4]
                    //             .TrimStart('[')
                    //             .TrimEnd(']')
                    //             .Split('|');


                    //        ociList = ociLists.Select(x =>
                    //        {
                    //            string[] s = x.Split(',');

                    //            double quant = Double.TryParse(s[2], out double d) ? d : 0;
                    //            double oprice = Double.TryParse(s[3], out double o) ? o : 0;
                    //            double fprice = Double.TryParse(s[3], out double f) ? f : 0;
                    //            DateTime sd = DateTime.TryParse(s[6] + " " + DateTime.Now.TimeOfDay, out DateTime sdt) ? sdt : DateTime.Now;
                    //            int sm = Int32.TryParse(s[7], out int i) ? i : 0;
                    //            DateTime? nsd = null;
                    //            if (DateTime.TryParse(s[8], out DateTime nsdGood)) nsd = nsdGood;
                    //            int? nsm = null;
                    //            if (Int32.TryParse(s[9], out int nsmGood)) nsm = nsmGood;
                    //            Oil oil = new Oil(s[0], s[1], quant, oprice, s[4], fprice);

                    //            return new OilChangeInfo(oil, sd, sm, nsd, nsm);
                    //        }).ToList<OilChangeInfo>();

                    //    } catch {}

                    //    cars.Add(new CarMaintLog(id, tempVehicle, ociList));
                    //}

                }
            }
            catch {  }

            return cars;
        }
    }
}
