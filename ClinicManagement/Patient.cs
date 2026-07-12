namespace ClinicManagement
{
    public class Patient:Person
    {
        
       
        public string NationalCode { get;private set; }
        public string MobileNumber { get; private set; }
        public Patient(string firstName, string lastName, string nationalCode, string mobileNumber)
            :base(firstName, lastName)
        {
            NationalCode = nationalCode;
            MobileNumber = mobileNumber;
        }
    }
}
