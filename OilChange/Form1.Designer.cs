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
            this.make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridOilLog = new System.Windows.Forms.DataGridView();
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
            this.removeCarBtn = new System.Windows.Forms.Button();
            this.updateCarBtn = new System.Windows.Forms.Button();
            this.addOilLogBtn = new System.Windows.Forms.Button();
            this.removeLogBtn = new System.Windows.Forms.Button();
            this.updateLogBtn = new System.Windows.Forms.Button();
            this.downloadLogBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateSerivcedLabel = new System.Windows.Forms.Label();
            this.nextServiceLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nextServiceMileageLabel = new System.Windows.Forms.Label();
            this.servicedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicedMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextServiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextServiceMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oilPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOilLog)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCarSelect
            // 
            this.gridCarSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCarSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.make,
            this.model,
            this.year});
            this.gridCarSelect.Location = new System.Drawing.Point(503, 45);
            this.gridCarSelect.Name = "gridCarSelect";
            this.gridCarSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCarSelect.Size = new System.Drawing.Size(991, 231);
            this.gridCarSelect.TabIndex = 0;
            this.gridCarSelect.SelectionChanged += new System.EventHandler(this.gridCarSelect_SelectionChanged);
            // 
            // make
            // 
            this.make.DataPropertyName = "make";
            this.make.HeaderText = "Make";
            this.make.Name = "make";
            this.make.ReadOnly = true;
            this.make.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.make.Width = 130;
            // 
            // model
            // 
            this.model.DataPropertyName = "model";
            this.model.HeaderText = "Model";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.model.Width = 160;
            // 
            // year
            // 
            this.year.DataPropertyName = "year";
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            this.year.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gridOilLog
            // 
            this.gridOilLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOilLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servicedDate,
            this.servicedMileage,
            this.nextServiceDate,
            this.nextServiceMileage,
            this.weight,
            this.brand,
            this.quantity,
            this.oilPrice,
            this.fBrand,
            this.fPrice});
            this.gridOilLog.Location = new System.Drawing.Point(503, 312);
            this.gridOilLog.Name = "gridOilLog";
            this.gridOilLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOilLog.Size = new System.Drawing.Size(991, 411);
            this.gridOilLog.TabIndex = 1;
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(28, 64);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(115, 20);
            this.makeTextBox.TabIndex = 2;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(156, 64);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(160, 20);
            this.modelTextBox.TabIndex = 3;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(331, 64);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 4;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(28, 330);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(87, 20);
            this.weightTextBox.TabIndex = 5;
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(130, 330);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(153, 20);
            this.brandTextBox.TabIndex = 6;
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(301, 330);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(70, 20);
            this.qtyTextBox.TabIndex = 7;
            // 
            // fBrandTextBox
            // 
            this.fBrandTextBox.Location = new System.Drawing.Point(28, 381);
            this.fBrandTextBox.Name = "fBrandTextBox";
            this.fBrandTextBox.Size = new System.Drawing.Size(118, 20);
            this.fBrandTextBox.TabIndex = 8;
            // 
            // oPriceTextBox
            // 
            this.oPriceTextBox.Location = new System.Drawing.Point(389, 330);
            this.oPriceTextBox.Name = "oPriceTextBox";
            this.oPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.oPriceTextBox.TabIndex = 9;
            // 
            // fPriceTextBox
            // 
            this.fPriceTextBox.Location = new System.Drawing.Point(159, 381);
            this.fPriceTextBox.Name = "fPriceTextBox";
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
            this.weightLabel.Location = new System.Drawing.Point(28, 314);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(56, 13);
            this.weightLabel.TabIndex = 14;
            this.weightLabel.Text = "Oil Weight";
            // 
            // oilQtyLabel
            // 
            this.oilQtyLabel.AutoSize = true;
            this.oilQtyLabel.Location = new System.Drawing.Point(299, 314);
            this.oilQtyLabel.Name = "oilQtyLabel";
            this.oilQtyLabel.Size = new System.Drawing.Size(61, 13);
            this.oilQtyLabel.TabIndex = 15;
            this.oilQtyLabel.Text = "Oil Quantity";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(127, 314);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(50, 13);
            this.brandLabel.TabIndex = 16;
            this.brandLabel.Text = "Oil Brand";
            // 
            // oPriceLabel
            // 
            this.oPriceLabel.AutoSize = true;
            this.oPriceLabel.Location = new System.Drawing.Point(388, 314);
            this.oPriceLabel.Name = "oPriceLabel";
            this.oPriceLabel.Size = new System.Drawing.Size(46, 13);
            this.oPriceLabel.TabIndex = 17;
            this.oPriceLabel.Text = "Oil Price";
            // 
            // fBrandLabel
            // 
            this.fBrandLabel.AutoSize = true;
            this.fBrandLabel.Location = new System.Drawing.Point(28, 365);
            this.fBrandLabel.Name = "fBrandLabel";
            this.fBrandLabel.Size = new System.Drawing.Size(60, 13);
            this.fBrandLabel.TabIndex = 18;
            this.fBrandLabel.Text = "Filter Brand";
            // 
            // fPriceLabel
            // 
            this.fPriceLabel.AutoSize = true;
            this.fPriceLabel.Location = new System.Drawing.Point(156, 365);
            this.fPriceLabel.Name = "fPriceLabel";
            this.fPriceLabel.Size = new System.Drawing.Size(56, 13);
            this.fPriceLabel.TabIndex = 19;
            this.fPriceLabel.Text = "Filter Price";
            // 
            // addCarBtn
            // 
            this.addCarBtn.Location = new System.Drawing.Point(90, 133);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(75, 23);
            this.addCarBtn.TabIndex = 20;
            this.addCarBtn.Text = "Add";
            this.addCarBtn.UseVisualStyleBackColor = true;
            // 
            // removeCarBtn
            // 
            this.removeCarBtn.Location = new System.Drawing.Point(282, 133);
            this.removeCarBtn.Name = "removeCarBtn";
            this.removeCarBtn.Size = new System.Drawing.Size(75, 23);
            this.removeCarBtn.TabIndex = 21;
            this.removeCarBtn.Text = "Remove";
            this.removeCarBtn.UseVisualStyleBackColor = true;
            // 
            // updateCarBtn
            // 
            this.updateCarBtn.Location = new System.Drawing.Point(184, 133);
            this.updateCarBtn.Name = "updateCarBtn";
            this.updateCarBtn.Size = new System.Drawing.Size(75, 23);
            this.updateCarBtn.TabIndex = 22;
            this.updateCarBtn.Text = "Update";
            this.updateCarBtn.UseVisualStyleBackColor = true;
            // 
            // addOilLogBtn
            // 
            this.addOilLogBtn.Location = new System.Drawing.Point(90, 492);
            this.addOilLogBtn.Name = "addOilLogBtn";
            this.addOilLogBtn.Size = new System.Drawing.Size(75, 23);
            this.addOilLogBtn.TabIndex = 23;
            this.addOilLogBtn.Text = "Add";
            this.addOilLogBtn.UseVisualStyleBackColor = true;
            // 
            // removeLogBtn
            // 
            this.removeLogBtn.Location = new System.Drawing.Point(282, 492);
            this.removeLogBtn.Name = "removeLogBtn";
            this.removeLogBtn.Size = new System.Drawing.Size(75, 23);
            this.removeLogBtn.TabIndex = 24;
            this.removeLogBtn.Text = "Remove";
            this.removeLogBtn.UseVisualStyleBackColor = true;
            // 
            // updateLogBtn
            // 
            this.updateLogBtn.Location = new System.Drawing.Point(184, 492);
            this.updateLogBtn.Name = "updateLogBtn";
            this.updateLogBtn.Size = new System.Drawing.Size(75, 23);
            this.updateLogBtn.TabIndex = 25;
            this.updateLogBtn.Text = "Update";
            this.updateLogBtn.UseVisualStyleBackColor = true;
            // 
            // downloadLogBtn
            // 
            this.downloadLogBtn.Location = new System.Drawing.Point(503, 729);
            this.downloadLogBtn.Name = "downloadLogBtn";
            this.downloadLogBtn.Size = new System.Drawing.Size(99, 23);
            this.downloadLogBtn.TabIndex = 26;
            this.downloadLogBtn.Text = "Download Log";
            this.downloadLogBtn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd MMM yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 434);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd MMM yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(165, 434);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(118, 20);
            this.dateTimePicker2.TabIndex = 28;
            // 
            // dateSerivcedLabel
            // 
            this.dateSerivcedLabel.AutoSize = true;
            this.dateSerivcedLabel.Location = new System.Drawing.Point(25, 418);
            this.dateSerivcedLabel.Name = "dateSerivcedLabel";
            this.dateSerivcedLabel.Size = new System.Drawing.Size(75, 13);
            this.dateSerivcedLabel.TabIndex = 29;
            this.dateSerivcedLabel.Text = "Serviced Date";
            // 
            // nextServiceLabel
            // 
            this.nextServiceLabel.AutoSize = true;
            this.nextServiceLabel.Location = new System.Drawing.Point(162, 418);
            this.nextServiceLabel.Name = "nextServiceLabel";
            this.nextServiceLabel.Size = new System.Drawing.Size(94, 13);
            this.nextServiceLabel.TabIndex = 30;
            this.nextServiceLabel.Text = "Next Service Date";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 434);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 31;
            // 
            // nextServiceMileageLabel
            // 
            this.nextServiceMileageLabel.AutoSize = true;
            this.nextServiceMileageLabel.Location = new System.Drawing.Point(308, 418);
            this.nextServiceMileageLabel.Name = "nextServiceMileageLabel";
            this.nextServiceMileageLabel.Size = new System.Drawing.Size(108, 13);
            this.nextServiceMileageLabel.TabIndex = 32;
            this.nextServiceMileageLabel.Text = "Next Service Mileage";
            // 
            // servicedDate
            // 
            this.servicedDate.DataPropertyName = "servicedDate";
            this.servicedDate.HeaderText = "Serviced Date";
            this.servicedDate.Name = "servicedDate";
            this.servicedDate.ReadOnly = true;
            this.servicedDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.servicedDate.Width = 90;
            // 
            // servicedMileage
            // 
            this.servicedMileage.DataPropertyName = "servicedMileage";
            this.servicedMileage.HeaderText = "Serviced Mileage";
            this.servicedMileage.Name = "servicedMileage";
            this.servicedMileage.ReadOnly = true;
            this.servicedMileage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.servicedMileage.Width = 90;
            // 
            // nextServiceDate
            // 
            this.nextServiceDate.DataPropertyName = "nextServiceDate";
            this.nextServiceDate.HeaderText = "Next Service";
            this.nextServiceDate.Name = "nextServiceDate";
            this.nextServiceDate.ReadOnly = true;
            this.nextServiceDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nextServiceDate.Width = 90;
            // 
            // nextServiceMileage
            // 
            this.nextServiceMileage.DataPropertyName = "nextServiceMileage";
            this.nextServiceMileage.HeaderText = "Next Service Mileage";
            this.nextServiceMileage.Name = "nextServiceMileage";
            this.nextServiceMileage.ReadOnly = true;
            this.nextServiceMileage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nextServiceMileage.Width = 90;
            // 
            // weight
            // 
            this.weight.DataPropertyName = "weight";
            this.weight.HeaderText = "Weight";
            this.weight.Name = "weight";
            this.weight.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.weight.Width = 90;
            // 
            // brand
            // 
            this.brand.DataPropertyName = "brand";
            this.brand.HeaderText = "Brand";
            this.brand.Name = "brand";
            this.brand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.brand.Width = 140;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Qty";
            this.quantity.Name = "quantity";
            this.quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.quantity.Width = 60;
            // 
            // oilPrice
            // 
            this.oilPrice.DataPropertyName = "oilPrice";
            this.oilPrice.HeaderText = "Oil Price";
            this.oilPrice.Name = "oilPrice";
            this.oilPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.oilPrice.Width = 80;
            // 
            // fBrand
            // 
            this.fBrand.DataPropertyName = "fBrand";
            this.fBrand.HeaderText = "Filter Brand";
            this.fBrand.Name = "fBrand";
            this.fBrand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fBrand.Width = 140;
            // 
            // fPrice
            // 
            this.fPrice.DataPropertyName = "fPrice";
            this.fPrice.HeaderText = "Filter Price";
            this.fPrice.Name = "fPrice";
            this.fPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fPrice.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 764);
            this.Controls.Add(this.nextServiceMileageLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nextServiceLabel);
            this.Controls.Add(this.dateSerivcedLabel);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.downloadLogBtn);
            this.Controls.Add(this.updateLogBtn);
            this.Controls.Add(this.removeLogBtn);
            this.Controls.Add(this.addOilLogBtn);
            this.Controls.Add(this.updateCarBtn);
            this.Controls.Add(this.removeCarBtn);
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
            this.Controls.Add(this.gridOilLog);
            this.Controls.Add(this.gridCarSelect);
            this.Name = "Form1";
            this.Text = "Oil Change Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCarSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOilLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCarSelect;
        private System.Windows.Forms.DataGridView gridOilLog;
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
        private System.Windows.Forms.Button removeCarBtn;
        private System.Windows.Forms.Button updateCarBtn;
        private System.Windows.Forms.Button addOilLogBtn;
        private System.Windows.Forms.Button removeLogBtn;
        private System.Windows.Forms.Button updateLogBtn;
        private System.Windows.Forms.Button downloadLogBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn make;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicedMileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextServiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextServiceMileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn oilPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn fBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn fPrice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label dateSerivcedLabel;
        private System.Windows.Forms.Label nextServiceLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nextServiceMileageLabel;
    }
}

