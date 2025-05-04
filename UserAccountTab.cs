using System;
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
    public partial class userAccountTab : Form
    {
        string myConn = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\\CIT\\II - BSCPE\\2nd Sem\\4 CPE262\\Output\\Programs\\Voter Registration System\\Databases\\VoterRegistrationSystem.accdb";
        //string userEmail = loginForm.LoggedInUser;
        private string firstName;
        private string voterId;

        public userAccountTab(string firstName, string voterId)
        {
            InitializeComponent();
            sidePanel.Height = btnAccount.Height;
            sidePanel.Top = btnAccount.Top;
            this.voterId = voterId;
            this.firstName = firstName;

            //loadUserProfile(voterId);
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            //loginForm.LoggedInUser = null;
            sidePanel.Height = btnSignOut.Height;
            sidePanel.Top = btnSignOut.Top;
            Form1 startup = new Form1();
            startup.Show();
            this.Close();
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
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
            userDashboard userDashboard = new userDashboard();
            userDashboard.Show();
            this.Hide();
        }
        private void loadUserProfile(string voterId)
        {
            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                conn.Open();
                string query = "SELECT * FROM Voters WHERE VoterID = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", voterId);

                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string photoPath = reader["GovIssuedID"]?.ToString();
                    if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
                    {
                        pboxID.ImageLocation = photoPath;
                    }
                    else
                    {
                        pboxID.Image = null; // Clear the picture box if photo not found
                    }

                    DataTable transposed = new DataTable();
                    transposed.Columns.Add("Field");
                    transposed.Columns.Add("Value");

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        transposed.Rows.Add(reader.GetName(i), reader[i]?.ToString());
                    }

                    dgvUser.DataSource = transposed;

                    for (int i = 0; i < dgvUser.Columns.Count - 1; i++)
                    {
                        dgvUser.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                    dgvUser.Columns[dgvUser.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    for (int i = 0; i < dgvUser.Columns.Count; i++)
                    {
                        int colw = dgvUser.Columns[i].Width;
                        dgvUser.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dgvUser.Columns[i].Width = colw;
                    }
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
        }

        private void userAccountTab_Load(object sender, EventArgs e)
        {
            loadUserProfile(voterId);
            labelUser.Text = "Hello\n" + loginForm.LoggedInUser + "!";
        }
    }
}
