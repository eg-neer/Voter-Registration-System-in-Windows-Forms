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
using System.Net;
using System.Net.Mail;
using System.Transactions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Diagnostics.Metrics;

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
            AdminStatisticsTab adminStatisticsTab = new AdminStatisticsTab();
            adminStatisticsTab.Show();
            this.Hide();
        }

        private void adminDashboard_Load(object sender, EventArgs e)
        {
            LoadApplicantsData();
            labelAdmin.Text = "Hello " + loginForm.LoggedInUser + "!";
        }

        string myConn = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\\CIT\\II - BSCPE\\2nd Sem\\4 CPE262\\Output\\Programs\\Voter Registration System\\Databases\\VoterRegistrationSystem.accdb";
        private void LoadApplicantsData()
        {
            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Applicants.Status, Applicants.LastName, Applicants.FirstName, Applicants.MiddleName, Applicants.Sex, Applicants.DateOfBirth, Applicants.Province, Applicants.MuniCity, Applicants.Barangay, Applicants.ApplicationDate, Applicants.EmailAddress, Applicants.GovIssuedID\r\nFROM Applicants\r\nWHERE (((Applicants.Status)=\"Pending\"));";
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dgvApplicants.DataSource = dt;

                    for (int i = 0; i < dgvApplicants.Columns.Count - 1; i++)
                    {
                        dgvApplicants.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                    dgvApplicants.Columns[dgvApplicants.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    for (int i = 0; i < dgvApplicants.Columns.Count; i++)
                    {
                        int colw = dgvApplicants.Columns[i].Width;
                        dgvApplicants.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dgvApplicants.Columns[i].Width = colw;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading applicants data: " + ex.Message);
                }
            }
        }

        private void dgvApplicants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvApplicants.Rows[e.RowIndex];

                txbLname.Text = row.Cells["LastName"].Value.ToString();
                txbFname.Text = row.Cells["FirstName"].Value.ToString();
                txbMname.Text = row.Cells["MiddleName"].Value.ToString();
                txbStatus.Text = row.Cells["Status"].Value.ToString();
                tbxProvince.Text = row.Cells["Province"].Value.ToString();
                txbMunicity.Text = row.Cells["MuniCity"].Value.ToString();
                txbBrgy.Text = row.Cells["Barangay"].Value.ToString();
                txbDOB.Text = Convert.ToDateTime(row.Cells["DateOfBirth"].Value).ToString("yyyy-MM-dd");
                txbAppDate.Text = Convert.ToDateTime(row.Cells["ApplicationDate"].Value).ToString("yyyy-MM-dd");

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

        private void sendApprovalMail(string emailAddress, string voterID)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("info.votermanagement@gmail.com");
                mail.To.Add(emailAddress);
                mail.Subject = "Voter Registration Approved";
                mail.Body = $"Your application has been approved.\n\n" +
                            $"Username: {emailAddress}\n" +
                            $"Password: {voterID}\n\n" +
                            "Please log in to the system and change your password upon first login."; ;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("info.votermanagement@gmail.com", "pwudbosuoizqjyby");
                smtp.EnableSsl = true;

                smtp.Send(mail);
                MessageBox.Show("Email successfully sent to the applicant.");
            }
            catch (SmtpException smtpEx)
            {
                MessageBox.Show("SMTP error: " + smtpEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email: " + ex.Message);
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvApplicants.CurrentRow == null)
            {
                MessageBox.Show("Please select an applicant to approve.");
                return;
            }

            DataGridViewRow selectedRow = dgvApplicants.CurrentRow;

            try
            {
                //string Province = selectedRow.Cells["Province"].Value.ToString();
                //string CityMunicipality = selectedRow.Cells["MuniCity"].Value.ToString();
                //string Barangay = selectedRow.Cells["Barangay"].Value.ToString();
                //Voter idGenerator = new Voter();
                //string generatedVoterID = idGenerator.GenerateVoterID(Province, CityMunicipality, Barangay);

                Voter voter = new Voter()
                {
                    //voterID = generatedVoterID,
                    Status = "Active",
                    LastName = selectedRow.Cells["LastName"].Value.ToString(),
                    FirstName = selectedRow.Cells["FirstName"].Value.ToString(),
                    MiddleName = selectedRow.Cells["MiddleName"].Value.ToString(),
                    Sex = selectedRow.Cells["Sex"].Value.ToString(),
                    DateOfBirth = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value),
                    Province = selectedRow.Cells["Province"].Value.ToString(),
                    CityMunicipality = selectedRow.Cells["MuniCity"].Value.ToString(),
                    Barangay = selectedRow.Cells["Barangay"].Value.ToString(),
                    dateRegistered = DateTime.Now,
                    Email = selectedRow.Cells["EmailAddress"].Value.ToString(),
                    //password = generatedVoterID
                    lastVoted = DateTime.Now,
                };

                voter.voterID = voter.GenerateVoterID(voter.Province, voter.CityMunicipality, voter.Barangay);

                string photoPath = selectedRow.Cells["GovIssuedID"].Value?.ToString();

                using (OleDbConnection conn = new OleDbConnection(myConn))
                {
                    conn.Open();
                    string query = @"INSERT INTO Voters
                        (VoterID, Status, LastName, FirstName, MiddleName, Sex, DateOfBirth, Province, MuniCity, Barangay, DateRegistered, EmailAddress, [Password],
                        ProvinceCode, CityCode, BrgyCode, ControlCode, GovIssuedID, LastVoted) 
                        VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", voter.voterID);
                        cmd.Parameters.AddWithValue("?", voter.Status);
                        cmd.Parameters.AddWithValue("?", voter.LastName);
                        cmd.Parameters.AddWithValue("?", voter.FirstName);
                        cmd.Parameters.AddWithValue("?", voter.MiddleName);
                        cmd.Parameters.AddWithValue("?", voter.Sex);
                        cmd.Parameters.AddWithValue("?", voter.DateOfBirth.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?", voter.Province);
                        cmd.Parameters.AddWithValue("?", voter.CityMunicipality);
                        cmd.Parameters.AddWithValue("?", voter.Barangay);
                        cmd.Parameters.AddWithValue("?", voter.dateRegistered.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?", voter.Email);
                        cmd.Parameters.AddWithValue("?", voter.voterID);
                        cmd.Parameters.AddWithValue("?", voter.ProvinceCode);
                        cmd.Parameters.AddWithValue("?", voter.CityCode);
                        cmd.Parameters.AddWithValue("?", voter.BrgyCode);
                        cmd.Parameters.AddWithValue("?", voter.ControlCode);
                        cmd.Parameters.AddWithValue("?", photoPath);
                        cmd.Parameters.AddWithValue("?", voter.lastVoted.ToString("yyyy-MM-dd"));

                        cmd.ExecuteNonQuery();
                    }

                    string updateStatusQuery = "UPDATE Applicants SET Status = 'Approved' WHERE EmailAddress = ?";

                    using (OleDbCommand updateCmd = new OleDbCommand(updateStatusQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("?", voter.Email);
                        int updated = updateCmd.ExecuteNonQuery();

                        if (updated == 0)
                        {
                            MessageBox.Show("Warning: Voter was created but applicant status wasn't updated");
                        }
                    }
                }

                sendApprovalMail(voter.Email, voter.voterID);
                LoadApplicantsData();

                MessageBox.Show("Applicant has been approved successfully.");
                LoadApplicantsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error approving applicant: " + ex.Message);
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (dgvApplicants.CurrentRow == null)
            {
                MessageBox.Show("Please select an applicant to approve.");
                return;
            }

            DataGridViewRow selectedRow = dgvApplicants.CurrentRow;

            string Email = selectedRow.Cells["EmailAddress"].Value.ToString();
            string updateStatusQuery = "UPDATE Applicants SET Status = 'Rejected' WHERE EmailAddress = ?";

            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                conn.Open();
                using (OleDbCommand updateCmd = new OleDbCommand(updateStatusQuery, conn))
                {
                    updateCmd.Parameters.AddWithValue("?", Email);
                    int updated = updateCmd.ExecuteNonQuery();

                    if (updated == 0)
                    {
                        MessageBox.Show("Warning: Voter was created but applicant status wasn't updated");
                    }
                }
            }
            sendRejectionMail(Email);
            LoadApplicantsData();
        }
        private void sendRejectionMail(string emailAddress)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("info.votermanagement@gmail.com");
                mail.To.Add(emailAddress);
                mail.Subject = "Voter Application Rejected";
                mail.Body = $"Your application has been rejected.\n\n" +
                            "You do not meet the requirements to be a registered voter or your uploaded government-issued ID is not valid."; ;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("info.votermanagement@gmail.com", "pwudbosuoizqjyby");
                smtp.EnableSsl = true;

                smtp.Send(mail);
                MessageBox.Show("Email successfully sent to the applicant.");
            }
            catch (SmtpException smtpEx)
            {
                MessageBox.Show("SMTP error: " + smtpEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email: " + ex.Message);
            }
        }
    }
}
