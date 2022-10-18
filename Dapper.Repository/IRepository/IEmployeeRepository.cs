using Dapper.Entity.RequestModel;
using Dapper.Entity.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Repository.IRepository
{
    public interface  IEmployeeRepository
    {
        public Task<List<EmployeeResponeModel>> GetAllEmployee();
        public Task<bool> AddEmployee(EmployeeRequestModel employeeResponeModel);
    }
}
