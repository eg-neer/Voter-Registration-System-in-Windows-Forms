using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voter_Registration_System
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text == "user")
            {
                userDashboard userDashboard = new userDashboard();
                userDashboard.Show();
                this.Hide();
            }
            if (txbUsername.Text == "admin")
            {
                adminDashboard adminDashboard = new adminDashboard();
                adminDashboard.Show();
                this.Hide();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            registerForm registerForm = new registerForm();
            registerForm.Show();
            this.Hide();
        }

        private void pBoxBack_Click(object sender, EventArgs e)
        {
            Form1 startup = new Form1();
            startup.Show();
            this.Hide();
        }
    }
}
