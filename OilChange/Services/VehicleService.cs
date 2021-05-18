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

namespace OilChange.Services
{
    class VehicleService : ICarService
    {

        public CarMaintLog GetCarMaintLog(int id)
        {
                
                CarMaintLog carLog = new CarMaintLog();
                throw new NoDataFoundException("Car does not exist");
                return carLog;

        }

        public async void AddVehicleService(string make, string model, string year)
        {
            string fileTarget = Global.FileTarget;
            FileStream fsw = null;
            FileStream fsr = null;
            StreamWriter sw = null;
            StreamReader sr = null;

            try
            {
                if (!File.Exists(fileTarget))
                {
                    File.Create(fileTarget).Close();

                    for(int i = 0; i > 3; i++)
                    {
                        if (File.Exists(fileTarget)) break;
                        Thread.Sleep(1500);
                    }
                }

                fsw = new FileStream(fileTarget, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                fsr = new FileStream(fileTarget, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                sw = new StreamWriter(fsw);
                sr = new StreamReader(fsr);

                int nextId = 0;
                string line = "";

                while ((line = sr.ReadLine()) != null)
                {
                    if (Int32.TryParse(line.Split(',')[0], out int id))
                    {
                        if (id >= nextId) nextId = id + 1;
                    }
                }

                await sw.WriteLineAsync(String.Format("{0},{1},{2},{3}", nextId, make, model, year));

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                sw?.Close();
                sr?.Close();
                fsw?.Close();
                fsr?.Close();
            };
        }

    }
}
