using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Entity.ResponseModel
{
    public class ResponseModel<T>
    {
        public T Result { get; set; }
        public bool Status { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
