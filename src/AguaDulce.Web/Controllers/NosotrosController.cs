using Microsoft.AspNetCore.Mvc;

namespace AguaDulce.Web.Controllers
{
    [Route("[controller]")]
    public class NosotrosController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}