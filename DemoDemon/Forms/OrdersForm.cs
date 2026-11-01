using DemoDemon.Model;
using DemoDemon.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoDemon.Forms
{
    public partial class OrdersForm : DemoDemon.Forms.BaseForm
    {
        MainModel model = new MainModel();
        public OrdersForm()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            model.Order.Load();
            orderBindingSource.DataSource = model.Order.Local.ToBindingList();
        }
        private void openButton_Click(object sender, EventArgs e)
        {
            Order order = (Order)orderBindingSource.Current;
            OrderEditForm orderEditForm = new OrderEditForm(order.OrderID);
            orderEditForm.PreviousForm = this;
            orderEditForm.Show();
            this.Hide();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            model.Dispose();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            model.SaveChanges();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            Order order = (Order)orderBindingSource.Current;
            model.Order.Remove(order);
        }

    }
}
