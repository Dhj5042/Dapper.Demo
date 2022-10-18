using Dapper.Entity.RequestModel;
using Dapper.Entity.ResponseModel;
using Dapper.Repository.DapperWrapper;
using Dapper.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Repository.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IDapperWrapper _dapperWrapper;

        public EmployeeRepository(IDapperWrapper dapperWrapper)
        {
            _dapperWrapper = dapperWrapper;
        }

        public async Task<bool> AddEmployee(EmployeeRequestModel employeeRequestModel)
        {
            await _dapperWrapper.AddData("Insert into Employees ([EmployeeName],[EmployeeAge],[EmployeeJoingDate],[EmployeeSalary],[DepartmentId]) Values (@EmployeeName,@EmployeeAge,@EmployeeJoingDate,@EmployeeSalary,@DepartmentId)", employeeRequestModel);
            return true;
        }

        public async Task<List<EmployeeResponeModel>> GetAllEmployee()
        {
            List<EmployeeResponeModel> result = _dapperWrapper.GetData<EmployeeResponeModel>("select e.Id,e.EmployeeName,e.EmployeeAge,e.EmployeeJoingDate,e.EmployeeSalary,e.DepartmentId,d.DepartmentName from Employees e join Departments d on e.DepartmentId = d.Id");
            return result;
        }
    }
}
