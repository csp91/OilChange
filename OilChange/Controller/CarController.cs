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
            StreamWriter sw = null;

            try
            {
                if (File.Exists(fileTarget))
                {
                    sw = new StreamWriter(fileTarget, append:true);
                }
                else
                {
                    File.Create(fileTarget);
                    sw = new StreamWriter(fileTarget, append: true);
                }

                sw.WriteLine(String.Format("{0},{1},{2}", make, model, year));

            }
            catch (Exception e) {
                MessageBox.Show(e.Message); 
            }
            finally { if (sw != null) sw.Close(); };


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
