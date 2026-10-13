using Microsoft.AspNetCore.Mvc;

namespace Projeto_semestre.Controllers
{
    public class AreaRestritaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdmVeiculos()
        {
            return View();
        }

        public IActionResult AdmVendas()
        {
            return View();
        }
    }
}
