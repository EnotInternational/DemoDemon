using DemoDemon.Controls;
using DemoDemon.Model;
using DemoDemon.Model.Entities;
using DemoDemon.Model.Servicies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DemoDemon.Forms
{
    public partial class ProductsViewForm : DemoDemon.Forms.BaseForm
    {
        private const string AllCategoriesLabel = "Все категории";
        private MainModel model = new MainModel();
        Subcategory subcategoryNullElement = new Subcategory { CategoryID = -1, CategoryName = AllCategoriesLabel, SubcategoryID = -1 };
        BindingList<Subcategory> allSubcategories;
        BindingList<Category> allCategories;
        public ProductsViewForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            model.Category.Load();

            allSubcategories = model.Subcategory.Local.ToBindingList();
            allSubcategories.Prepend(subcategoryNullElement);

            Category categoryNullElement = new Category { CategoryID = -1, CategoryName = AllCategoriesLabel };
            allCategories = model.Category.Local.ToBindingList();
            allCategories.Add(categoryNullElement);

            categoryComboBox.DataSource = allCategories;
            categoryComboBox.DisplayMember = "CategoryName";
            categoryComboBox.SelectedItem = categoryNullElement;

            categoryComboBox.SelectedIndexChanged += new EventHandler(this.categoryComboBox_SelectedIndexChanged);

            sortComboBox.Items.AddRange(new string[] {SortType.NoSort, SortType.PriceAsc, SortType.PriceDesc});
            sortComboBox.SelectedItem = SortType.NoSort;

            UpdateList();

            currentOrderButton.Visible = AuthService.Instance.UserData != null;
            sortComboBox.Enabled = AuthService.Instance.UserData != null;
            categoryComboBox.Enabled = AuthService.Instance.UserData != null;
            searchTextBox.Enabled = AuthService.Instance.UserData != null;
            authoriseButton.Visible = AuthService.Instance.UserData == null;
        }

        private void UpdateList()
        {
            flowLayoutPanel1.Controls.Clear();
            IEnumerable<Product> filtered = model.Product.Where(FullProductFilter);
            switch(sortComboBox.SelectedItem)
            {
                case SortType.NoSort:
                    break;
                case SortType.PriceAsc:
                    filtered = filtered.OrderBy(product => product.Price);
                    break;
                case SortType.PriceDesc:
                    filtered = filtered.OrderByDescending(product => product.Price);
                    break;
            }
            foreach (Product product in filtered)
            {
                ProductViewControl control = new ProductViewControl(product.ProductID);
                control.OnProductSelected += OnProductSelected;
                flowLayoutPanel1.Controls.Add(control);
            }
        }

        private bool FullProductFilter(Product product)
        {
            Category category = (Category)categoryComboBox.SelectedValue;
            return
                Regex.IsMatch(product.ProductName, searchTextBox.Text) &&
                (category.CategoryID == -1 ||
                product.Subcategory.CategoryID == category.CategoryID);
            //(categoryComboBox.SelectedText == AllCategoriesLabel || product.Subcategory.Category.CategoryID == ((Category)categoryComboBox.SelectedValue).CategoryID);
            //Regex.IsMatch(product.ProductName, searchTextBox.Text);

        }

        private void Control_OnAddToOrder(int productId)
        {
            
        }
        public void OnProductSelected(int productId)
        {
            ProductEditForm productEditForm = new ProductEditForm(productId);
            productEditForm.PreviousForm = this;
            productEditForm.Show();
        }

        private void currentOrderButton_Click(object sender, EventArgs e)
        {
            PendingOrderEditForm form = new PendingOrderEditForm(OrderService.Instance.PendingOrder);
            form.PreviousForm = this;
            form.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void subcategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateList();

        }

        private void Authorise_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            this.Hide();
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        static class SortType
        {
            public const string NoSort = "Нет";
            public const string PriceAsc = "По возрастанию цены";
            public const string PriceDesc = "По убыванию цены";
        }
    }
}
