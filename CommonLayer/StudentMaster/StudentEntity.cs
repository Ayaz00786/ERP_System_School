using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer.EmployeeMaster
{
    public class StudentEntity
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int Class { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string Mobile { get; set; }
        public string AadharNo { get; set; }
        public string AdmissionDate { get; set; }
        public string Address { get; set; }

    }


    public class Employee
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string Mobile { get; set; }
        public string Gender { get; set; }
        public string HighestQualification { get; set; }
        public string Address { get; set; }

    }
}
