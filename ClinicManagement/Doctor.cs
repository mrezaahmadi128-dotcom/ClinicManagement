using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement
{
    public class Doctor:Person
    {
        private string _medicalCode;
        public int Id {  get; set; }
        public string Specialty {  get; set; }
        public string MedicalCode { get; private set; }
        public Result Validation()
        {
            var result = new Result();
            if(string.IsNullOrEmpty(FirstName))
            {
                result.Success = false;
                result.Message = "نام را وارد کنید";
                return result;
            }
            if (string.IsNullOrWhiteSpace(LastName))
            {
                result.Success = false;
                result.Message = "نام خانوادگی را وارد کنید";
                return result;
            }

            if (string.IsNullOrWhiteSpace(Specialty))
            {
                result.Success = false;
                result.Message = "تخصص را وارد کنید";
                return result;
            }

            if (string.IsNullOrWhiteSpace(MedicalCode) || MedicalCode.Length != 5)
            {
                result.Success = false;
                result.Message = "کد نظام پزشکی معتبر نیست";
                return result;
            }

            result.Success = true;
            return result;

        }
        public Doctor(string firstName, string lastName, string medicalCode)
            :base(firstName, lastName)
        {
            MedicalCode = medicalCode;
            Id = DoctorManagement.IdNumber();
        }
        public  Result Update(string firstName,string lastName, string medicalCode,string specialty)
        {
            if(string.IsNullOrWhiteSpace(firstName))
            {
                return Result.Failed("نام را وارد کنید");
            }
            if (string.IsNullOrWhiteSpace(lastName))
            {
                return Result.Failed("فامیلی را وارد کنید");
            }
            if (string.IsNullOrWhiteSpace(medicalCode))
            {
                return Result.Failed("کدپزشکی را وارد کنید");
            }
            if (string.IsNullOrWhiteSpace(specialty))
            {
                return Result.Failed("تخصص خود را وارد کنید");
            }
            FirstName= firstName;
            LastName= lastName;
            MedicalCode=medicalCode;
            Specialty=specialty;
            return Result.Ok();


        }
    }
}
