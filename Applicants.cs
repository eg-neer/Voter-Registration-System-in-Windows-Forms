using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voter_Registration_System
{
    internal class Applicants
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Province { get; set; }
        public string CityMunicipality { get; set; }
        public string Barangay { get; set; }
        public DateTime ApplicationDate {  get; set; }
        public string Status { get; set; }
        public string GovIssuedID {  get; set; }

        public int IsOfVotingAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - DateOfBirth.Year;

            if (DateOfBirth.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
        public bool IsDuplicate(string email, OleDbConnection conn)
        {
            string query = "SELECT COUNT(*) FROM Applicants WHERE EmailAddress = @Email";
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);

                return (int)cmd.ExecuteScalar() > 0;
            }
        }
    }
}
