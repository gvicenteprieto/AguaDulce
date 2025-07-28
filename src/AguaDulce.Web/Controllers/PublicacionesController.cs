using Microsoft.AspNetCore.Mvc;
using AguaDulce.Web.Models;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AguaDulce.Web.Controllers
{
    public class PublicacionesController : Controller
    {
        // GET: /Publicaciones
        public async Task<IActionResult> Index()
        {
            var rutaJson = Path.Combine(Directory.GetCurrentDirectory(),
                                        "wwwroot", "data", "publicaciones.json");

            List<PublicacionModel> publicaciones = new();
            if (System.IO.File.Exists(rutaJson))
            {
                var json = await System.IO.File.ReadAllTextAsync(rutaJson);
                publicaciones = JsonSerializer
                                 .Deserialize<List<PublicacionModel>>(json)!;
            }

            return View(publicaciones);
        }

        // GET: /Publicaciones/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var rutaJson = Path.Combine(Directory.GetCurrentDirectory(),
                                        "wwwroot", "data", "publicaciones.json");

            List<PublicacionModel> publicaciones = new();
            if (System.IO.File.Exists(rutaJson))
            {
                var json = await System.IO.File.ReadAllTextAsync(rutaJson);
                publicaciones = JsonSerializer
                                 .Deserialize<List<PublicacionModel>>(json)!;
            }

            var publicacion = publicaciones.FirstOrDefault(p => p.Id == id);
            if (publicacion == null)
                return NotFound();

            return View(publicacion);
        }
    }
}