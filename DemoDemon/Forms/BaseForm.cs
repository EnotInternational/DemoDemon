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
    public partial class BaseForm : Form
    {
        public Form PreviousForm {  get; set; }
        public BaseForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (AuthService.Instance == null) return;

            if (AuthService.Instance.UserData != null)
            {
                fioLabel.Text = AuthService.Instance.UserData.UserFio;
            }
            else
            {
                fioLabel.Text = "Гость";
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            PreviousForm?.Show();
        }
    }
}
