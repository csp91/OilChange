﻿using OilChange.Dto;
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

        public async void AddVehicleService(string make, string model, string year)
        {
            string fileTarget = Global.FileTargetPath;
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

                if (make == "" || model == "" || !Int32.TryParse(year, out int x)) throw new InvalidValueException();
                await sw.WriteLineAsync(String.Format("{0},{1},{2},{3},{4}", nextId, make, model, year, "[]"));

            }
            catch (InvalidValueException)
            {
                MessageBox.Show("Unable to parse a value because it is empty or invalid");
            }
            catch (Exception)
            {
                
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
