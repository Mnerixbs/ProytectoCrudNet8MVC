<<<<<<< HEAD
using CrudNet8MVC.Datos;
using CrudNet8MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
=======
using CrudNet8MVC.Models;
using Microsoft.AspNetCore.Mvc;
>>>>>>> dbce2f87d8fe0341d40dd48142a024f637aae2e6
using System.Diagnostics;

namespace CrudNet8MVC.Controllers
{
    public class HomeController : Controller
    {
<<<<<<< HEAD
        private readonly ApplicationDbContext _contexto;


        public HomeController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
       public async  Task<IActionResult> Index()
        {
            return View(await _contexto.Contacto.ToListAsync());
        }

        [HttpGet]
        public IActionResult Crear()
=======
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
>>>>>>> dbce2f87d8fe0341d40dd48142a024f637aae2e6
        {
            return View();
        }

<<<<<<< HEAD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                contacto.FechaCreacion = DateTime.Now;
                _contexto.Contacto.Add(contacto);
                await _contexto.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
=======
>>>>>>> dbce2f87d8fe0341d40dd48142a024f637aae2e6
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
