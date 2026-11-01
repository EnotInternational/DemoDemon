using DemoDemon.Controls;
using DemoDemon.Model;
using DemoDemon.Model.Entities;
using DemoDemon.Model.Servicies;
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
                    ProductViewControl control = new ProductViewControl(product.ProductID);
                    flowLayoutPanel1.Controls.Add(control);
                }
            }
        }

        private void Control_OnAddToOrder(int productId)
        {
            
        }

        private void currentOrderButton_Click(object sender, EventArgs e)
        {
            OrderEditForm form = new OrderEditForm();
            form.order = OrderService.Instance.PendingOrder;
            form.PreviousForm = this;
            form.Show();
            Hide();
        }
    }
}
