using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        [HttpGet]
        public JsonResult GetAll()
        {
            return Json(new WebApplication.Models.Employee());;
        }
    }

}