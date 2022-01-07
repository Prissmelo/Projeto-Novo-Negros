using Microsoft.AspNetCore.Mvc;
using NEGRASM.Data;
using System.Linq;

namespace NEGRASM.Controllers
{
    [Route ("Consumidor")]
    public class ConsumidorController : Controller
    {
        [HttpGet]
        [Route ("Listar")]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();
            ViewData["Consumidores"] = dbcontext.Consumidores.Where(p => p.Id > 0).ToList();

            return View();
        }
    }
}
