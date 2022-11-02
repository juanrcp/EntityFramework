using EntityBasicoDAL;
using EntityFrameworkIntroduccion.AccesoViews;
using EntityFrameworkIntroduccion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EntityFrameworkIntroduccion.Controllers
{
    public class HomeController : Controller
    {
        //Eliminamos esta linea y el parametro del metodo HomeController
        //private readonly ILogger<HomeController> _logger;
        private readonly AccesoDC context;

        public HomeController(AccesoDC context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var accesos = this.context.empleados.Include(a => a.nivel_accesos).Select(m => new AccesoViewModel
            {
                nombre_empleado = m.nombre_empleado,
                nivel_accesos = m.nivel_accesos,
                desc_acceso = m.desc_acceso
            });
            return View(accesos);
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