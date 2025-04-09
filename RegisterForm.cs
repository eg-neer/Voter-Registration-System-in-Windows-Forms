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
    public partial class registerForm : Form
    {
        private Dictionary<string, List<string>> provinceCityMap = new();
        private Dictionary<string, List<string>> cityBarangayMap = new();
        private readonly string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\CIT\II - BSCPE\2nd Sem\4 CPE262\Output\Programs\Voter Registration System\Users.accdb";
        public registerForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Hide();
        }
        private bool IsEmailUnique(string email)
        {
            using var conn = new OleDbConnection(connectionString);
            conn.Open();
            var cmd = new OleDbCommand("SELECT COUNT(*) FROM Users WHERE Email = ?", conn);
            cmd.Parameters.AddWithValue("?", email);
            return (int)cmd.ExecuteScalar() == 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (cboxConsent.Checked)
            {
                MessageBox.Show("Your application will be reviewed. Please check your email.");
                Form1 startup = new Form1();
                startup.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check the oath, notice, and consent to continue.");
                return;
            }
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

        private void cboxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxMuniCity.Items.Clear();
            cboxBarangay.Items.Clear();

            string selectedProvince = cboxProvince.SelectedItem?.ToString() ?? "";

            if (provinceCityMap.ContainsKey(selectedProvince))
            {
                cboxMuniCity.Items.AddRange(provinceCityMap[selectedProvince].ToArray());
                cboxMuniCity.Enabled = true;
            }
        }
        private void LoadData()
        {
            provinceCityMap["Cebu"] = new List<string> { "Alcantara",       "Alcoy",            "Alegria",      "Aloguinsan",   "Argao",
                                                         "Asturias",        "Badian",           "Balamban",     "Bantayan",     "Barili",
                                                         "Bogo",            "Boljoon",          "Borbon",       "Carcar",       "Carmen",
                                                         "Catmon",          "Cebu City",        "Compostela",   "Consolacion",  "Cordova",
                                                         "Daanbantayan",    "Dalaguete",        "Danao",        "Dumanjug",     "Ginatilan",
                                                         "Lapu-Lapu",       "Liloan",           "Madridejos",   "Malabuyoc",    "Mandaue",
                                                         "Medellin",        "Minglanilla",      "Moalboal",     "City of Naga", "Oslob",
                                                         "Pilar",           "Pinamungajan",     "Poro",         "Ronda",        "Samboan",
                                                         "San Fernando",    "San Francisco",    "San Remigio",  "Santa Fe",     "Santander",
                                                         "Sibonga",         "Sogod",            "Tabogon",      "Tabuelan",     "City of Talisay",
                                                         "City of Toledo",  "Tuburan",          "Tudela"};

            provinceCityMap["Bohol"] = new List<string> { "Alburquerque", "Alicia", "Anda", "Antequera", "Baclayon",
                                                         "Balilihan", "Batuan", "Bilar", "Buenavista", "Calape",
                                                         "Candijay", "Carmen", "Catigbian", "Clarin", "Corella",
                                                         "Cortes", "Dagohoy", "Danao", "Dauis", "Dimiao",
                                                         "Duero", "Garcia Hernandez", "Guindulman", "Inabanga", "Jagna",
                                                         "Getafe", "Lila", "Loay", "Loboc", "Loon",
                                                         "Mabini", "Maribojoc", "Panglao", "Pilar", "President Carlos P. Garcia",
                                                         "Sagbayan", "San Isidro", "San Miguel", "Sevilla", "Sierra Bullones",
                                                         "Sikatuna", "Tagbilaran", "Talibon", "Trinidad", "Tubigon",
                                                         "Ubay", "Valencia", "Bien Unido"};

            cityBarangayMap["Cebu City"] = new List<string> { "Adlaon", "Agsungot", "Apas", "Babag", "Basak Pardo",
                                                              "Bacayan", "Banilad", "Basak San Nicolas", "Binaliw", "Bonbon",
                                                              "Budla-an", "Buhisan", "Bulacao", "Buot-Taup Pardo", "Busay",
                                                              "Calamba", "Cambinocot", "Capitol Site", "Carreta", "Central",
                                                              "Cogon Ramos", "Cogon Pardo", "Day-as", "Duljo", "Ermita",
                                                              "Guadalupe", "Guba", "Hippodromo", "Inayawan", "Kalubihan",
                                                              "Kalunasan", "Kamagayan", "Kamputhaw", "Kasambagan", "Kinasang-an Pardo",
                                                              "Labangon", "Lahug", "Lorega", "Lusaran", "Luz",
                                                              "Mabini", "Mabolo", "Malubog", "Mambaling", "Pahina Central",
                                                              "Pahina San Nicolas", "Pamutan", "Pardo", "Pari-an", "Paril",
                                                              "Pasil", "Pit-os", "Pulangbato", "Pung-ol-Sibugay", "Punta Princesa",
                                                              "Quiot Pardo", "Sambag I", "Sambag II", "San Antonio", "San Jose",
                                                              "San Nicolas Central", "San Roque", "Santa Cruz", "Sawang Calero", "Sinsin",
                                                              "Sirao", "Suba San Nicolas", "Sudlon I", "Sapangdaku", "T. Padilla",
                                                              "Tabunan", "Tagbao", "Talamban", "Taptap", "Tejero",
                                                              "Tinago", "Tisa", "To-ong Pardo", "Zapatera", "Sudlon II" };

            cityBarangayMap["Mandaue"] = new List<string> { "Alang-alang", "Bakilid", "Banilad", "Basak", "Cabancalan",
                                                            "Cambaro", "Canduman", "Casili", "Casuntingan", "Centro",
                                                            "Cubacub", "Guizo", "Ibabao-Estancia", "Jagobiao", "Labogon",
                                                            "Looc", "Maguikay", "Mantuyong", "Opao", "Pakna-an",
                                                            "Pagsabungan", "Subangdaku", "Tabok", "Tawason", "Tingub",
                                                            "Tipolo", "Umapad"};

            cityBarangayMap["Lapu-Lapu"] = new List<string> { "Agus", "Babag", "Bankal", "Baring", "Basak",
                                                              "Buaya", "Calawisan", "Canjulao", "Caw-oy", "Cawhagan",
                                                              "Caubian", "Gun-ob", "Ibo", "Looc", "Mactan",
                                                              "Maribago", "Marigondon", "Pajac", "Pajo", "Pangan-an",
                                                              "Poblacion", "Punta Engaño", "Pusok", "Sabang", "Santa Rosa",
                                                              "Subabasbas", "Talima", "Tingo", "Tungasan", "San Vicente"};

            cityBarangayMap["Tagbilaran"] = new List<string> { "Bool", "Booy", "Cabawan", "Cogon", "Dao",
                                                               "Dampas", "Manga", "Mansasa", "Poblacion I", "Poblacion II"};

            cityBarangayMap["Panglao"] = new List<string> { "Bil-isan", "Bolod", "Danao", "Doljo", "Libaong",
                                                            "Looc", "Lourdes", "Poblacion", "Tangnan", "Tawala"};

            cboxProvince.Items.Clear();
            cboxProvince.Items.AddRange(provinceCityMap.Keys.ToArray());
        }

        private void cboxMuniCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxBarangay.Items.Clear();

            string selectedCity = cboxMuniCity.SelectedItem?.ToString() ?? "";

            if (cityBarangayMap.ContainsKey(selectedCity))
            {
                cboxBarangay.Items.AddRange(cityBarangayMap[selectedCity].ToArray());
                cboxBarangay.Enabled = true;
            }
        }
    }
}
