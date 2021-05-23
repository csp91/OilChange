namespace OilChange
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridCarSelect = new System.Windows.Forms.DataGridView();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.fBrandTextBox = new System.Windows.Forms.TextBox();
            this.oPriceTextBox = new System.Windows.Forms.TextBox();
            this.fPriceTextBox = new System.Windows.Forms.TextBox();
            this.makeLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.oilQtyLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.oPriceLabel = new System.Windows.Forms.Label();
            this.fBrandLabel = new System.Windows.Forms.Label();
            this.fPriceLabel = new System.Windows.Forms.Label();
            this.addCarBtn = new System.Windows.Forms.Button();
            this.updateCarBtn = new System.Windows.Forms.Button();
            this.addOilLogBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateSerivcedLabel = new System.Windows.Forms.Label();
            this.nextServiceLabel = new System.Windows.Forms.Label();
            this.nextSMileageTxtbox = new System.Windows.Forms.TextBox();
            this.nextServiceMileageLabel = new System.Windows.Forms.Label();
            this.folderPathLabel = new System.Windows.Forms.Label();
            this.sMileageTxtbox = new System.Windows.Forms.TextBox();
            this.servicemileagelabel = new System.Windows.Forms.Label();
            this.laborHourTextBox = new System.Windows.Forms.TextBox();
            this.laborHourlbl = new System.Windows.Forms.Label();
            this.make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCarSelect
            // 
            this.gridCarSelect.AllowUserToResizeRows = false;
            this.gridCarSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCarSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.make,
            this.model,
            this.year});
            this.gridCarSelect.Location = new System.Drawing.Point(617, 29);
            this.gridCarSelect.Name = "gridCarSelect";
            this.gridCarSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCarSelect.Size = new System.Drawing.Size(836, 231);
            this.gridCarSelect.TabIndex = 0;
            this.gridCarSelect.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridCarSelect_DataBindingComplete);
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(28, 64);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.ReadOnly = true;
            this.makeTextBox.Size = new System.Drawing.Size(115, 20);
            this.makeTextBox.TabIndex = 2;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(156, 64);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ReadOnly = true;
            this.modelTextBox.Size = new System.Drawing.Size(160, 20);
            this.modelTextBox.TabIndex = 3;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(331, 64);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.ReadOnly = true;
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 4;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(28, 131);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.ReadOnly = true;
            this.weightTextBox.Size = new System.Drawing.Size(87, 20);
            this.weightTextBox.TabIndex = 5;
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(130, 131);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.ReadOnly = true;
            this.brandTextBox.Size = new System.Drawing.Size(153, 20);
            this.brandTextBox.TabIndex = 6;
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(301, 131);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.ReadOnly = true;
            this.qtyTextBox.Size = new System.Drawing.Size(70, 20);
            this.qtyTextBox.TabIndex = 7;
            // 
            // fBrandTextBox
            // 
            this.fBrandTextBox.Location = new System.Drawing.Point(28, 182);
            this.fBrandTextBox.Name = "fBrandTextBox";
            this.fBrandTextBox.ReadOnly = true;
            this.fBrandTextBox.Size = new System.Drawing.Size(118, 20);
            this.fBrandTextBox.TabIndex = 8;
            // 
            // oPriceTextBox
            // 
            this.oPriceTextBox.Location = new System.Drawing.Point(389, 131);
            this.oPriceTextBox.Name = "oPriceTextBox";
            this.oPriceTextBox.ReadOnly = true;
            this.oPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.oPriceTextBox.TabIndex = 9;
            // 
            // fPriceTextBox
            // 
            this.fPriceTextBox.Location = new System.Drawing.Point(159, 182);
            this.fPriceTextBox.Name = "fPriceTextBox";
            this.fPriceTextBox.ReadOnly = true;
            this.fPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.fPriceTextBox.TabIndex = 10;
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(25, 45);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(34, 13);
            this.makeLabel.TabIndex = 11;
            this.makeLabel.Text = "Make";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(153, 45);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(36, 13);
            this.modelLabel.TabIndex = 12;
            this.modelLabel.Text = "Model";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(328, 45);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 13);
            this.yearLabel.TabIndex = 13;
            this.yearLabel.Text = "Year";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(28, 115);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(56, 13);
            this.weightLabel.TabIndex = 14;
            this.weightLabel.Text = "Oil Weight";
            // 
            // oilQtyLabel
            // 
            this.oilQtyLabel.AutoSize = true;
            this.oilQtyLabel.Location = new System.Drawing.Point(299, 115);
            this.oilQtyLabel.Name = "oilQtyLabel";
            this.oilQtyLabel.Size = new System.Drawing.Size(61, 13);
            this.oilQtyLabel.TabIndex = 15;
            this.oilQtyLabel.Text = "Oil Quantity";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(127, 115);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(50, 13);
            this.brandLabel.TabIndex = 16;
            this.brandLabel.Text = "Oil Brand";
            // 
            // oPriceLabel
            // 
            this.oPriceLabel.AutoSize = true;
            this.oPriceLabel.Location = new System.Drawing.Point(388, 115);
            this.oPriceLabel.Name = "oPriceLabel";
            this.oPriceLabel.Size = new System.Drawing.Size(46, 13);
            this.oPriceLabel.TabIndex = 17;
            this.oPriceLabel.Text = "Oil Price";
            // 
            // fBrandLabel
            // 
            this.fBrandLabel.AutoSize = true;
            this.fBrandLabel.Location = new System.Drawing.Point(28, 166);
            this.fBrandLabel.Name = "fBrandLabel";
            this.fBrandLabel.Size = new System.Drawing.Size(60, 13);
            this.fBrandLabel.TabIndex = 18;
            this.fBrandLabel.Text = "Filter Brand";
            // 
            // fPriceLabel
            // 
            this.fPriceLabel.AutoSize = true;
            this.fPriceLabel.Location = new System.Drawing.Point(156, 166);
            this.fPriceLabel.Name = "fPriceLabel";
            this.fPriceLabel.Size = new System.Drawing.Size(56, 13);
            this.fPriceLabel.TabIndex = 19;
            this.fPriceLabel.Text = "Filter Price";
            // 
            // addCarBtn
            // 
            this.addCarBtn.Location = new System.Drawing.Point(31, 419);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(75, 23);
            this.addCarBtn.TabIndex = 20;
            this.addCarBtn.Text = "Add";
            this.addCarBtn.UseVisualStyleBackColor = true;
            this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
            // 
            // updateCarBtn
            // 
            this.updateCarBtn.Location = new System.Drawing.Point(137, 419);
            this.updateCarBtn.Name = "updateCarBtn";
            this.updateCarBtn.Size = new System.Drawing.Size(75, 23);
            this.updateCarBtn.TabIndex = 22;
            this.updateCarBtn.Text = "Update";
            this.updateCarBtn.UseVisualStyleBackColor = true;
            // 
            // addOilLogBtn
            // 
            this.addOilLogBtn.Location = new System.Drawing.Point(359, 617);
            this.addOilLogBtn.Name = "addOilLogBtn";
            this.addOilLogBtn.Size = new System.Drawing.Size(75, 23);
            this.addOilLogBtn.TabIndex = 23;
            this.addOilLogBtn.Text = "Add";
            this.addOilLogBtn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd MMM yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 235);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd MMM yyyy";
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(25, 297);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(118, 20);
            this.dateTimePicker2.TabIndex = 28;
            this.dateTimePicker2.Value = new System.DateTime(2021, 8, 22, 20, 24, 47, 484);
            // 
            // dateSerivcedLabel
            // 
            this.dateSerivcedLabel.AutoSize = true;
            this.dateSerivcedLabel.Location = new System.Drawing.Point(25, 219);
            this.dateSerivcedLabel.Name = "dateSerivcedLabel";
            this.dateSerivcedLabel.Size = new System.Drawing.Size(75, 13);
            this.dateSerivcedLabel.TabIndex = 29;
            this.dateSerivcedLabel.Text = "Serviced Date";
            // 
            // nextServiceLabel
            // 
            this.nextServiceLabel.AutoSize = true;
            this.nextServiceLabel.Location = new System.Drawing.Point(25, 281);
            this.nextServiceLabel.Name = "nextServiceLabel";
            this.nextServiceLabel.Size = new System.Drawing.Size(94, 13);
            this.nextServiceLabel.TabIndex = 30;
            this.nextServiceLabel.Text = "Next Service Date";
            // 
            // nextSMileageTxtbox
            // 
            this.nextSMileageTxtbox.Location = new System.Drawing.Point(154, 297);
            this.nextSMileageTxtbox.Name = "nextSMileageTxtbox";
            this.nextSMileageTxtbox.ReadOnly = true;
            this.nextSMileageTxtbox.Size = new System.Drawing.Size(120, 20);
            this.nextSMileageTxtbox.TabIndex = 31;
            // 
            // nextServiceMileageLabel
            // 
            this.nextServiceMileageLabel.AutoSize = true;
            this.nextServiceMileageLabel.Location = new System.Drawing.Point(151, 281);
            this.nextServiceMileageLabel.Name = "nextServiceMileageLabel";
            this.nextServiceMileageLabel.Size = new System.Drawing.Size(108, 13);
            this.nextServiceMileageLabel.TabIndex = 32;
            this.nextServiceMileageLabel.Text = "Next Service Mileage";
            // 
            // folderPathLabel
            // 
            this.folderPathLabel.AutoSize = true;
            this.folderPathLabel.Location = new System.Drawing.Point(503, 13);
            this.folderPathLabel.Name = "folderPathLabel";
            this.folderPathLabel.Size = new System.Drawing.Size(0, 13);
            this.folderPathLabel.TabIndex = 33;
            // 
            // sMileageTxtbox
            // 
            this.sMileageTxtbox.Location = new System.Drawing.Point(154, 235);
            this.sMileageTxtbox.Name = "sMileageTxtbox";
            this.sMileageTxtbox.ReadOnly = true;
            this.sMileageTxtbox.Size = new System.Drawing.Size(120, 20);
            this.sMileageTxtbox.TabIndex = 34;
            // 
            // servicemileagelabel
            // 
            this.servicemileagelabel.AutoSize = true;
            this.servicemileagelabel.Location = new System.Drawing.Point(153, 219);
            this.servicemileagelabel.Name = "servicemileagelabel";
            this.servicemileagelabel.Size = new System.Drawing.Size(89, 13);
            this.servicemileagelabel.TabIndex = 35;
            this.servicemileagelabel.Text = "Serviced Mileage";
            // 
            // laborHourTextBox
            // 
            this.laborHourTextBox.Location = new System.Drawing.Point(302, 235);
            this.laborHourTextBox.Name = "laborHourTextBox";
            this.laborHourTextBox.ReadOnly = true;
            this.laborHourTextBox.Size = new System.Drawing.Size(100, 20);
            this.laborHourTextBox.TabIndex = 36;
            // 
            // laborHourlbl
            // 
            this.laborHourlbl.AutoSize = true;
            this.laborHourlbl.Location = new System.Drawing.Point(302, 218);
            this.laborHourlbl.Name = "laborHourlbl";
            this.laborHourlbl.Size = new System.Drawing.Size(69, 13);
            this.laborHourlbl.TabIndex = 37;
            this.laborHourlbl.Text = "Labor (hours)";
            // 
            // make
            // 
            this.make.DataPropertyName = "Make";
            this.make.HeaderText = "Make";
            this.make.Name = "make";
            this.make.ReadOnly = true;
            this.make.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.make.Width = 130;
            // 
            // model
            // 
            this.model.DataPropertyName = "Model";
            this.model.HeaderText = "Model";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.model.Width = 160;
            // 
            // year
            // 
            this.year.DataPropertyName = "Year";
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            this.year.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 764);
            this.Controls.Add(this.laborHourlbl);
            this.Controls.Add(this.laborHourTextBox);
            this.Controls.Add(this.servicemileagelabel);
            this.Controls.Add(this.sMileageTxtbox);
            this.Controls.Add(this.folderPathLabel);
            this.Controls.Add(this.nextServiceMileageLabel);
            this.Controls.Add(this.nextSMileageTxtbox);
            this.Controls.Add(this.nextServiceLabel);
            this.Controls.Add(this.dateSerivcedLabel);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.addOilLogBtn);
            this.Controls.Add(this.updateCarBtn);
            this.Controls.Add(this.addCarBtn);
            this.Controls.Add(this.fPriceLabel);
            this.Controls.Add(this.fBrandLabel);
            this.Controls.Add(this.oPriceLabel);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.oilQtyLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.fPriceTextBox);
            this.Controls.Add(this.oPriceTextBox);
            this.Controls.Add(this.fBrandTextBox);
            this.Controls.Add(this.qtyTextBox);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.gridCarSelect);
            this.Name = "Form1";
            this.Text = "Oil Change Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCarSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCarSelect;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.TextBox fBrandTextBox;
        private System.Windows.Forms.TextBox oPriceTextBox;
        private System.Windows.Forms.TextBox fPriceTextBox;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label oilQtyLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label oPriceLabel;
        private System.Windows.Forms.Label fBrandLabel;
        private System.Windows.Forms.Label fPriceLabel;
        private System.Windows.Forms.Button addCarBtn;
        private System.Windows.Forms.Button updateCarBtn;
        private System.Windows.Forms.Button addOilLogBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label dateSerivcedLabel;
        private System.Windows.Forms.Label nextServiceLabel;
        private System.Windows.Forms.TextBox nextSMileageTxtbox;
        private System.Windows.Forms.Label nextServiceMileageLabel;
        private System.Windows.Forms.Label folderPathLabel;
        private System.Windows.Forms.TextBox sMileageTxtbox;
        private System.Windows.Forms.Label servicemileagelabel;
        private System.Windows.Forms.TextBox laborHourTextBox;
        private System.Windows.Forms.Label laborHourlbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn make;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
    }
}

