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
    public partial class userDashboard : Form
    {
        private string voterId;
        private string firstName;
        public userDashboard()
        {
            InitializeComponent();
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
            this.voterId = voterId;
            this.firstName = firstName;
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
            userAccountTab userAccountTab = new userAccountTab(firstName, voterId);
            userAccountTab.Show();
            this.Hide();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
        }
        string myConn = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\\CIT\\II - BSCPE\\2nd Sem\\4 CPE262\\Output\\Programs\\Voter Registration System\\Databases\\VoterRegistrationSystem.accdb";
        private void LoadSenatorData()
        {
            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM SenatorialCandidates";
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dgvSenators.DataSource = dt;
                    for (int i = 0; i < dgvSenators.Columns.Count - 1; i++)
                    {
                        dgvSenators.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                    dgvSenators.Columns[dgvSenators.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    for (int i = 0; i < dgvSenators.Columns.Count; i++)
                    {
                        int colw = dgvSenators.Columns[i].Width;
                        dgvSenators.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dgvSenators.Columns[i].Width = colw;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading applicants data: " + ex.Message);
                }
            }
        }
        private void LoadPartylistData()
        {
            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Partylist";
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    dgvPartylist.DataSource = dt;
                    for (int i = 0; i < dgvPartylist.Columns.Count - 1; i++)
                    {
                        dgvPartylist.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                    dgvPartylist.Columns[dgvPartylist.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    for (int i = 0; i < dgvPartylist.Columns.Count; i++)
                    {
                        int colw = dgvPartylist.Columns[i].Width;
                        dgvPartylist.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dgvPartylist.Columns[i].Width = colw;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading applicants data: " + ex.Message);
                }
            }
        }

        private void userDashboard_Load(object sender, EventArgs e)
        {
            LoadSenatorData();
            LoadPartylistData();
            labelUSer.Text = "Hello\n" + loginForm.LoggedInUser + "!";
        }
    }
}
