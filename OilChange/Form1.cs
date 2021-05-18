using System;
using System.Windows.Forms;
using OilChange.Controller;
using System.IO;
using static OilChange.Util.CsvParser;
using System.Collections.Generic;

namespace OilChange
{
    public partial class Form1 : Form
    {
        string fileTarget = Global.FileTarget;
        IEnumerable<string> eLines;
        CarController carCtrl;

        public Form1()
        {
            InitializeComponent();
            carCtrl = new CarController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                eLines = File.ReadLines(fileTarget);

                gridCarSelect.DataSource = ParseFile(eLines);



            } catch { }
        }


        private void gridCarSelect_SelectionChanged(object sender, EventArgs e)
        {

        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {

        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            if (!makeTextBox.ReadOnly)
            {

                carCtrl.AddCar(makeTextBox.Text, modelTextBox.Text, yearTextBox.Text);

                makeTextBox.ReadOnly = true;
                modelTextBox.ReadOnly = true;
                yearTextBox.ReadOnly = true;

                eLines = File.ReadLines(fileTarget);
                gridCarSelect.DataSource = ParseFile(eLines);

                return;


            }

            makeTextBox.ReadOnly = false;
            modelTextBox.ReadOnly = false;
            yearTextBox.ReadOnly = false;
        }

        private void gridCarSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gridCarSelect.SelectedRows.Count > 0)
                {
                    Vehicle selectedCar = (Vehicle)gridCarSelect.SelectedRows[0].DataBoundItem;

                    if (selectedCar != null)
                    {
                        makeTextBox.Text = selectedCar.Make;
                        modelTextBox.Text = selectedCar.Model;
                        yearTextBox.Text = selectedCar.Year.ToString();
                    }


                }

            }
            catch (Exception)
            {

            }
        }
    }
}
