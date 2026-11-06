using DemoDemon.Model;
using DemoDemon.Model.Servicies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoDemon.Forms
{
    public partial class PendingOrderEditForm : DemoDemon.Forms.BaseForm
    {
        protected MainModel model = new MainModel();
        public Order order;
        public PendingOrderEditForm(Order order)
        {
            InitializeComponent();
            this.order=order;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            model.User.Load();

            orderBindingSource.DataSource = order;
            orderItemBindingSource.DataSource = order.OrderItem.ToList();

            sumLabel.Text = ((ICollection<OrderItem>)orderItemBindingSource.DataSource).Sum(item => item.UniyPrice * item.Quantity).ToString();
        }
        public Order GetOrder()
        {
            return order;
        }

        private void addOrderItemButton_Click(object sender, EventArgs e)
        {
            order.OrderDate = DateTime.Now;
            model.Order.Add(order);

            order.UserID = AuthService.Instance.UserData.UserId;
            foreach (var item in order.OrderItem)
            {
                item.OrderID = order.OrderID;
            }
            model.SaveChanges();

            MessageBox.Show("Заказ сделан");
        }
    }
}
