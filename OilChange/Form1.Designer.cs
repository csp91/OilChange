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
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oilPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gridCarSelect.Size = new System.Drawing.Size(775, 231);
            this.gridCarSelect.TabIndex = 0;
            // 
            // make
            // 
            this.make.DataPropertyName = "make";
            this.make.HeaderText = "Make";
            this.make.Name = "make";
            this.make.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.make.Width = 130;
            // 
            // model
            // 
            this.model.DataPropertyName = "model";
            this.model.HeaderText = "Model";
            this.model.Name = "model";
            this.model.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.model.Width = 160;
            // 
            // year
            // 
            this.year.DataPropertyName = "year";
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            this.year.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gridOilLog
            // 
            this.gridOilLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOilLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.weight,
            this.brand,
            this.quantity,
            this.oilPrice,
            this.fBrand,
            this.fPrice});
            this.gridOilLog.Location = new System.Drawing.Point(503, 306);
            this.gridOilLog.Name = "gridOilLog";
            this.gridOilLog.Size = new System.Drawing.Size(775, 411);
            this.gridOilLog.TabIndex = 1;
            // 
            // weight
            // 
            this.weight.DataPropertyName = "weight";
            this.weight.HeaderText = "Weight";
            this.weight.Name = "weight";
            this.weight.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // brand
            // 
            this.brand.DataPropertyName = "brand";
            this.brand.HeaderText = "Brand";
            this.brand.Name = "brand";
            this.brand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.brand.Width = 170;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Qty";
            this.quantity.Name = "quantity";
            this.quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.quantity.Width = 90;
            // 
            // oilPrice
            // 
            this.oilPrice.DataPropertyName = "oilPrice";
            this.oilPrice.HeaderText = "Oil Price";
            this.oilPrice.Name = "oilPrice";
            this.oilPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fBrand
            // 
            this.fBrand.DataPropertyName = "fBrand";
            this.fBrand.HeaderText = "Filter Brand";
            this.fBrand.Name = "fBrand";
            this.fBrand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fBrand.Width = 170;
            // 
            // fPrice
            // 
            this.fPrice.DataPropertyName = "fPrice";
            this.fPrice.HeaderText = "Filter Price";
            this.fPrice.Name = "fPrice";
            this.fPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.addOilLogBtn.Location = new System.Drawing.Point(90, 474);
            this.addOilLogBtn.Name = "addOilLogBtn";
            this.addOilLogBtn.Size = new System.Drawing.Size(75, 23);
            this.addOilLogBtn.TabIndex = 23;
            this.addOilLogBtn.Text = "Add";
            this.addOilLogBtn.UseVisualStyleBackColor = true;
            // 
            // removeLogBtn
            // 
            this.removeLogBtn.Location = new System.Drawing.Point(282, 474);
            this.removeLogBtn.Name = "removeLogBtn";
            this.removeLogBtn.Size = new System.Drawing.Size(75, 23);
            this.removeLogBtn.TabIndex = 24;
            this.removeLogBtn.Text = "Remove";
            this.removeLogBtn.UseVisualStyleBackColor = true;
            // 
            // updateLogBtn
            // 
            this.updateLogBtn.Location = new System.Drawing.Point(184, 474);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 764);
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
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridCarSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOilLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCarSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn make;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridView gridOilLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn oilPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn fBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn fPrice;
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
    }
}

