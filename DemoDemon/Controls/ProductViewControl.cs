using DemoDemon.Forms;
using DemoDemon.Model;
using DemoDemon.Model.Entities;
using DemoDemon.Model.Servicies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public event Action<int> OnDelete;
        public ProductViewControl()
        {
            InitializeComponent();
        }
        public ProductViewControl(int productId)
        {
            InitializeComponent();
            this.productId = productId;
            model = new MainModel();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (model == null) return;
            productBindingSource.DataSource = model.Product.Find(productId);
            LoadImage();
        }

        private void LoadImage()
        {
            Product product = model.Product.Find(productId);
            if (String.IsNullOrEmpty(product.image)) return;
            string ImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", product.image);
            pictureBox1.ImageLocation = ImagePath;

            deleteButton.Visible = AuthService.Instance.UserData.ProductConstraint.HasFlag(UserConstraint.Delete);
            editButton.Visible = AuthService.Instance.UserData.ProductConstraint.HasFlag(UserConstraint.Edit);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            OnDelete?.Invoke(productId);
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            ProductEditForm productEditForm = new ProductEditForm(productId);
            productEditForm.PreviousForm = ParentForm;
            productEditForm.Show();

        }
        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
            model?.Dispose();
        }
        
        private void editButton_Click(object sender, EventArgs e)
        {
            ProductEditForm form = new ProductEditForm(productId);
            form.PreviousForm = this.ParentForm;
            form.Show();
        }
    }
}
