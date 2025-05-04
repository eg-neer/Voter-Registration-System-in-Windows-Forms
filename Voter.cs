using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Voter_Registration_System
{
    internal class Voter : Applicants
    {
        public string voterID { get; set; }
        public DateTime dateRegistered { get; set;}
        public string ProvinceCode { get; set; }
        public string CityCode { get; set; }
        public string BrgyCode { get; set; }    
        public string ControlCode { get; set; }
        public string password { get; set; }
        public DateTime lastVoted {  get; set; } 
        
        string myConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\CIT\\II - BSCPE\\2nd Sem\\4 CPE262\\Output\\Programs\\Voter Registration System\\Databases\\VoterRegistrationSystem.accdb";

        public string GenerateVoterID(string Province, string CityMunicipality, string Barangay)
        {
            this.ProvinceCode = GetProvinceCode("Provinces", "ProvinceCode", "ProvinceName", Province);
            this.CityCode = GetCityCode("MuniCities", "ProvinceCode", "MuniCity", "CityCode", ProvinceCode, CityMunicipality);
            this.BrgyCode = GetBrgyCode("Barangays", "ProvinceCode", "CityCode", "BarangayName", "BarangayCode", ProvinceCode, CityCode, Barangay);

            string locationCode = ProvinceCode + CityCode + BrgyCode;
            this.ControlCode = GetNextControlNumber(locationCode);
            voterID = locationCode + ControlCode;

            return voterID;
        }

        private string GetNextControlNumber(string locationCode)
        {
            int nextNumber = 1; // default starting number

            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                conn.Open();
                string query = @"SELECT MAX(Val(RIGHT(VoterID,7))) FROM Voters 
                 WHERE LEFT(VoterID, ?) = ?";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", locationCode.Length);
                    cmd.Parameters.AddWithValue("?", locationCode);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        nextNumber = Convert.ToInt32(result) + 1;
                    }
                }
            }

            return nextNumber.ToString("D7"); // Format as 7 digits, e.g., 0000002
        }

        private string GetProvinceCode(string tableName, string codeColumn, string nameColumn, string name)
        {
            string code = string.Empty;

            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                conn.Open();
                string query = $"SELECT {codeColumn} FROM {tableName} WHERE {nameColumn} = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", name);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        code = result.ToString();
                    }
                }
            }

            return code;
        }
        private string GetCityCode(string tableName, string provinceCodeColumn, string cityNameColumn, string codeColumn, string provinceCode, string cityName)
        {
            string code = string.Empty;

            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                conn.Open();
                string query = $"SELECT {codeColumn} FROM {tableName} WHERE {provinceCodeColumn} = ? AND {cityNameColumn} = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", provinceCode);
                    cmd.Parameters.AddWithValue("?", cityName);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        code = result.ToString();
                    }
                }
            }

            return code;
        }

        private string GetBrgyCode(string tableName, string provinceCodeColumn, string cityCodeColumn, string barangayNameColumn, string codeColumn, string provinceCode, string cityCode, string barangayName)
        {
            string code = string.Empty;

            using (OleDbConnection conn = new OleDbConnection(myConn))
            {
                conn.Open();
                string query = $"SELECT {codeColumn} FROM {tableName} WHERE {provinceCodeColumn} = ? AND {cityCodeColumn} = ? AND {barangayNameColumn} = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", provinceCode);
                    cmd.Parameters.AddWithValue("?", cityCode);
                    cmd.Parameters.AddWithValue("?", barangayName);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        code = result.ToString();
                    }
                }
            }

            return code;
        }
    }
}
