using Dapper.Entity.RequestModel;
using Dapper.Entity.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Service.IService
{
    public interface IEmployeeService
    {
        public Task<ResponseModel<bool>> AddEmployee(EmployeeRequestModel departmentRequestModel);
        public Task<ResponseModel<List<EmployeeResponeModel>>> GetAllEmployee();
    }
}
