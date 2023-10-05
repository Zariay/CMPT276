using Microsoft.AspNetCore.Mvc;

namespace SampleProj.Controllers
{
    public class BuildController : Controller
    {
        public IActionResult Index(string champion_name)
        {
            return View();
        }
    }
}
