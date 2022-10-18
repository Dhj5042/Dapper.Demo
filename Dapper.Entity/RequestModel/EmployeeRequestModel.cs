using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Entity.RequestModel
{
    public class EmployeeRequestModel
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public string EmployeeAge { get; set; }
        public string EmployeeJoingDate { get; set; }
        public string EmployeeSalary { get; set; }

        public int DepartmentId { get; set; }
    }
}
