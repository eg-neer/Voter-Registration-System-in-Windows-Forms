using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Voter_Registration_System
{
    public partial class registerForm : Form
    {
        string myConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\CIT\\II - BSCPE\\2nd Sem\\4 CPE262\\Output\\Programs\\Voter Registration System\\Databases\\VoterRegistrationSystem.accdb";
        string uploadedFilePath; 

        public registerForm()
        {
            InitializeComponent();
        }
        private void registerForm_Load(object sender, EventArgs e)
        {
            LoadProvinces();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }
        private void LoadProvinces()
        {
            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT ProvinceCode, ProvinceName FROM Provinces ORDER BY ProvinceCode", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cboxProvince.DataSource = dt;
                cboxProvince.DisplayMember = "ProvinceName";
                cboxProvince.ValueMember = "ProvinceCode";
            }
        }
        private void cboxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxProvince.SelectedValue != null)
            {
                string selectedProvinceCode = cboxProvince.SelectedValue.ToString();
                LoadMunicipalities(selectedProvinceCode);
            }
        }
        private void LoadMunicipalities(string provinceCode)
        {
            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT CityCode, MuniCity FROM MuniCities WHERE ProvinceCode = ? ORDER BY CityCode", conn);
                adapter.SelectCommand.Parameters.AddWithValue("?", provinceCode);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cboxMuniCity.DataSource = dt;
                cboxMuniCity.DisplayMember = "MuniCity";
                cboxMuniCity.ValueMember = "CityCode";
            }
        }
        private void cboxMuniCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxMuniCity.SelectedValue != null)
            {
                string selectedCityCode = cboxMuniCity.SelectedValue.ToString();
                LoadBarangays(selectedCityCode);
            }
        }

        private void LoadBarangays(string cityCode)
        {
            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT BarangayCode, BarangayName FROM Barangays WHERE CityCode = ? ORDER BY BarangayName", conn);
                adapter.SelectCommand.Parameters.AddWithValue("?", cityCode);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cboxBarangay.DataSource = dt;
                cboxBarangay.DisplayMember = "BarangayName";
                cboxBarangay.ValueMember = "BarangayCode";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbFname.Text) || string.IsNullOrWhiteSpace(txbLname.Text) || string.IsNullOrWhiteSpace(txbMname.Text))
            {
                MessageBox.Show("Please enter your full name. If not applicable, type N/A.");
            }
            if (cboxSex.SelectedItem == null)
            {
                MessageBox.Show("Please provide your sex.");
            }
            if (string.IsNullOrWhiteSpace(txbEmail.Text))
            {
                MessageBox.Show("Please provide your E-mail Address.");
            }
            if (cboxProvince.SelectedItem == null || cboxMuniCity.SelectedItem == null || cboxBarangay.SelectedItem == null)
            {
                MessageBox.Show("Please select a Province, City/Municipality, and/or Barangay.");
                return;
            }
            if (!cboxConsent.Checked)
            {
                MessageBox.Show("Please check the oath, notice, and consent to continue.");
                return;
            }
            byte[] photoData = null;
            if (pictureBoxPhoto.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBoxPhoto.Image.Save(ms, pictureBoxPhoto.Image.RawFormat);
                    photoData = ms.ToArray();
                }
            }

            string selectedProvinceCode = cboxProvince.SelectedValue.ToString();
            string provinceName = GetProvinceNameFromCode("Provinces", "ProvinceCode", "ProvinceName", selectedProvinceCode);

            // Convert Municipality Code to Municipality Name
            string selectedMuniCityCode = cboxMuniCity.SelectedValue.ToString();
            string muniCityName = GetCityNameFromCode("MuniCities", "ProvinceCode", "CityCode", "MuniCity", selectedProvinceCode, selectedMuniCityCode);

            // Convert Barangay Code to Barangay Name
            string selectedBarangayCode = cboxBarangay.SelectedValue.ToString();
            string barangayName = GetBrgyNameFromCode("Barangays", "ProvinceCode", "CityCode", "BarangayCode", "BarangayName", selectedProvinceCode, selectedMuniCityCode, selectedBarangayCode);

            // Insert the data into the database (for pending registration).
            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                conn.Open();
                Applicants applicant = new Applicants
                {
                    Status = "Pending",
                    LastName = txbLname.Text.Trim(),
                    FirstName = txbFname.Text.Trim(),
                    MiddleName = txbMname.Text.Trim(),
                    Sex = cboxSex.Text,
                    DateOfBirth = dtpDOB.Value,
                    Province = provinceName,
                    CityMunicipality = muniCityName,
                    Barangay = barangayName,
                    ApplicationDate = DateTime.Now,
                    Email = txbEmail.Text.Trim(),
                    GovIssuedID = uploadedFilePath,
                };

                if (applicant.IsOfVotingAge() < 18)
                {
                    MessageBox.Show("You must be at least 18 years old to register.");
                    return;
                }
                if (applicant.IsDuplicate(applicant.Email, conn))
                {
                    MessageBox.Show("An applicant with this email already exists.");
                    return;
                }
                

                string query = @"INSERT INTO Applicants 
                        (Status, LastName, FirstName, MiddleName, Sex, DateOfBirth, Province, MuniCity, Barangay, ApplicationDate, EmailAddress, GovIssuedID) 
                        VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", applicant.Status);
                    cmd.Parameters.AddWithValue("?", applicant.LastName);
                    cmd.Parameters.AddWithValue("?", applicant.FirstName);
                    cmd.Parameters.AddWithValue("?", applicant.MiddleName);
                    cmd.Parameters.AddWithValue("?", applicant.Sex);
                    cmd.Parameters.AddWithValue("?", applicant.DateOfBirth.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("?", applicant.Province);
                    cmd.Parameters.AddWithValue("?", applicant.CityMunicipality);
                    cmd.Parameters.AddWithValue("?", applicant.Barangay);
                    cmd.Parameters.AddWithValue("?", applicant.ApplicationDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("?", applicant.Email);
                    cmd.Parameters.AddWithValue("?", applicant.GovIssuedID);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Your application will be reviewed. Please check your email on the next business day for results.");
            Form1 startup = new Form1();
            startup.Show();
            this.Hide();
        }

        private void pBoxBack_Click(object sender, EventArgs e)
        {
            Form1 startup = new Form1();
            startup.Show();
            this.Hide();
        }

        private void cboxConsent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\nI do solemnly swear that the above statements regarding my person are true and correct; " +
                            "that I possess all the qualifications and none of the disqualifications of a voter; and that I am:" +
                            "\n\n     not registered in any precinct;" +
                            "\n\nand that I have reviewed the entries encoded in the VRS and I confirm that the same are correct, accurate " +
                            "and consistent with the information I supplied in this application form. Further, by agreeing, " +
                            "I authorize and give my consent to the Commission on Elections and the concerned Election Registration Board " +
                            "to collect and process the personal data I supplied here in for purposes of voter registration and elections, " +
                            "and for other purposes and allowable disclosures under B.P. Blg.881, R.A. No. 8189, 10173 and 10367, and the relevant " +
                            "Resolutions of the Commission on Elections.");
        }
        private string GetProvinceNameFromCode(string tableName, string codeColumn, string nameColumn, string code)
        {
            string name = string.Empty;

            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                conn.Open();
                string query = $"SELECT {nameColumn} FROM {tableName} WHERE {codeColumn} = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", code);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    name = result.ToString();
                }
            }

            return name;
        }
        private string GetCityNameFromCode(string tableName, string provinceCodeColumn, string cityCodeColumn, string nameColumn, string provinceCode, string cityCode)
        {
            string name = string.Empty;

            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                conn.Open();
                string query = $"SELECT {nameColumn} FROM {tableName} WHERE {provinceCodeColumn} = ? AND {cityCodeColumn} = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", provinceCode);
                cmd.Parameters.AddWithValue("?", cityCode);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    name = result.ToString();
                }
            }

            return name;
        }

        private string GetBrgyNameFromCode(string tableName, string provinceCodeColumn, string cityCodeColumn, string barangayCodeColumn, string nameColumn, string provinceCode, string cityCode, string barangayCode)
        {
            string name = string.Empty;

            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                conn.Open();
                string query = $"SELECT {nameColumn} FROM {tableName} WHERE {provinceCodeColumn} = ? AND {cityCodeColumn} = ? AND {barangayCodeColumn} = ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", provinceCode);
                cmd.Parameters.AddWithValue("?", cityCode);
                cmd.Parameters.AddWithValue("?", barangayCode);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    name = result.ToString();
                }
            }

            return name;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string originalFilePath = dialog.FileName;
                string folderPath = @"D:\CIT\II - BSCPE\2nd Sem\4 CPE262\Output\Programs\Voter Registration System\Databases\Applicant IDs";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                string fileExtension = Path.GetExtension(dialog.FileName);

                string newFileName = $"{txbLname.Text}, {txbFname.Text} {txbMname.Text}{fileExtension}";
                string newFilePath = Path.Combine(folderPath, newFileName);

                File.Copy(originalFilePath, newFilePath);

                pictureBoxPhoto.ImageLocation = newFilePath;

                uploadedFilePath = newFilePath;
            }
        }
    }
}
