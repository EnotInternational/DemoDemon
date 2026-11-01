using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoDemon.Forms
{
    public partial class ManagerForm : DemoDemon.Forms.BaseForm
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            ProductsViewForm productViewForm = new ProductsViewForm();
            productViewForm.PreviousForm = this;
            productViewForm.Show();
            this.Hide();
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            OrdersForm orderForm = new OrdersForm();
            orderForm.PreviousForm = this;
            orderForm.Show();
            this.Hide();
        }
    }
}
