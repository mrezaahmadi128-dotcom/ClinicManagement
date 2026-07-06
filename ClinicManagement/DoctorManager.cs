using System.Collections.Generic;

namespace ClinicManagement
{
    internal class DoctorManager
    {
        private static List<Doctor> Doctors;

        public List<Doctor> GetDoctors()
        {
            return Doctors;
        }

        public void AddDoctor(Doctor Doctor)
        {
            if (Doctors == null)
                Doctors = new List<Doctor>();

            Doctors.Add(Doctor);
        }

        public void UpdateDoctor(Doctor Doctor)
        {
            if (Doctors == null)
                Doctors = new List<Doctor>();

            
        }

        public string[] PatientValidation(
            string firstName,
            string lastName,
            string medicalCouncilNumber
            )
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(firstName))
                errors.Add("نام اجباری است");

            if (string.IsNullOrWhiteSpace(lastName))
                errors.Add("نام خانوادگی اجباری است");

            if (string.IsNullOrWhiteSpace(medicalCouncilNumber))
                errors.Add("کد نظام پزشکی اجباری است");
            else if (medicalCouncilNumber.Length <= 3)
                errors.Add("کد نظام پزشکی باید ۱۰ رقم باشد");

            return errors.ToArray();
        }
    }
}
