using AutoMapper;
using Dapper.Entity.RequestModel;
using Dapper.Entity.ResponseModel;
using Dapper.Repository.IRepository;
using Dapper.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Service.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<ResponseModel<bool>> AddEmployee(EmployeeRequestModel employeeRequestModel)
        {
            ResponseModel<bool> response = new ResponseModel<bool>();
            var result = await _employeeRepository.AddEmployee(employeeRequestModel);

            if (result != null)
            {
                response.StatusCode = (int)HttpStatusCode.OK;
                response.Status = true;
                response.Result = result;
                response.Message = "Employee retrive successfully";
            }
            else
            {
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                response.Status = false;
                response.Message = "Something Went Wrong";
            }
            return response;
        }

        public async Task<ResponseModel<List<EmployeeResponeModel>>> GetAllEmployee()
        {
            ResponseModel<List<EmployeeResponeModel>> response = new ResponseModel<List<EmployeeResponeModel>>();
            var result = await _employeeRepository.GetAllEmployee();
         
            if (result != null)
            {
                response.StatusCode = (int)HttpStatusCode.OK;
                response.Status = true;
                response.Result = result;
                response.Message = "Employee retrive successfully";
            }
            else
            {
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                response.Status = false;
                response.Message = "Something Went Wrong";
            }
            return response;
        }
    }
}
