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
    public partial class userDashboard : Form
    {
        public userDashboard()
        {
            InitializeComponent();
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnSignOut.Height;
            sidePanel.Top = btnSignOut.Top;
            Form1 startup = new Form1();
            startup.Show();
            this.Hide();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnSchedule.Height;
            sidePanel.Top = btnSchedule.Top;
            userSchedTab userSchedTab = new userSchedTab();
            userSchedTab.Show();
            this.Hide();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnAccount.Height;
            sidePanel.Top = btnAccount.Top;
            userAccountTab userAccountTab = new userAccountTab();
            userAccountTab.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
        }
    }
}
