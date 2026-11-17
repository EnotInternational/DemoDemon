namespace DemoDemon.Forms
{
    partial class ProductEditForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label compoundLabel;
            System.Windows.Forms.Label desctiptionLabel;
            System.Windows.Forms.Label manufacturerIDLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label subcategoryIDLabel;
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compoundTextBox = new System.Windows.Forms.TextBox();
            this.desctiptionTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerIDComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.subcategoryIDComboBox = new System.Windows.Forms.ComboBox();
            this.subcategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sizeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            compoundLabel = new System.Windows.Forms.Label();
            desctiptionLabel = new System.Windows.Forms.Label();
            manufacturerIDLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            subcategoryIDLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(800, 30);
            // 
            // fioLabel
            // 
            this.fioLabel.Location = new System.Drawing.Point(186, 3);
            // 
            // compoundLabel
            // 
            compoundLabel.AutoSize = true;
            compoundLabel.Location = new System.Drawing.Point(317, 158);
            compoundLabel.Name = "compoundLabel";
            compoundLabel.Size = new System.Drawing.Size(54, 16);
            compoundLabel.TabIndex = 2;
            compoundLabel.Text = "Состав";
            // 
            // desctiptionLabel
            // 
            desctiptionLabel.AutoSize = true;
            desctiptionLabel.Location = new System.Drawing.Point(317, 92);
            desctiptionLabel.Name = "desctiptionLabel";
            desctiptionLabel.Size = new System.Drawing.Size(72, 16);
            desctiptionLabel.TabIndex = 4;
            desctiptionLabel.Text = "Описание";
            // 
            // manufacturerIDLabel
            // 
            manufacturerIDLabel.AutoSize = true;
            manufacturerIDLabel.Location = new System.Drawing.Point(317, 251);
            manufacturerIDLabel.Name = "manufacturerIDLabel";
            manufacturerIDLabel.Size = new System.Drawing.Size(111, 16);
            manufacturerIDLabel.TabIndex = 8;
            manufacturerIDLabel.Text = "Производитель";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(317, 318);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(40, 16);
            priceLabel.TabIndex = 10;
            priceLabel.Text = "Цена";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(317, 63);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(73, 16);
            productNameLabel.TabIndex = 14;
            productNameLabel.Text = "Название";
            // 
            // subcategoryIDLabel
            // 
            subcategoryIDLabel.AutoSize = true;
            subcategoryIDLabel.Location = new System.Drawing.Point(317, 281);
            subcategoryIDLabel.Name = "subcategoryIDLabel";
            subcategoryIDLabel.Size = new System.Drawing.Size(75, 16);
            subcategoryIDLabel.TabIndex = 16;
            subcategoryIDLabel.Text = "Категория";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DemoDemon.Model.Product);
            // 
            // compoundTextBox
            // 
            this.compoundTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Compound", true));
            this.compoundTextBox.Enabled = false;
            this.compoundTextBox.Location = new System.Drawing.Point(425, 158);
            this.compoundTextBox.Multiline = true;
            this.compoundTextBox.Name = "compoundTextBox";
            this.compoundTextBox.Size = new System.Drawing.Size(353, 60);
            this.compoundTextBox.TabIndex = 3;
            // 
            // desctiptionTextBox
            // 
            this.desctiptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Desctiption", true));
            this.desctiptionTextBox.Enabled = false;
            this.desctiptionTextBox.Location = new System.Drawing.Point(425, 92);
            this.desctiptionTextBox.Multiline = true;
            this.desctiptionTextBox.Name = "desctiptionTextBox";
            this.desctiptionTextBox.Size = new System.Drawing.Size(353, 55);
            this.desctiptionTextBox.TabIndex = 5;
            // 
            // manufacturerIDComboBox
            // 
            this.manufacturerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ManufacturerID", true));
            this.manufacturerIDComboBox.DataSource = this.manufacturerBindingSource;
            this.manufacturerIDComboBox.DisplayMember = "ManufacturerName";
            this.manufacturerIDComboBox.Enabled = false;
            this.manufacturerIDComboBox.FormattingEnabled = true;
            this.manufacturerIDComboBox.Location = new System.Drawing.Point(426, 243);
            this.manufacturerIDComboBox.Name = "manufacturerIDComboBox";
            this.manufacturerIDComboBox.Size = new System.Drawing.Size(242, 24);
            this.manufacturerIDComboBox.TabIndex = 9;
            this.manufacturerIDComboBox.ValueMember = "ManufacturerID";
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataSource = typeof(DemoDemon.Model.Manufacturer);
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Price", true));
            this.priceTextBox.Enabled = false;
            this.priceTextBox.Location = new System.Drawing.Point(426, 315);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(121, 22);
            this.priceTextBox.TabIndex = 11;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductName", true));
            this.productNameTextBox.Enabled = false;
            this.productNameTextBox.Location = new System.Drawing.Point(426, 60);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.productNameTextBox.TabIndex = 15;
            // 
            // subcategoryIDComboBox
            // 
            this.subcategoryIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "SubcategoryID", true));
            this.subcategoryIDComboBox.DataSource = this.subcategoryBindingSource;
            this.subcategoryIDComboBox.DisplayMember = "FullCategoryName";
            this.subcategoryIDComboBox.Enabled = false;
            this.subcategoryIDComboBox.FormattingEnabled = true;
            this.subcategoryIDComboBox.Location = new System.Drawing.Point(426, 273);
            this.subcategoryIDComboBox.Name = "subcategoryIDComboBox";
            this.subcategoryIDComboBox.Size = new System.Drawing.Size(242, 24);
            this.subcategoryIDComboBox.TabIndex = 17;
            this.subcategoryIDComboBox.ValueMember = "SubcategoryID";
            // 
            // subcategoryBindingSource
            // 
            this.subcategoryBindingSource.DataSource = typeof(DemoDemon.Model.Subcategory);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(DemoDemon.Model.Category);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Выбрать изображение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DemoDemon.Model.User);
            // 
            // sizeBindingSource
            // 
            this.sizeBindingSource.DataSource = typeof(DemoDemon.Model.Size);
            // 
            // sizeDataGridView
            // 
            this.sizeDataGridView.AllowUserToAddRows = false;
            this.sizeDataGridView.AllowUserToDeleteRows = false;
            this.sizeDataGridView.AllowUserToResizeColumns = false;
            this.sizeDataGridView.AllowUserToResizeRows = false;
            this.sizeDataGridView.AutoGenerateColumns = false;
            this.sizeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sizeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.sizeDataGridView.DataSource = this.sizeBindingSource;
            this.sizeDataGridView.Location = new System.Drawing.Point(6, 21);
            this.sizeDataGridView.MultiSelect = false;
            this.sizeDataGridView.Name = "sizeDataGridView";
            this.sizeDataGridView.ReadOnly = true;
            this.sizeDataGridView.RowHeadersVisible = false;
            this.sizeDataGridView.RowHeadersWidth = 51;
            this.sizeDataGridView.RowTemplate.Height = 24;
            this.sizeDataGridView.Size = new System.Drawing.Size(176, 144);
            this.sizeDataGridView.TabIndex = 20;
            this.sizeDataGridView.SelectionChanged += new System.EventHandler(this.sizeDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SizeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SizeID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SizeValue";
            this.dataGridViewTextBoxColumn2.HeaderText = "Размер";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OrderItem";
            this.dataGridViewTextBoxColumn3.HeaderText = "OrderItem";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StockItem";
            this.dataGridViewTextBoxColumn4.HeaderText = "StockItem";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderButton);
            this.groupBox1.Controls.Add(this.quantityNumericUpDown);
            this.groupBox1.Controls.Add(this.sizeDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(21, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 178);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Заказ";
            // 
            // orderButton
            // 
            this.orderButton.Enabled = false;
            this.orderButton.Location = new System.Drawing.Point(188, 142);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(120, 23);
            this.orderButton.TabIndex = 22;
            this.orderButton.Text = "Заказать";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(188, 21);
            this.quantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.quantityNumericUpDown.TabIndex = 21;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ProductEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(compoundLabel);
            this.Controls.Add(this.compoundTextBox);
            this.Controls.Add(desctiptionLabel);
            this.Controls.Add(this.desctiptionTextBox);
            this.Controls.Add(manufacturerIDLabel);
            this.Controls.Add(this.manufacturerIDComboBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(subcategoryIDLabel);
            this.Controls.Add(this.subcategoryIDComboBox);
            this.Name = "ProductEditForm";
            this.Text = "ProductEditForm";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.subcategoryIDComboBox, 0);
            this.Controls.SetChildIndex(subcategoryIDLabel, 0);
            this.Controls.SetChildIndex(this.productNameTextBox, 0);
            this.Controls.SetChildIndex(productNameLabel, 0);
            this.Controls.SetChildIndex(this.priceTextBox, 0);
            this.Controls.SetChildIndex(priceLabel, 0);
            this.Controls.SetChildIndex(this.manufacturerIDComboBox, 0);
            this.Controls.SetChildIndex(manufacturerIDLabel, 0);
            this.Controls.SetChildIndex(this.desctiptionTextBox, 0);
            this.Controls.SetChildIndex(desctiptionLabel, 0);
            this.Controls.SetChildIndex(this.compoundTextBox, 0);
            this.Controls.SetChildIndex(compoundLabel, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subcategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox compoundTextBox;
        private System.Windows.Forms.TextBox desctiptionTextBox;
        private System.Windows.Forms.ComboBox manufacturerIDComboBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.ComboBox subcategoryIDComboBox;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource subcategoryBindingSource;
        private System.Windows.Forms.BindingSource sizeBindingSource;
        private System.Windows.Forms.DataGridView sizeDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}