using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDemon.Model.Servicies
{
    public class OrderService
    {
        public static OrderService Instance{ get; private set; }
        public Order PendingOrder { get; private set; } = new Order();
        
        public OrderService()
        {
            Instance = this;
        }
    }
}
