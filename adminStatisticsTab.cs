using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using SkiaSharp;
using System.Data.OleDb;
using LiveChartsCore.SkiaSharpView.Painting;
using System.Collections;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView.SKCharts;
using LiveChartsCore.SkiaSharpView.VisualElements;

namespace Voter_Registration_System
{
    public partial class AdminStatisticsTab : Form
    {
        private PieChart pieChart;
        private PieChart byProvince;
        private PieChart byMuniCity;
        private PieChart byBrgy;
        public AdminStatisticsTab()
        {
            InitializeComponent();
            sidePanel.Height = btnStatistics.Height;
            sidePanel.Top = btnStatistics.Top;

            pieChart = new PieChart
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(pieChart);
            byProvince = new PieChart
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(byProvince);
            byMuniCity = new PieChart
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(byMuniCity);
            byBrgy = new PieChart
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(byBrgy);

            LoadPieChartData();
            LoadbyProvinceData();
            LoadbyMuniCity();
            LoadbyBrgy();
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
            adminSearchTab adminSearchTab = new adminSearchTab();
            adminSearchTab.Show();
            this.Hide();
        }
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnStatistics.Height;
            sidePanel.Top = btnStatistics.Top;
        }
        string myConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\CIT\\II - BSCPE\\2nd Sem\\4 CPE262\\Output\\Programs\\Voter Registration System\\Databases\\VoterRegistrationSystem.accdb";
        private void LoadPieChartData()
        {
            var category = new Dictionary<string, decimal>();

            // Fetch data from Access


            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                conn.Open();
                string query = "SELECT Status, COUNT(*) AS Total FROM Applicants GROUP BY Status";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string status = reader["Status"].ToString();
                        decimal total = Convert.ToDecimal(reader["Total"]);

                        category[status] = total;
                    }
                }
            }

            decimal totalSum = category.Values.Sum();

            var series = category.Select(cs =>
                new PieSeries<decimal>
                {
                    Values = new[] { cs.Value },
                    Name = cs.Key,
                    DataLabelsPaint = new SolidColorPaint(SKColors.White),
                    DataLabelsSize = 14,
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                    DataLabelsFormatter = point =>
                    {
                        //double percent = (point.Coordinate.PrimaryValue / (double)totalSum) * 100;
                        return $"{cs.Key}: {point.Coordinate.PrimaryValue}";
                    }
                }).ToArray();

            pieChart1.Series = series;

            pieChart1.Title = new LabelVisual
            {
                Text = "Applicants by Status",
                TextSize = 16,
                Padding = new LiveChartsCore.Drawing.Padding(15),
                Paint = new SolidColorPaint(SKColors.DarkSlateGray)
            };
        }

        private void AdminStatisticsTab_Load(object sender, EventArgs e)
        {
            labelAdmin.Text = "Hello " + loginForm.LoggedInUser + "!";
            loadStats(sender, e);

            try
            {
                LoadbyProvinceData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chart error: " + ex.Message);
            }
        }

        private void loadStats(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                conn.Open();

                // Count pending applicants
                string pendingQuery = "SELECT COUNT(*) FROM Applicants WHERE Status = 'Pending'";
                OleDbCommand cmdPending = new OleDbCommand(pendingQuery, conn);
                int pendingCount = (int)cmdPending.ExecuteScalar();
                lblPending.Text = pendingCount.ToString();

                // Count approved applicants
                string approvedQuery = "SELECT COUNT(*) FROM Applicants WHERE Status = 'Approved'";
                OleDbCommand cmdApproved = new OleDbCommand(approvedQuery, conn);
                int approvedCount = (int)cmdApproved.ExecuteScalar();
                lblApproved.Text = approvedCount.ToString();

                // Count active voters
                string activeQuery = "SELECT COUNT(*) FROM Voters WHERE Status = 'Active'";
                OleDbCommand cmdActive = new OleDbCommand(activeQuery, conn);
                int activeCount = (int)cmdActive.ExecuteScalar();
                lblActive.Text = activeCount.ToString();
            }
        }
        private void LoadbyProvinceData()
        {
            var provinceData = new Dictionary<string, decimal>();

            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                conn.Open();
                string query = "SELECT Province, COUNT(*) AS Total FROM Voters GROUP BY Province";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string province = reader["Province"].ToString();
                        decimal total = Convert.ToDecimal(reader["Total"]);
                        provinceData[province] = total;
                    }
                }
            }

            decimal totalSum = provinceData.Values.Sum();

            var series = provinceData.Select(cs =>
                new PieSeries<decimal>
                {
                    Values = new[] { cs.Value },
                    Name = cs.Key,
                    DataLabelsPaint = new SolidColorPaint(SKColors.White),
                    DataLabelsSize = 14,
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                    DataLabelsFormatter = point =>
                    {
                        //double percent = (point.Coordinate.PrimaryValue / (double)totalSum) * 100;
                        return $"{cs.Key}: {point.Coordinate.PrimaryValue}";
                    }
                }).ToArray();

            pieChart2.Series = series;

            pieChart2.Title = new LabelVisual
            {
                Text = "Voters by Province",
                TextSize = 16,
                Padding = new LiveChartsCore.Drawing.Padding(15),
                Paint = new SolidColorPaint(SKColors.DarkSlateGray)
            };
        }
        private void LoadbyMuniCity()
        {
            var municipalityData = new Dictionary<string, decimal>();

            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                conn.Open();
                string query = "SELECT MuniCity, COUNT(*) AS Total FROM Voters GROUP BY MuniCity";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string municipality = reader["MuniCity"].ToString();
                        decimal total = Convert.ToDecimal(reader["Total"]);
                        municipalityData[municipality] = total;
                    }
                }
            }

            decimal totalSum = municipalityData.Values.Sum();

            var series = municipalityData.Select(cs =>
                new PieSeries<decimal>
                {
                    Values = new[] { cs.Value },
                    Name = cs.Key,
                    DataLabelsPaint = new SolidColorPaint(SKColors.White),
                    DataLabelsSize = 14,
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                    DataLabelsFormatter = point =>
                    {
                        //double percent = (point.Coordinate.PrimaryValue / (double)totalSum) * 100;
                        return $"{cs.Key}: {point.Coordinate.PrimaryValue}";
                    }
                }).ToArray();

            pieChart4.Series = series;

            pieChart4.Title = new LabelVisual
            {
                Text = "Voters by Municipality",
                TextSize = 16,
                Padding = new LiveChartsCore.Drawing.Padding(15),
                Paint = new SolidColorPaint(SKColors.DarkSlateGray)
            };
        }
        private void LoadbyBrgy()
        {
            var brgyData = new Dictionary<string, decimal>();

            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                conn.Open();
                string query = "SELECT Barangay, COUNT(*) AS Total FROM Voters GROUP BY Barangay";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string brgy = reader["Barangay"].ToString();
                        decimal total = Convert.ToDecimal(reader["Total"]);
                        brgyData[brgy] = total;
                    }
                }
            }

            decimal totalSum = brgyData.Values.Sum();

            var series = brgyData.Select(cs =>
                new PieSeries<decimal>
                {
                    Values = new[] { cs.Value },
                    Name = cs.Key,
                    DataLabelsPaint = new SolidColorPaint(SKColors.White),
                    DataLabelsSize = 14,
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                    DataLabelsFormatter = point =>
                    {
                        //double percent = (point.Coordinate.PrimaryValue / (double)totalSum) * 100;
                        return $"{cs.Key}: {point.Coordinate.PrimaryValue}";
                    }
                }).ToArray();

            pieChart3.Series = series;

            pieChart3.Title = new LabelVisual
            {
                Text = "Voters by Barangay",
                TextSize = 16,
                Padding = new LiveChartsCore.Drawing.Padding(15),
                Paint = new SolidColorPaint(SKColors.DarkSlateGray)
            };
        }
    }
}

