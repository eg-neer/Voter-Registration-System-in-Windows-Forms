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
    public partial class schedTab : Form
    {
        public schedTab()
        {
            InitializeComponent();
            sidePanel.Height = btnSchedule.Height;
            sidePanel.Top = btnSchedule.Top;
        }

        private void pBoxBack_Click(object sender, EventArgs e)
        {
            Form1 startup = new Form1();
            startup.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
            Form1 startup = new Form1();
            startup.Show();
            this.Hide();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnSchedule.Height;
            sidePanel.Top = btnSchedule.Top;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnLogin.Height;
            sidePanel.Top = btnLogin.Top;
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnRegister.Height;
            sidePanel.Top = btnRegister.Top;
            registerForm registerForm = new registerForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
