using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly ILogger _logger;
        public EmployeeController(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<EmployeeController>();
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            return Json(new WebApplication.Models.Employee()); ;
        }
    }

}