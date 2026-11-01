using DemoDemon.Model;
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

namespace DemoDemon.Forms
{
    public partial class ProductEditForm : BaseForm
    {
        private int productId;
        MainModel model = new MainModel();
        Product product;
        public ProductEditForm(int productId)
        {
            InitializeComponent();
            this.productId = productId;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            product = model.Product.Find(productId);
            productBindingSource.DataSource = product;
            model.Subcategory.Load();
            model.Manufacturer.Load();
            model.User.Load();
            subcategoryBindingSource.DataSource = model.Subcategory.Local.ToBindingList();
            manufacturerBindingSource.DataSource = model.Manufacturer.Local.ToBindingList();
            pictureBox1.ImageLocation = Path.Combine(ImageService.GetImageFolderPath(), product.image);
            openFileDialog1.Filter = "Изображения (*.png; *.jpg; *.jpeg; *.bmp) | *.png; *.jpg; *.jpeg; *.bmp";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Выберите изображение";

            if (openFileDialog1.ShowDialog(this) != DialogResult.OK) return;

            if (!openFileDialog1.CheckFileExists) return;

            string newImagePath = Path.Combine(ImageService.GetImageFolderPath(), openFileDialog1.SafeFileName);
            File.Copy(openFileDialog1.FileName, newImagePath, true);

            if (!String.IsNullOrEmpty(product.image))
            {
                bool otherImageLinks = model.Product.Count((p => p.image == product.image)) > 1;
                string oldImagePath = Path.Combine(ImageService.GetImageFolderPath(), product.image);

                if (!otherImageLinks && File.Exists(oldImagePath))
                {
                    File.Delete(oldImagePath);
                }
            }

            product.image = openFileDialog1.SafeFileName;
            pictureBox1.ImageLocation = Path.Combine(ImageService.GetImageFolderPath(), product.image);
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            model?.Dispose();
            model = null;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            model.SaveChanges();
        }
    }
}
