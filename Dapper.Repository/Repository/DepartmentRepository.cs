using Dapper.DataBase.Data;
using Dapper.DataBase.Model;
using Dapper.Entity.RequestModel;
using Dapper.Entity.ResponseModel;
using Dapper.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Repository.Repository
{
    public class DepartmentRepository:IDepartmentRepository
    {
        //private readonly IDepartmentRepository _departmentRepository;
        private readonly DataContext _context;

        public DepartmentRepository(DataContext dataContext)
        {
            //_departmentRepository = departmentRepository;
            _context = dataContext;
        }

        public async Task<bool> AddDepartment(DepartmentRequestModel departmentRequestModel)
        {
            Department department = new Department()
            {
                DeoartmentName = departmentRequestModel.DepartmentName
            };
            var result =await _context.Departments.AddAsync(department);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Department>> GetAlldepartment()
        {
            var result =await _context.Departments.ToListAsync();
            return result;
        }

        public async Task<bool> UpdateDepartment(DepartmentRequestModel model)
        {
            var departmentList = await _context.Departments.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (departmentList != null)
            {
                departmentList.DeoartmentName = model.DepartmentName;
                _context.Update(departmentList);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
