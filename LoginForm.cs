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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Voter_Registration_System
{
    public partial class loginForm : Form
    {
        string myConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\CIT\\II - BSCPE\\2nd Sem\\4 CPE262\\Output\\Programs\\Voter Registration System\\Databases\\VoterRegistrationSystem.accdb";
        public loginForm()
        {
            InitializeComponent();
        }
        public static string LoggedInUser { get; private set; }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text.Trim();
            string password = txbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password");
                return;
            }


            try
            {
                using (OleDbConnection conn = new OleDbConnection(myConn))
                {
                    conn.Open();

                    // First try voter login
                    string query = @"SELECT COUNT(*) FROM Voters WHERE EmailAddress = ? AND [Password] = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", username);
                        cmd.Parameters.AddWithValue("?", password);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Successful login - get user details
                            query = @"SELECT FirstName, VoterID FROM Voters WHERE EmailAddress = ?";
                            using (OleDbCommand detailsCmd = new OleDbCommand(query, conn))
                            {
                                detailsCmd.Parameters.AddWithValue("?", username);
                                using (OleDbDataReader reader = detailsCmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        LoggedInUser = reader["FirstName"].ToString(); // Or full name
                                        string voterId = reader["VoterID"].ToString();

                                        userAccountTab userForm = new userAccountTab(LoggedInUser, voterId); // pass to greeting
                                        userForm.Show();
                                        this.Hide();
                                        return;
                                    }
                                }
                            }
                        }
                    }

                    // If we get here, try admin login
                    query = @"SELECT * FROM Officers WHERE TRIM(Username) = ? AND loginCode = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", username);
                        cmd.Parameters.AddWithValue("?", password);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                LoggedInUser = reader["Username"].ToString();

                                new adminDashboard().Show();
                                this.Hide();
                                return;
                            }
                        }
                    }

                    //MessageBox.Show("Invalid credentials - user not found or password incorrect");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}");
                Form1 startup = new Form1();
                startup.Show();
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

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
