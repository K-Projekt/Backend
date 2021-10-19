using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Backend.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SomethingController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var v = new { Message = "Hello world" };

            return await Task.FromResult(Json(v));
        }
    }
}