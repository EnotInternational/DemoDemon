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

namespace DemoDemon.Model.Entities
{
    public partial class OrderEditForm : DemoDemon.Forms.BaseForm
    {
        protected readonly int orderId;
        protected MainModel model = new MainModel();
        public Order order;
        public OrderEditForm()
        {
            InitializeComponent();
        }
        public OrderEditForm(int orderId = -1)
        {
            InitializeComponent();
            this.orderId=orderId;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            model.User.Load();
            userBindingSource.DataSource = model.User.Local;

            if(orderId != -1)
            {
                order = model.Order.Find(orderId);
                orderBindingSource.DataSource = order;
                model.OrderItem.Where(orderItem => orderItem.OrderID == orderId).Load();
                orderItemBindingSource.DataSource = model.OrderItem.Local.ToBindingList();
            }

            sumLabel.Text = ((ICollection<OrderItem>)orderItemBindingSource.DataSource).Sum(item => item.UniyPrice * item.Quantity).ToString();

            if (!AuthService.Instance.UserData.OrderConstraint.HasFlag(UserConstraint.Edit))
            {
                orderDateDateTimePicker.Enabled = false;
                userFioComboBox.Enabled = false;
                addOrderItemButton.Enabled = false;
            }
        }
        public Order GetOrder()
        {
            return order;
        }
    }
}
