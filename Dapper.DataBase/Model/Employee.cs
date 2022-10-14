using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.DataBase.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }=string.Empty;
        public string EmployeeAge { get; set; }
        public string EmployeeJoingDate { get; set; }
        public string EmployeeSalary { get; set; }

        public int DepartmentId { get; set; }
        [ForeignKey("Id")]
        public virtual Department Department { get; set; }
    }
}
