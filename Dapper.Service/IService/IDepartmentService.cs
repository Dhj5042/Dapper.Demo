using Dapper.Entity.RequestModel;
using Dapper.Entity.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Service.IService
{
    public interface IDepartmentService
    {
        public Task<ResponseModel<bool>> AddDepartment(DepartmentRequestModel departmentRequestModel);

        public Task<ResponseModel<List<DepartmentResponseModel>>> GetAlldepartment();
        public Task<ResponseModel<bool>> UpdateDepartment(DepartmentRequestModel model);
        public Task<ResponseModel<bool>> DeleteDepartment(int deptId);
    }
}
