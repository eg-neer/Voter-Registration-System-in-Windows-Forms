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
    public partial class adminSearchTab : Form
    {
        public adminSearchTab()
        {
            InitializeComponent();
            sidePanel.Height = btnSearch.Height;
            sidePanel.Top = btnSearch.Top;
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
            adminDashboard adminDashboard = new adminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnSearch.Height;
            sidePanel.Top = btnSearch.Top;
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnStatistics.Height;
            sidePanel.Top = btnStatistics.Top;
            AdminStatisticsTab adminStatisticsTab = new AdminStatisticsTab();
            adminStatisticsTab.Show();
            this.Hide();
        }

        private void adminSearchTab_Load(object sender, EventArgs e)
        {
            LoadVoterData();
            labelAdmin.Text = "Hello " + loginForm.LoggedInUser + "!";
        }
        string myConn = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\\CIT\\II - BSCPE\\2nd Sem\\4 CPE262\\Output\\Programs\\Voter Registration System\\Databases\\VoterRegistrationSystem.accdb";
        private void LoadVoterData()
        {
            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                try
                {
                    conn.Open();

                    string inactiveQuery = @"UPDATE Voters 
                                   SET Status = 'Inactive' 
                                   WHERE Year(Now()) - Year(LastVoted) > 6";

                    // NEW: Update active voters (last voted ≤ 6 years ago)
                    string activeQuery = @"UPDATE Voters 
                                 SET Status = 'Active' 
                                 WHERE Year(Now()) - Year(LastVoted) <= 6";

                    using (OleDbCommand cmd = new OleDbCommand(inactiveQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // Execute the active status update
                    using (OleDbCommand cmd = new OleDbCommand(activeQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    string query = "SELECT * FROM Voters";
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dgvVoters.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading applicants data: " + ex.Message);
                }
            }
        }

        private void dgvVoters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvVoters.Rows[e.RowIndex];

                txbVoterID.Text = row.Cells["VoterID"].Value.ToString();
                txbFname.Text = row.Cells["FirstName"].Value.ToString();
                txbLname.Text = row.Cells["LastName"].Value.ToString();
                txbMname.Text = row.Cells["MiddleName"].Value.ToString();
                txbStatus.Text = row.Cells["Status"].Value.ToString();
                txbDOB.Text = Convert.ToDateTime(row.Cells["DateOfBirth"].Value).ToString("yyyy-MM-dd");
                txbRegisDate.Text = Convert.ToDateTime(row.Cells["DateRegistered"].Value).ToString("yyyy-MM-dd");
                txbLastVoted.Text = Convert.ToDateTime(row.Cells["LastVoted"].Value).ToString("yyyy-MM-dd");
                txbProvince.Text = row.Cells["Province"].Value.ToString();
                txbMunicity.Text = row.Cells["MuniCity"].Value.ToString();
                txbBrgy.Text = row.Cells["Barangay"].Value.ToString();

                string photoPath = row.Cells["GovIssuedID"].Value?.ToString();
                if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
                {
                    pboxID.ImageLocation = photoPath;
                }
                else
                {
                    pboxID.Image = null; // Clear the picture box if photo not found
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbVoterID.Text))
            {
                MessageBox.Show("Please select a voter to update");
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE Voters SET 
                          FirstName = ?,
                          LastName = ?,
                          MiddleName = ?,
                          Status = ?,
                          DateOfBirth = ?,
                          LastVoted = ?,
                          Province = ?,
                          MuniCity = ?,
                          Barangay = ?
                          WHERE VoterID = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", txbFname.Text);
                        cmd.Parameters.AddWithValue("?", txbLname.Text);
                        cmd.Parameters.AddWithValue("?", txbMname.Text);
                        cmd.Parameters.AddWithValue("?", txbStatus.Text);
                        cmd.Parameters.AddWithValue("?", DateTime.Parse(txbDOB.Text));
                        cmd.Parameters.AddWithValue("?", DateTime.Parse(txbLastVoted.Text));
                        cmd.Parameters.AddWithValue("?", txbProvince.Text);
                        cmd.Parameters.AddWithValue("?", txbMunicity.Text);
                        cmd.Parameters.AddWithValue("?", txbBrgy.Text);
                        cmd.Parameters.AddWithValue("?", txbVoterID.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Voter record updated successfully");
                            LoadVoterData(); // Refresh the grid
                        }
                        else
                        {
                            MessageBox.Show("No records were updated");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating voter: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbVoterID.Text))
            {
                MessageBox.Show("Please select a voter to delete");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this voter record?",
                "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (OleDbConnection conn = new OleDbConnection(myConn))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Voters WHERE VoterID = ?";

                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("?", txbVoterID.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Voter record deleted successfully");
                                ClearForm();
                                LoadVoterData(); // Refresh the grid
                            }
                            else
                            {
                                MessageBox.Show("No records were deleted");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting voter: " + ex.Message);
                    }
                }
            }
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                try
                {
                    conn.Open();

                    // Build the base query
                    StringBuilder query = new StringBuilder("SELECT * FROM Voters WHERE 1=1");
                    List<OleDbParameter> parameters = new List<OleDbParameter>();

                    // Add filters for each non-empty textbox
                    if (!string.IsNullOrEmpty(txbVoterID.Text))
                    {
                        query.Append(" AND VoterID LIKE ?");
                        parameters.Add(new OleDbParameter("?", "%" + txbVoterID.Text + "%"));
                    }

                    if (!string.IsNullOrEmpty(txbFname.Text))
                    {
                        query.Append(" AND FirstName LIKE ?");
                        parameters.Add(new OleDbParameter("?", "%" + txbFname.Text + "%"));
                    }

                    if (!string.IsNullOrEmpty(txbLname.Text))
                    {
                        query.Append(" AND LastName LIKE ?");
                        parameters.Add(new OleDbParameter("?", "%" + txbLname.Text + "%"));
                    }

                    if (!string.IsNullOrEmpty(txbMname.Text))
                    {
                        query.Append(" AND MiddleName LIKE ?");
                        parameters.Add(new OleDbParameter("?", "%" + txbMname.Text + "%"));
                    }

                    if (!string.IsNullOrEmpty(txbStatus.Text))
                    {
                        query.Append(" AND Status = ?");
                        parameters.Add(new OleDbParameter("?", txbStatus.Text));
                    }

                    if (!string.IsNullOrEmpty(txbDOB.Text) && DateTime.TryParse(txbDOB.Text, out DateTime dob))
                    {
                        query.Append(" AND DateOfBirth = ?");
                        parameters.Add(new OleDbParameter("?", dob.ToString("yyyy-MM-dd")));
                    }

                    if (!string.IsNullOrEmpty(txbProvince.Text))
                    {
                        query.Append(" AND Province LIKE ?");
                        parameters.Add(new OleDbParameter("?", "%" + txbProvince.Text + "%"));
                    }

                    if (!string.IsNullOrEmpty(txbMunicity.Text))
                    {
                        query.Append(" AND MuniCity LIKE ?");
                        parameters.Add(new OleDbParameter("?", "%" + txbMunicity.Text + "%"));
                    }

                    if (!string.IsNullOrEmpty(txbBrgy.Text))
                    {
                        query.Append(" AND Barangay LIKE ?");
                        parameters.Add(new OleDbParameter("?", "%" + txbBrgy.Text + "%"));
                    }

                    // For date fields that might need range search
                    if (!string.IsNullOrEmpty(txbRegisDate.Text) && DateTime.TryParse(txbRegisDate.Text, out DateTime regDate))
                    {
                        query.Append(" AND DateRegistered = ?");
                        parameters.Add(new OleDbParameter("?", regDate.ToString("yyyy-MM-dd")));
                    }

                    if (!string.IsNullOrEmpty(txbLastVoted.Text) && DateTime.TryParse(txbLastVoted.Text, out DateTime lastVoted))
                    {
                        query.Append(" AND LastVoted = ?");
                        parameters.Add(new OleDbParameter("?", lastVoted.ToString("yyyy-MM-dd")));
                    }

                    // Execute the query
                    using (OleDbCommand cmd = new OleDbCommand(query.ToString(), conn))
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());

                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No matching records found");
                        }

                        dgvVoters.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching voters: " + ex.Message);
                }
            }
        }
        private void ClearForm()
        {
            txbVoterID.Text = "";
            txbFname.Text = "";
            txbLname.Text = "";
            txbMname.Text = "";
            txbStatus.Text = "";
            txbDOB.Text = "";
            txbRegisDate.Text = "";
            txbLastVoted.Text = "";
            txbProvince.Text = "";
            txbMunicity.Text = "";
            txbBrgy.Text = "";
            pboxID.Image = null;
        }
    }
}
