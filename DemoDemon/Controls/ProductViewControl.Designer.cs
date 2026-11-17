namespace DemoDemon.Controls
{
    partial class ProductViewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductViewControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.manufacturerNameLabel1 = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productNameLabel1 = new System.Windows.Forms.Label();
            this.priceLabel1 = new System.Windows.Forms.Label();
            this.categoryNameLabel1 = new System.Windows.Forms.Label();
            this.categoryNameLabel2 = new System.Windows.Forms.Label();
            this.compoundLabel1 = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.oldPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(1013, 103);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(132, 23);
            this.orderButton.TabIndex = 6;
            this.orderButton.Text = "Выбрать";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // manufacturerNameLabel1
            // 
            this.manufacturerNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Manufacturer.ManufacturerName", true));
            this.manufacturerNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturerNameLabel1.Location = new System.Drawing.Point(230, 19);
            this.manufacturerNameLabel1.Name = "manufacturerNameLabel1";
            this.manufacturerNameLabel1.Size = new System.Drawing.Size(363, 23);
            this.manufacturerNameLabel1.TabIndex = 10;
            this.manufacturerNameLabel1.Text = "Производитель";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DemoDemon.Model.Product);
            // 
            // productNameLabel1
            // 
            this.productNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductName", true));
            this.productNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameLabel1.Location = new System.Drawing.Point(599, 19);
            this.productNameLabel1.Name = "productNameLabel1";
            this.productNameLabel1.Size = new System.Drawing.Size(546, 23);
            this.productNameLabel1.TabIndex = 11;
            this.productNameLabel1.Text = "Продукт";
            // 
            // priceLabel1
            // 
            this.priceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel1.Location = new System.Drawing.Point(858, 41);
            this.priceLabel1.Name = "priceLabel1";
            this.priceLabel1.Size = new System.Drawing.Size(287, 33);
            this.priceLabel1.TabIndex = 12;
            this.priceLabel1.Text = "Цена";
            // 
            // categoryNameLabel1
            // 
            this.categoryNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Subcategory.Category.CategoryName", true));
            this.categoryNameLabel1.Location = new System.Drawing.Point(230, 51);
            this.categoryNameLabel1.Name = "categoryNameLabel1";
            this.categoryNameLabel1.Size = new System.Drawing.Size(205, 23);
            this.categoryNameLabel1.TabIndex = 13;
            this.categoryNameLabel1.Text = "Категоиря";
            // 
            // categoryNameLabel2
            // 
            this.categoryNameLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Subcategory.CategoryName", true));
            this.categoryNameLabel2.Location = new System.Drawing.Point(439, 51);
            this.categoryNameLabel2.Name = "categoryNameLabel2";
            this.categoryNameLabel2.Size = new System.Drawing.Size(270, 23);
            this.categoryNameLabel2.TabIndex = 14;
            this.categoryNameLabel2.Text = "Подкатегория";
            // 
            // compoundLabel1
            // 
            this.compoundLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Compound", true));
            this.compoundLabel1.Location = new System.Drawing.Point(230, 106);
            this.compoundLabel1.Name = "compoundLabel1";
            this.compoundLabel1.Size = new System.Drawing.Size(363, 23);
            this.compoundLabel1.TabIndex = 15;
            this.compoundLabel1.Text = "Состав";
            // 
            // amountLabel
            // 
            this.amountLabel.Location = new System.Drawing.Point(230, 80);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(363, 23);
            this.amountLabel.TabIndex = 16;
            this.amountLabel.Text = "Количетво";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // oldPriceLabel
            // 
            this.oldPriceLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Price", true));
            this.oldPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPriceLabel.Location = new System.Drawing.Point(898, 81);
            this.oldPriceLabel.Name = "oldPriceLabel";
            this.oldPriceLabel.Size = new System.Drawing.Size(247, 22);
            this.oldPriceLabel.TabIndex = 17;
            // 
            // ProductViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(246)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.oldPriceLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.compoundLabel1);
            this.Controls.Add(this.categoryNameLabel2);
            this.Controls.Add(this.categoryNameLabel1);
            this.Controls.Add(this.priceLabel1);
            this.Controls.Add(this.productNameLabel1);
            this.Controls.Add(this.manufacturerNameLabel1);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProductViewControl";
            this.Size = new System.Drawing.Size(1157, 132);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label manufacturerNameLabel1;
        private System.Windows.Forms.Label productNameLabel1;
        private System.Windows.Forms.Label priceLabel1;
        private System.Windows.Forms.Label categoryNameLabel1;
        private System.Windows.Forms.Label categoryNameLabel2;
        private System.Windows.Forms.Label compoundLabel1;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label oldPriceLabel;
    }
}
