using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Employee
    {
        public Employee()
        {
            Suffix = "";
            Sex = "";
            Address = "";
            City = "";
            State = "";
            Zip = "";
            Zip4 = "";
            CountryCode = "";
            MaritalStatus = "";
            SSNISAppliedFor = false;
        }

        [Key]
        public int EmpID { get; set; }

        public int ClientNo { get; set; }
        public int EmpNo { get; set; }
        public string SSN { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Zip4 { get; set; }
        public string CountryCode { get; set; }
        public string MaritalStatus { get; set; }
        public bool SSNISAppliedFor { get; set; }
    }
}