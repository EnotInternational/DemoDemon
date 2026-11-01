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
        public ProductEditForm(int productId)
        {
            InitializeComponent();
            this.productId = productId;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Product product = model.Product.Find(productId);
            productBindingSource.DataSource = product;
            model.Subcategory.Load();
            model.Manufacturer.Load();
            model.User.Load();
            userComboBOx.DataSource = model.User.Local.ToBindingList();
            subcategoryBindingSource.DataSource = model.Subcategory.Local.ToBindingList();
            manufacturerBindingSource.DataSource = model.Manufacturer.Local.ToBindingList();
            pictureBox1.ImageLocation = Path.Combine(ImageService.GetImageFolderPath(), product.image);
            openFileDialog1.Filter = "Изображения (*.png; *.jpg; *.jpeg; *.bmp) | *.png; *.jpg; *.jpeg; *.bmp";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) != DialogResult.Cancel) return;

            if (!openFileDialog1.CheckFileExists) return;

            File.Copy(openFileDialog1.FileName, Path.Combine(ImageService.GetImageFolderPath(), openFileDialog1.SafeFileName));
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            model?.Dispose();
            model = null;
        }

        private void manufacturerIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
