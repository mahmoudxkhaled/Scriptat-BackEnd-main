using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain
{
    public class GeneralClass
    {

    }
    public class ApiError
    {
        public string key { get; set; }
        public string message { get; set; }
    }
    public class ApiResult
    {
        public bool success { get; set; }

        public List<ApiError> errorList { get; set; }

        public object data { get; set; }
    }

}
