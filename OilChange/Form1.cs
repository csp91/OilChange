using System;
using System.Windows.Forms;
using OilChange.Services;
using System.IO;
using static OilChange.Util.CsvParser;
using static OilChange.Util.Toggler;
using System.Collections.Generic;
using OilChange.Dto;
using System.ComponentModel;
using OilChange.Exceptions;
using System.Linq;

namespace OilChange
{
    public partial class Form1 : Form
    {
        //Fields
        string fileTarget = Global.FileTargetPath;
        IEnumerable<string> eLines; //String array when file is read
        VehicleService fileData = new VehicleService(); //methods for accessing the data in the file

        //Constructor
        public Form1()
        {
            InitializeComponent();
            Global.FilePathChanged += new EventHandler<string>(OnFilePathChanged);
        }

        //Event-handler when form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                folderPathLabel.Text = "Data path: " + fileTarget;

                eLines = File.ReadLines(fileTarget);
                updateCarList(ParseFile(eLines));

            } catch
            {

            }
        }

        //Event-handler when file path changed 
        private void OnFilePathChanged(object sender, string e)
        {
            fileTarget = e;
            folderPathLabel.Text = "Data Path: " + e;
        }

        //Event-Handler when add button is clicked
        //New Vehicle
        private void addCarBtn_Click(object sender, EventArgs e)
        {
            //Execute Add button
            if (!makeTextBox.ReadOnly)
            {
                try
                {


                    //Parse the data from textboxes/////
                    //Car Textboxes
                    string make = makeTextBox.Text;
                    string model = modelTextBox.Text;
                    int year = Int32.Parse(yearTextBox.Text);

                    Vehicle carObj = new Vehicle(make, model, year);

                    //Oil Textboxes
                    string w = weightTextBox.Text;
                    string b = brandTextBox.Text;
                    double qty = Double.Parse(qtyTextBox.Text);
                    double oprice = Double.Parse(oPriceTextBox.Text);
                    string fb = fBrandTextBox.Text;
                    double fp = Double.Parse(fPriceTextBox.Text);

                    Oil oilObj = new Oil(w, b, qty, oprice, fb, fp);

                    //Service info
                    double labor = Double.Parse(laborHourTextBox.Text);
                    DateTime sDate = DateTime.Parse(dateTimePicker1.Text);
                    int sMileage = Int32.Parse(sMileageTxtbox.Text);
                    DateTime ns = dateTimePicker2.Value;
                    int nm = Int32.Parse(nextSMileageTxtbox.Text);

                    //Add new vehicle to the file
                    fileData.AddVehicleService(carObj, oilObj, labor, sDate, sMileage, ns, nm);


                    //Read the file
                    eLines = File.ReadLines(fileTarget);

                    //Update main source
                    updateCarList(ParseFile(eLines));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                gridCarSelect.ClearSelection();

                ToggleReadOnly(makeTextBox, modelTextBox, yearTextBox, weightTextBox, brandTextBox, qtyTextBox, oPriceTextBox, fBrandTextBox, fPriceTextBox, laborHourTextBox, sMileageTxtbox, nextSMileageTxtbox);
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                gridCarSelect.Enabled = true;
                return;
            }


            //Unlock textboxes for user input
            ToggleReadOnly(makeTextBox, modelTextBox, yearTextBox, weightTextBox, brandTextBox, qtyTextBox, oPriceTextBox, fBrandTextBox, fPriceTextBox, laborHourTextBox, sMileageTxtbox, nextSMileageTxtbox);
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;

            //Clears out everything
            newForm();
        }

        //Event-Handler: When user click a vehicle
        private void gridCarSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridCarSelect.SelectedRows.Count > 0)
            {
                OilChangeInfo oci = parseObjToOilChangeInfo(gridCarSelect.SelectedRows[0].DataBoundItem);
                makeTextBox.Text = oci.Car.Make;
                modelTextBox.Text = oci.Car.Model;
                yearTextBox.Text = oci.Car.Year.ToString();
                weightTextBox.Text = oci.Oil.Weight;
                brandTextBox.Text = oci.Oil.Brand;
                qtyTextBox.Text = oci.Oil.Quantity.ToString();
                oPriceTextBox.Text = oci.Oil.OilPrice.ToString();
                fPriceTextBox.Text = oci.Oil.FPrice.ToString();
                fBrandTextBox.Text = oci.Oil.FBrand;
                laborHourTextBox.Text = oci.LaborHours.ToString();
                dateTimePicker1.Value = oci.ServicedDate;
                dateTimePicker2.Value = oci.NextService;
                sMileageTxtbox.Text = oci.ServicedMileage.ToString();
                nextSMileageTxtbox.Text = oci.NextServiceMileage.ToString();
          
            }
        }

        //Event-Handler: Reset selection when data is updated
        private void gridCarSelect_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridCarSelect.ClearSelection();
        }


        //Local method for updating the Main Array
        private void updateCarList(List<OilChangeInfo> s) //s is the passed List of cars from the file
        {
            //Updates the main source
            Global.MainArraySource = s; 

            //Updates the displayed table
            var bind = Global.MainArraySource.Select(x =>
                        new {
                            Id = x.Id,
                            Make = x.Car.Make,
                            Model = x.Car.Model,
                            Year = x.Car.Year,
                            Weight = x.Oil.Weight,
                            Brand = x.Oil.Brand,
                            Quantity = x.Oil.Quantity,
                            OilPrice = x.Oil.OilPrice,
                            FBrand = x.Oil.FBrand,
                            FPrice = x.Oil.FPrice,
                            ServicedDate = x.ServicedDate,
                            ServicedMileage = x.ServicedMileage,
                            LaborHour = x.LaborHours,
                            NextServiceDate = x.NextService,
                            NextMileage = x.NextServiceMileage
                        }).ToList();

            gridCarSelect.AutoGenerateColumns = false;
            gridCarSelect.DataSource = bind;

        }

        private OilChangeInfo parseObjToOilChangeInfo(object obj)
        {
            var props = obj.GetType().GetProperties();

            int id = 1000000;
            string make = "Unknown";
            string model = "Unknown";
            int year = 9999;

            string weight = "Unknown";
            string brand = "Unknown";
            string fbrand = "Unknown";
            double fprice = 0;
            double qty = 0;
            double oprice = 0;

            double labor = 0;
            DateTime sd = DateTime.Now;
            int mileage = 0;
            DateTime nextDate = DateTime.Now;
            int nm = 0;


            foreach(var prop in props)
            {
                if (prop.Name == "Id") id = (int) prop.GetValue(obj);
                if (prop.Name == "Make") make = prop.GetValue(obj) as string;
                if (prop.Name == "Model") model = prop.GetValue(obj) as string;
                if (prop.Name == "Year") year = (int) prop.GetValue(obj);

                if (prop.Name == "Weight") weight = prop.GetValue(obj) as string;
                if (prop.Name == "Brand") brand = prop.GetValue(obj) as string;
                if (prop.Name == "FBrand") fbrand = prop.GetValue(obj) as string;
                if (prop.Name == "Quantity") qty = (double) prop.GetValue(obj);
                if (prop.Name == "FPrice") fprice = (double)prop.GetValue(obj);
                if (prop.Name == "OilPrice") oprice = (double)prop.GetValue(obj);

                if (prop.Name == "LaborHour") labor = (double)prop.GetValue(obj);
                if (prop.Name == "ServicedDate") sd = (DateTime) prop.GetValue(obj);
                if (prop.Name == "ServicedMileage") mileage = (int) prop.GetValue(obj);
                if (prop.Name == "NextMileage") nm = (int) prop.GetValue(obj);
                if (prop.Name == "NextServiceDate") nextDate = (DateTime) prop.GetValue(obj);
            }

            OilChangeInfo oci = new OilChangeInfo(id, make, model, year, weight, brand, qty, oprice, fbrand, fprice, labor, sd, mileage, nextDate, nm);

            return oci;
        }

        private void newForm()
        {
            gridCarSelect.ClearSelection();
            gridCarSelect.Enabled = false;
            makeTextBox.Text = "";
            modelTextBox.Text = "";
            yearTextBox.Text = "";
            weightTextBox.Text = "";
            brandTextBox.Text = "";
            qtyTextBox.Text = "";
            oPriceTextBox.Text = "";
            fPriceTextBox.Text = "";
            fBrandTextBox.Text = "";
            laborHourTextBox.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now.AddMonths(3);
            sMileageTxtbox.Text = "";
            nextSMileageTxtbox.Text = "";
        }
    }
}
