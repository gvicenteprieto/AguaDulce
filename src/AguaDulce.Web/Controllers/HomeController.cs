using Microsoft.AspNetCore.Mvc;
using AguaDulce.Web.Models;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace AguaDulce.Web.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var rutaJson = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", "servicios.json");

            var servicio = new List<PublicacionModel>();
            if (System.IO.File.Exists(rutaJson))
            {
                var json = await System.IO.File.ReadAllTextAsync(rutaJson);
                servicio = JsonSerializer.Deserialize<List<PublicacionModel>>(json);
            }

            return View(servicio);
        }
    }
}