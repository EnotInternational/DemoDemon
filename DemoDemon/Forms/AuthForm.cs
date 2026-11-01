using DemoDemon.Model;
using DemoDemon.Model.Entities;
using DemoDemon.Model.Servicies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDemon.Forms
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;

            if(String.IsNullOrEmpty(loginTextBox.Text))
            {
                errorProvider1.SetError(this, "Логин не может быть пустой");
                return;
            }

            using (MainModel model = new MainModel())
            {
                User user = model.User.First(u => u.Login == login);
                if(user == null)
                {
                    MessageBox.Show($"Неверный логин {login}");
                    errorProvider1.SetError(this, "Неверный логин");
                    return;
                }

                AuthService.Instance.SetUserData(user.UserID, (UserRole)user.RoleID);
                RouteUser((UserRole)user.RoleID);
            }
        }

        private void RouteUser(UserRole role)
        {
            BaseForm form = AuthService.Instance.UserData.BaseForm;
            form.PreviousForm = this;
            form.Show();
            Hide();
        }
    }
}
