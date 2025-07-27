using Microsoft.AspNetCore.Mvc;
using AguaDulce.Web.Models;
using System.Collections.Generic;

namespace AguaDulce.Web.Controllers
{
    public class ServiciosController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var servicios = new List<ServicioModel>
            {
                new ServicioModel
                {
                    Titulo = "Corrección de estilo",
                    Descripcion = "Pulimos tu texto para que brille.",
                    IconoUrl = "/icons/correccion.svg"
                },
                new ServicioModel
                {
                    Titulo = "Diseño editorial",
                    Descripcion = "Maquetamos tu obra con criterios visuales profesionales.",
                    IconoUrl = "/icons/diseno.svg"
                },
                new ServicioModel
                {
                    Titulo = "Consultoría creativa",
                    Descripcion = "Te orientamos en el proceso editorial y narrativo.",
                    IconoUrl = "/icons/consultoria.svg"
                },
                new ServicioModel
                {
                    Titulo = "Publicación",
                    Descripcion = "Te acompañamos en la publicación impresa o digital.",
                    IconoUrl = "/icons/publicacion.svg"
                }
            };

            return View(servicios);
        }
    }
}