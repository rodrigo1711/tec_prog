using Microsoft.AspNetCore.Mvc;
using Projeto_semestre.Models;

namespace Projeto_do_semestre.Controllers
{
    public class AreaPublicaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult VeiculosImportados()
        {
            return View();
        }

        public IActionResult VeiculosNacionais()
        {

            Carro c1 = new Carro();
            c1.Nome_carro = "brasília";
            c1.Desc_carro = "sei lá";
            c1.km_carro = 10900;
            c1.transmis_carro = "auto";


            Carro c2 = new Carro();
            c2.Nome_carro = "mobi";
            c2.Desc_carro = "jubilel";
            c2.km_carro = 250000;
            c2.transmis_carro = "auto";


            Carro c3 = new Carro();
            c3.Nome_carro = "kwid";
            c3.Desc_carro = "jubilei";
            c3.km_carro = 250002;
            c3.transmis_carro = "man";


            List<Carro> listaCarros = new List<Carro>();
            listaCarros.Add(c1);
            listaCarros.Add(c2);
            listaCarros.Add(c3);

            return View(listaCarros);
        }


    }
}
