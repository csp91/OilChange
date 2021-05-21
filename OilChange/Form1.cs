using System;
using System.Windows.Forms;
using OilChange.Controller;
using System.IO;
using static OilChange.Util.CsvParser;
using static OilChange.Util.Toggler;
using System.Collections.Generic;
using OilChange.Dto;
using System.ComponentModel;
using OilChange.Exceptions;

namespace OilChange
{
    public partial class Form1 : Form
    {
        string fileTarget = Global.FileTargetPath;
        IEnumerable<string> eLines;
        CarController carCtrl;
        BindingList<CarMaintLog> src;

        public Form1()
        {
            InitializeComponent();
            carCtrl = new CarController();
            Global.FilePathChanged += new EventHandler<string>(OnFilePathChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                folderPathLabel.Text = "Data path: " + fileTarget;

                eLines = File.ReadLines(fileTarget);
                updateSource(ParseFile(eLines));

            } catch
            {

            }
        }

        private void OnFilePathChanged(object sender, string e)
        {
            fileTarget = e;
            folderPathLabel.Text = "Data Path: " + e;
        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            if (!makeTextBox.ReadOnly)
            {
                try
                {
                    carCtrl.AddCar(makeTextBox.Text, modelTextBox.Text, yearTextBox.Text);

                    eLines = File.ReadLines(fileTarget);
                    updateSource(ParseFile(eLines));
                }
                catch 
                {
                  
                }


                gridCarSelect.ClearSelection();

                ToggleReadOnly(new object[] { makeTextBox, modelTextBox, yearTextBox });
                return;
            }

            ToggleReadOnly(new object[] { makeTextBox, modelTextBox, yearTextBox });
        }

        private void gridCarSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gridCarSelect.SelectedRows.Count > 0)
                {
                    CarMaintLog selectedCar = (CarMaintLog) gridCarSelect.SelectedRows[0].DataBoundItem;

                    if (selectedCar != null)
                    {
                        makeTextBox.Text = selectedCar.Make;
                        modelTextBox.Text = selectedCar.Model;
                        yearTextBox.Text = selectedCar.Year.ToString();
                    }

                    
                     gridOilLog.DataSource = selectedCar.OilChanges;

                }

            }
            catch (Exception)
            {

            }
        }

        private void updateSource(List<CarMaintLog> s)
        {
            src = new BindingList<CarMaintLog>(s);
            gridCarSelect.DataSource = src;
        }

        private void gridCarSelect_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridCarSelect.ClearSelection();
        }

    }
}
