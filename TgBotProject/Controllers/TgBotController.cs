using Microsoft.AspNetCore.Mvc;

namespace TgBotProject.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TgBotController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
