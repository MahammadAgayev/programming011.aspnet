using Microsoft.AspNetCore.Mvc;

namespace programming011.aspnet.Controllers
{
    public class ExperimentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
