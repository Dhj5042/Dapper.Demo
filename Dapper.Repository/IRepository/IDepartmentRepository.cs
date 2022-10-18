using Dapper.DataBase.Model;
using Dapper.Entity.RequestModel;
using Dapper.Entity.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Repository.IRepository
{
    public interface IDepartmentRepository
    {
        public Task<bool> AddDepartment(DepartmentRequestModel departmentRequestModel);
        public Task<List<Department>> GetAlldepartment();
        public Task<bool> UpdateDepartment(DepartmentRequestModel model);
        public Task<bool> deleteDepartment(int deptId);
    }
}
