using Microsoft.AspNetCore.Mvc;
using AguaDulce.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace AguaDulce.Web.Controllers
{
    public class TrabajoController : Controller
    {
        // Lista compartida para Index y Details
        private static readonly List<TrabajoModel> _trabajos = new List<TrabajoModel>
        {
            new TrabajoModel
            {
                Id = 1,
                Titulo = "Consultoría creativa",
                Descripcion = "Te orientamos en el proceso editorial y narrativo.",
                DescripcionLarga = "Te orientamos en el proceso editorial y narrativo."
                         + "Desde la concepción de la idea hasta la estructura final, te acompañamos para que tu proyecto tome forma con solidez y originalidad.",
                IconoUrl = "/icons/consultoria.svg"
            },
            new TrabajoModel
            {
                Id = 2,
                Titulo = "Redacción",
                Descripcion = "Damos forma a textos precisos y atractivos.",
                DescripcionLarga = "Creamos textos  que comunican con claridad y despiertan el interés de tus lectores."
                         + "Desde artículos y blogs hasta contenidos web y copys publicitarios, transformamos tus ideas en palabras que conectan y persuaden a tu público.",
                IconoUrl = "/icons/redaccion.svg"
            },
            new TrabajoModel
            {
                Id = 3,
                Titulo = "Corrección de estilo",
                Descripcion = "Pulimos tu texto para que brille.",
                DescripcionLarga = "Pulimos tu texto para que brille."
                         + "Aseguramos fluidez, claridad y coherencia, eliminando errores y mejorando la expresión." + "Tu mensaje será impecable y profesional, listo para cautivar a tu audiencia.",
                IconoUrl = "/icons/correccion.svg"
            },
            new TrabajoModel
            {
                Id = 4,
                Titulo = "Diseño editorial",
                Descripcion = "Maquetamos tu obra con criterios visuales profesionales.",
                DescripcionLarga = "Maquetamos tu obra con criterios visuales profesionales."
                         + "Creamos diseños atractivos y funcionales que realzan tu contenido." + "Desde libros a revistas, tu publicación tendrá una estética pulcra y coherente, impactando visualmente.",  
                IconoUrl = "/icons/diseno.svg"
            },
            new TrabajoModel
            {
                Id = 5,
                Titulo = "Publicación",
                Descripcion = "Te acompañamos en la publicación impresa o digital.",
                DescripcionLarga = "Te acompañamos en la publicación impresa o digital."
                         + "Gestionamos cada detalle para que tu obra vea la luz." + "Desde el ISBN hasta la distribución, aseguramos que tu trabajo llegue a manos de tus lectores, sea cual sea el formato.",
                IconoUrl = "/icons/publicacion.svg"
            },
            new TrabajoModel
            {
                Id = 6,
                Titulo = "Gestión de proyectos de comunicación",
                Descripcion = "Planificamos y coordinamos cada etapa con visión estratégica.",
                DescripcionLarga = "Coordinamos integralmente las iniciativas de comunicación de tu organización."
                         + "Planificamos, ejecutamos y supervisamos cada etapa para asegurar resultados exitosos." + "Optimizamos recursos, tareas y tiempos, garantizando una estrategia comunicacional coherente y eficaz.",
                IconoUrl = "/icons/gestion.svg"
            }
        };

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Title"] = "Servicios";
            return View(_trabajos);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var trabajo = _trabajos.FirstOrDefault(s => s.Id == id);
            if (trabajo == null)
            {
                return NotFound();
            }

            ViewData["Title"] = trabajo.Titulo;
            return View(trabajo);
        }
    }
}