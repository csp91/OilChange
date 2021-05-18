using OilChange.Services;
using System;
using System.Windows.Forms;
using OilChange.Controller;
using System.IO;
using System.Collections.Generic;
namespace OilChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var enumLines = File.ReadLines("G:\\temp\\test.csv");

            List<Vehicle> cars = new List<Vehicle>();

            foreach (var line in enumLines)
            {
                string[] carData = line.Split(',');


                Vehicle temp = new Vehicle(carData[0], carData[1], Int32.Parse(carData[2]));

                cars.Add(temp);
            }

            gridCarSelect.DataSource = cars;

        }


        private void gridCarSelect_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (gridCarSelect.SelectedRows.Count > 0)
                {
                    Vehicle selectedCar = (Vehicle)gridCarSelect.SelectedRows[0].DataBoundItem;
                    makeTextBox.Text = selectedCar.Make;
                    modelTextBox.Text = selectedCar.Model;
                    yearTextBox.Text = selectedCar.Year.ToString();
                }

            } catch(Exception)
            {

            }


        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            CarController carCtrl = new CarController();

            carCtrl.Add(makeTextBox.Text, modelTextBox.Text, yearTextBox.Text);
        }
    }
}
