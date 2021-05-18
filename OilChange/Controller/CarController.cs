using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace OilChange.Controller
{
    class CarController
    {
        public void Add(string make, string model, string year)
        {
            string fileTarget = "G:\\temp\\test.csv";
            FileStream fs = null;

            try
            {
                if (File.Exists(fileTarget))
                {
                    fs = File.OpenWrite(fileTarget);
                }
                else
                {
                    fs = File.Create(fileTarget);
                }

                //Serialize
                byte[] info = new UTF8Encoding(true).GetBytes(String.Format("{0},{1},{2}",make,model,year));

                //Write to file
                fs.Write(info, 0, info.Length);

            }
            catch (Exception e) {
                MessageBox.Show(e.Message); 
            }
            finally { if (fs != null) fs.Close(); };


            //Locate csv file if exists

            //Auto generated Id
                
            //
        }

        //Update the selected car + oilchange history associated with it

        //Delete the car entirety

        //Delete the oilChangelog

        //GetAllData - Parses a specific line. 
                //Parse Car, Parse array 
    }
}
