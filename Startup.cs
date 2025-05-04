using System.Data.OleDb;
using System.Data;

namespace Voter_Registration_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
        }

        private void pBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnSchedule.Height;
            sidePanel.Top = btnSchedule.Top;
            schedTab schedTab = new schedTab();
            schedTab.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnLogin.Height;
            sidePanel.Top = btnLogin.Top;
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnRegister.Height;
            sidePanel.Top = btnRegister.Top;
            registerForm registerForm = new registerForm();
            registerForm.Show();
            this.Hide();
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

        private void Startup_Load(object sender, EventArgs e)
        {
            LoadSenatorData();
            LoadPartylistData();
        }
    }
}
