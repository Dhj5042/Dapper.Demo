using Dapper.Entity.RequestModel;
using Dapper.Service.IService;
using Dapper.Service.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dapper.Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        #region --> Add Department 
        [Route("AddDepartment")]
        [HttpPost]
        public async Task<IActionResult> GetClientList([FromBody] EmployeeRequestModel model)
        {
            try
            {
                var response = await _employeeService.AddEmployee(model);
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception ex)
            {
                //ExceptionLogModel exceptionLogModel = new ExceptionLogModel(null, ex.Message, ex.StackTrace, "", HttpContext.Request.Path);
                //await _exceptionLogService.AddException(exceptionLogModel);
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region --> Get Employee List
        [Route("GetAllEmployee")]
        [HttpGet]
        public async Task<IActionResult> GetAllDepartment()
        {
            try
            {
                var response = await _employeeService.GetAllEmployee();
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception ex)
            {
                //ExceptionLogModel exceptionLogModel = new ExceptionLogModel(null, ex.Message, ex.StackTrace, "", HttpContext.Request.Path);
                //await _exceptionLogService.AddException(exceptionLogModel);
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
