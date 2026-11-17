using DemoDemon.Forms;
using DemoDemon.Model;
using DemoDemon.Model.Entities;
using DemoDemon.Model.Servicies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDemon.Controls
{
    public partial class ProductViewControl : UserControl
    {
        private int productId;
        private MainModel model;
        public event Action<int> OnProductSelected;
        public int ProductId {
            get => productId;
            set
            {
                productId = value;
                productBindingSource.DataSource = model.Product.Find(ProductId);
                LoadImage();
            }
        }

        public event Action<int> OnDelete;
        public ProductViewControl()
        {
            InitializeComponent();
        }
        public ProductViewControl(int productId)
        {
            InitializeComponent();
            model = new MainModel();
            this.productId = productId;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (model == null) return;
            Product product = model.Product.Find(ProductId);
            productBindingSource.DataSource = product;
            amountLabel.Text = product.QuantityAvailable > 5 ? "Много" : "Мало";
            if (product.QuantityAvailable <= 3)
            {
                productNameLabel1.ForeColor = ColorTranslator.FromHtml("#FF8080");
                manufacturerNameLabel1.ForeColor = ColorTranslator.FromHtml("#FF8080");
            }
            priceLabel1.Text = (product.Price).ToString();

            if (CanApplyDiscount())
            {
                double price = Convert.ToDouble(product.Price);
                priceLabel1.ForeColor = ColorTranslator.FromHtml("#FF8080");
                oldPriceLabel.Text = price.ToString();
                priceLabel1.Text = (price - price * 0.25).ToString();
            }
            LoadImage();
        }

        private bool CanApplyDiscount()
        {
            DateTime dateTime = DateTime.Now.AddMonths(-1);

            IQueryable<Product> query = from p in model.Product
            join orderItem in model.OrderItem on p.ProductID equals orderItem.ProductID
            join order in model.Order on orderItem.OrderID equals order.OrderID
            where order.OrderDate >= dateTime
            where p.ProductID == productId
            select p;
            return query.Count() == 0;
        }
        private void LoadImage()
        {
            Product product = model.Product.Find(ProductId);
            string ImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", product.image);
            if(!File.Exists(ImagePath))
            {
                ImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "picture.png");
            }
            pictureBox1.ImageLocation = ImagePath;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            OnDelete?.Invoke(ProductId);
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            OnProductSelected?.Invoke(productId);
        }
        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
            model?.Dispose();
        } 
        
        private void editButton_Click(object sender, EventArgs e)
        {
            ProductEditForm form = new ProductEditForm(ProductId);
            form.PreviousForm = this.ParentForm;
            form.Show();
        }
    }
}
