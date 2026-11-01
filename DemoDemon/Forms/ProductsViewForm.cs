using DemoDemon.Controls;
using DemoDemon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoDemon.Forms
{
    public partial class ProductsViewForm : DemoDemon.Forms.BaseForm
    {
        
        public ProductsViewForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            using (MainModel model =  new MainModel())
            {
                foreach(Product product in model.Product)
                {
                    flowLayoutPanel1.Controls.Add(new ProductViewControl(product.ProductID));
                }
            }
        }
    }
}
