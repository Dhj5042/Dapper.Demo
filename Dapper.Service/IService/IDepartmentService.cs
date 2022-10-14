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
        public Task<ResponseModel<bool> AddDepartment();
    }
}
