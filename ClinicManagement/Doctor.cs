using System;
using System.Linq;

namespace ClinicManagement
{
    public class Doctor
    {
        private Doctor()
        {
            Id = DoctorManager.GenerateNewId();
        }
        public Doctor(string nezamPezeshki) : this()
        {
            NezamPezeshki = nezamPezeshki;

        }
        public Doctor(string firstName, string lastName) : this("")
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NezamPezeshki { get; set; }
        public string[] Specialties { get; set; }

        public string FullSpecialties
        {
            get
            {
                return string.Join(", ", Specialties);
            }
        }
    }
}
