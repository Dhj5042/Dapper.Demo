using Dapper.Entity.RequestModel;
using Dapper.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dapper.Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        #region --> Add Department 
        [Route("AddDepartment")]
        [HttpPost]
        public async Task<IActionResult> GetClientList([FromBody] DepartmentRequestModel model)
        {
            try
            {
                var response = await _departmentService.AddDepartment(model);
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

        #region --> Get Department List
        [Route("GetAllDepartment")]
        [HttpGet]
        public async Task<IActionResult> GetAllDepartment()
        {
            try
            {
                var response = await _departmentService.GetAlldepartment();
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

        #region --> Update Department 
        [Route("UpdateDepartment")]
        [HttpPost]
        public async Task<IActionResult> UpdateDepartment([FromBody] DepartmentRequestModel model)
        {
            try
            {
                var response = await _departmentService.UpdateDepartment(model);
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

        #region --> Delelte Department 
        [Route("DeleteDepartment")]
        [HttpGet]
        public async Task<IActionResult> DeleteDepartment(int depetId)
        {
            try
            {
                var response = await _departmentService.DeleteDepartment(depetId);
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
