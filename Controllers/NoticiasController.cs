using Microsoft.AspNetCore.Mvc;

namespace NEGRASM.Controllers
{
    public class NoticiasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
