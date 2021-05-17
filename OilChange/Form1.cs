using OilChange.Services;
using System;
using System.Windows.Forms;


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
            VehicleService vService = new VehicleService();
            gridCarSelect.DataSource = vService.GetVehicles();
        }


        private void gridCarSelect_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (gridCarSelect.SelectedRows.Count > 0)
                {
                    Vehicle selectedCar = (Vehicle)gridCarSelect.SelectedRows[0].DataBoundItem;
                    makeTextBox.Text = selectedCar.make;
                    modelTextBox.Text = selectedCar.model;
                    yearTextBox.Text = selectedCar.year.ToString();
                }

            } catch(Exception)
            {

            }


        }
    }
}
