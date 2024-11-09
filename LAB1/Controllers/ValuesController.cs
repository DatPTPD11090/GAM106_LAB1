using LAB1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LAB1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Lab1Controller : ControllerBase
    {
        public IActionResult Get()
        {
            GAM106LAB1 Game106 = new GAM106LAB1
            {
                CourseName = "Back-End Game Programming",
                CourseCode = "GAM106",
                Name = "Phan Tuan Dat",
                StudentCode = "PD11090",
                Class = "GA19301",
            };
            int status = 1;
            string message = "Get data sucess!";
            var data = new { status, message, Game106 };
            return new JsonResult(data);
        }
    }
}
