using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement
{
    public class Result
    {
        public bool Success { get; set; }
        public string Message { get; set; }
       public static Result Failed(string msg)
        {
            Result result = new Result();
            result.Success = false;
            result.Message = msg;
            return result;
        }
        public static Result Ok()
        {
            Result res = new Result();
            res.Success = true;
            return res;
        }
    }
}
