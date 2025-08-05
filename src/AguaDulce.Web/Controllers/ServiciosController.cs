using Microsoft.AspNetCore.Mvc;
using AguaDulce.Web.Models;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;

namespace AguaDulce.Web.Controllers
{
    public class ServiciosController : Controller
    {

        private readonly IWebHostEnvironment _hostingEnvironment;
        private List<ServicioModel> _servicios;

        public ServiciosController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _servicios = CargarServicios();
        }

        private List<ServicioModel> CargarServicios()
        {
            var path = Path.Combine(_hostingEnvironment.WebRootPath, "data", "servicios.json");
            //Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", "publicaciones.json");
            if (!System.IO.File.Exists(path))
            {
                return new List<ServicioModel>();
            }

            var json = System.IO.File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<ServicioModel>>(json) ?? new List<ServicioModel>();
        }



        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Title"] = "Servicios";
            return View(_servicios);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var servicio = _servicios.FirstOrDefault(s => s.Id == id);
            if (servicio == null)
            {
                return NotFound();
            }

            ViewData["Title"] = servicio.Titulo;
            return View(servicio);
        }
    }
}

//using AguaDulce.Web.Models;
//using AguaDulce.Web.Controllers;
//using Microsoft.AspNetCore.Mvc;

//namespace AguaDulce.Web.Controllers
//{
//    public class ServiciosController : Controller
//    {
//        private readonly IServicioService _servicioService;

//        public ServiciosController(IServicioService servicioService)
//        {
//            _servicioService = servicioService;
//        }

//        [HttpGet]
//        public IActionResult Index()
//        {
//            ViewData["Title"] = "Servicios";
//            return View(_servicioService.ObtenerServicios());
//        }

//        [HttpGet]
//        public IActionResult Details(int id)
//        {
//            var servicio = _servicioService.ObtenerServicioPorId(id);

//            if (servicio == null)
//                return NotFound();

//            ViewData["Title"] = servicio.Titulo;
//            return View(servicio);
//        }
//    }
//}
