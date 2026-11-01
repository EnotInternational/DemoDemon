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

            if(AuthService.Instance != null)
            {
                fioLabel.Text = AuthService.Instance.UserFio;
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
            PreviousForm?.Show();
        }
    }
}
