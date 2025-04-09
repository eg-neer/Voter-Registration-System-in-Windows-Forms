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
        private System.Windows.Forms.Timer countdownTimer = new System.Windows.Forms.Timer();
        private DateTime endTime = new DateTime(2025, 5, 12, 6, 0, 0);
        public schedTab()
        {
            InitializeComponent();
            InitializeCountdown();
            sidePanel.Height = btnSchedule.Height;
            sidePanel.Top = btnSchedule.Top;
        }
        private void InitializeCountdown()
        {
            //countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Interval = 1000; // 1 second
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();
        }
        private void CountdownTimer_Tick(object? sender, EventArgs e)
        {
            TimeSpan remaining = endTime - DateTime.Now;

            if (remaining.TotalSeconds <= 0)
            {
                countdownTimer.Stop();
                labelCountdown.Text = "It's Election Day!";
            }
            else
            {
                labelCountdown.Text = $"{remaining.Days:D2} Days {remaining.Hours:D2} : {remaining.Minutes:D2} : {remaining.Seconds:D2}";
            }
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
