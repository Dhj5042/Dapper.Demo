using Dapper.Entity.RequestModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dapper.Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        #region --> Get Client List
        [Route("AddDepartment")]
        [HttpPost]
        public async Task<IActionResult> GetClientList([FromBody] DepartmentRequestModel model)
        {
            try
            {
                var response = await _clientService.GetClientList(model);
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
