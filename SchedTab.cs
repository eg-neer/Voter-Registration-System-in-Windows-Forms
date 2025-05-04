using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
            cboxFilter.SelectedIndex = 0;
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
        private void LoadSchedule(string filter)
        {
            string myConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\CIT\\II - BSCPE\\2nd Sem\\4 CPE262\\Output\\Programs\\Voter Registration System\\Databases\\VoterRegistrationSystem.accdb";
            string query = @"SELECT [Calendar of Activities].Title, [Calendar of Activities].Description, [Calendar of Activities].DateStart, [Calendar of Activities].DateEnd
                                FROM [Calendar of Activities]
                                WHERE ";

            if (filter == "Upcoming")
            {
                query += "[Calendar of Activities].DateStart > Date();";
            }
            else if (filter == "Ongoing")
            {
                query += "Date() >= [DateStart] AND Date() <= [DateEnd];";
            }
            else if (filter == "Archived")
            {
                query += "[DateEnd] < Date();";
            }
            using (OleDbConnection conn = new OleDbConnection(myConn))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    flowLayoutPanelSchedule.Controls.Clear(); // Clear the panel before loading new data

                    while (reader.Read())
                    {
                        // Create a new panel for each activity
                        Panel activityPanel = new Panel
                        {
                            Size = new Size(300, 150),
                            BackColor = Color.LightGoldenrodYellow,
                            Margin = new Padding(10),
                            Padding = new Padding(10),
                            BorderStyle = BorderStyle.FixedSingle
                        };

                        // Add Title
                        Label lblTitle = new Label
                        {
                            Text = reader["Title"].ToString(),
                            Font = new Font("Segoe UI", 12, FontStyle.Bold),
                            Dock = DockStyle.Top,
                            Height = 20
                        };

                        DateTime start = Convert.ToDateTime(reader["DateStart"]);
                        DateTime end = Convert.ToDateTime(reader["DateEnd"]);

                        string dateText = start == end
                            ? start.ToString("MMM dd, yyyy")
                            : $"{start:MMM dd, yyyy} - {end:MMM dd, yyyy}";
                        // Add Date Range (Start to End)
                        Label lblDateRange = new Label
                        {
                            Text = dateText,
                            Dock = DockStyle.Top
                        };

                        // Add Description
                        Label lblDesc = new Label
                        {
                            Text = reader["Description"].ToString(),
                            Dock = DockStyle.Fill,
                            AutoEllipsis = true
                        };

                        // Add components to activity panel
                        activityPanel.Controls.Add(lblDesc);
                        activityPanel.Controls.Add(lblDateRange);
                        activityPanel.Controls.Add(lblTitle);

                        // Add the activity panel to the FlowLayoutPanel
                        flowLayoutPanelSchedule.Controls.Add(activityPanel);
                    }
                }
            }
        }

        private void cboxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = cboxFilter.SelectedItem.ToString();
            LoadSchedule(selectedFilter);
        }
    }
}
