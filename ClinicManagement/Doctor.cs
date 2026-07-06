using System;

namespace ClinicManagement
{
    public class Doctor
    {
        public Doctor() {}

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MedicalCouncilNumber { get; set; }
        public string[] Specialties { get; set; }
    }
}
