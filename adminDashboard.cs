﻿using System;
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
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
            sidePanel.Height = btnList.Height;
            sidePanel.Top = btnList.Top;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnSignOut.Height;
            sidePanel.Top = btnSignOut.Top;
            Form1 startup = new Form1();
            startup.Show();
            this.Hide();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnList.Height;
            sidePanel.Top = btnList.Top;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnSearch.Height;
            sidePanel.Top = btnSearch.Top;
            adminSearchTab adminSearchTab = new adminSearchTab();
            adminSearchTab.Show();
            this.Hide();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnStatistics.Height;
            sidePanel.Top = btnStatistics.Top;
            adminStatisticsTab adminStatisticsTab = new adminStatisticsTab();
            adminStatisticsTab.Show();
            this.Hide();
        }
    }
}
