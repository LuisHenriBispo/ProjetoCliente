using Microsoft.AspNetCore.Mvc;
using PojetoNovoLRAleatorio.Models;
using ProjetoNovoLRAleatorio.Models;
using ProjetoNovoLRAleatorio.Repositorio;
using System.Diagnostics;

namespace PojetoNovoLRAleatorio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //Página Cadastro Cliente que envia os dados(post)
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
