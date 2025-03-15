using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MEtricConversionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
