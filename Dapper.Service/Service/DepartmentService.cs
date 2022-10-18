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
    public class DepartmentService:IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public DepartmentService(IDepartmentRepository departmentRepository,IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<bool>> AddDepartment(DepartmentRequestModel departmentRequestModel)
        {
            ResponseModel<bool> response = new ResponseModel<bool>();
            var result = await _departmentRepository.AddDepartment(departmentRequestModel);
            if (result)
            {
                response.StatusCode = (int)HttpStatusCode.OK;
                response.Status = true;
                response.Result = true;
                response.Message = "Data Add SuccessFully";
            }
            else
            {
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                response.Status = false;
                response.Result = false;
                response.Message = "Something Went Wrong";
            }
            return response;
        }

        public async Task<ResponseModel<bool>> DeleteDepartment(int deptId)
        {
            ResponseModel<bool> response = new ResponseModel<bool>();
            var result = await _departmentRepository.deleteDepartment(deptId);
            if (result)
            {
                response.StatusCode = (int)HttpStatusCode.OK;
                response.Status = true;
                response.Result = true;
                response.Message = "Deleted SuccessFully";
            }
            else
            {
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                response.Status = false;
                response.Result = false;
                response.Message = "Something Went Wrong";
            }
            return response;
        }

        public async Task<ResponseModel<List<DepartmentResponseModel>>> GetAlldepartment()
        {
            ResponseModel<List<DepartmentResponseModel>> response = new ResponseModel<List<DepartmentResponseModel>>();
            var result = await _departmentRepository.GetAlldepartment();
            List<DepartmentResponseModel> res = _mapper.Map<List<DepartmentResponseModel>>(result);
            if (result!=null)
            {
                response.StatusCode = (int)HttpStatusCode.OK;
                response.Status = true;
                response.Result = res;
                response.Message = "Department retrive successfully";
            }
            else
            {
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                response.Status = false;
                response.Message = "Something Went Wrong";
            }
            return response;
        }

        public async Task<ResponseModel<bool>> UpdateDepartment(DepartmentRequestModel model)
        {
            ResponseModel<bool> response = new ResponseModel<bool>();
            var result = await _departmentRepository.UpdateDepartment(model);
            if (result)
            {
                response.StatusCode = (int)HttpStatusCode.OK;
                response.Status = true;
                response.Result = true;
                response.Message = "Update Data SuccessFully";
            }
            else
            {
                response.StatusCode = (int)HttpStatusCode.BadRequest;
                response.Status = false;
                response.Result = false;
                response.Message = "Data not found!...";
            }
            return response;
        }
    }
}
