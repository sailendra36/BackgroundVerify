using BackgroundVerify.Interface;
using BackgroundVerify.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackgroundVerify.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmploymentVerificationController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmploymentVerificationController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost("verify-employment")]
        public IActionResult VerifyEmployment([FromBody] EmploymentVerificationRequest request)
        {
            if (_employeeService.VerifyEmployment(request.EmployeeId, request.CompanyName, request.VerificationCode))
            {
                return Ok(new { verified = true });
            }
            return Ok(new { verified = false });
        }
    }

    
}
