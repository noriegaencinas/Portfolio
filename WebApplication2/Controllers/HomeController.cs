using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;
using WebApplication2.Servicios;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;
        //private readonly IConfiguration configuration;

        public HomeController(ILogger<HomeController> logger,
            IRepositorioProyectos repositorioProyectos
            //IConfiguration configuration
            )
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
            //this.configuration = configuration;
        }

        public IActionResult Index()
        {
            //var apellido = configuration.GetValue<string>("Apellido");
            //_logger.LogTrace("Este es un mensaje de log");
            //_logger.LogDebug("Este es un mensaje de debug");
            //_logger.LogInformation("Este es un mensaje de Information");
            //_logger.LogWarning("Este es un mensaje de warning");
            //_logger.LogError("Este es un mensaje de error");
            //_logger.LogCritical("Este es un mensaje de critical" + apellido);
            var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();

            var modelo = new HomeViewModel() { 
                Proyectos = proyectos
            };

            return View(modelo);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}