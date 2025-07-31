using Microsoft.AspNetCore.Mvc;
using AguaDulce.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace AguaDulce.Web.Controllers
{
    public class ServiciosController : Controller
    {
        // Lista compartida para Index y Details
        private static readonly List<ServicioModel> _servicios = new List<ServicioModel>
        {
            new ServicioModel
            {
                Id = 1,
                Titulo = "Mentoría de proyecto\n",
                Descripcion = "Diseñamos un recorrido personalizado de acuerdo a tus necesidades específicas \n",
                DescripcionLarga = "En Litoral te ofrecemos un programa de mentoría diseñado para potenciar cada etapa de tu proyecto, desde la concepción de la idea hasta su puesta en valor ante lectores y editores. Nuestro enfoque combina diagnóstico, revisión y estrategia para que ganes claridad, confianza y calidad en tu texto.\n"
                         + "\n• Diagnóstico inicial\nDetectamos fortalezas y áreas de mejora en tu manuscrito o propuesta, definiendo objetivos claros y realistas.\n" + "• Plan de trabajo personalizado\nCreamos un cronograma flexible que se adapta a tu ritmo creativo, estableciendo hitos de revisión y entrega.\n" + "• Sesiones de retroalimentación\nTe brindamos comentarios detallados sobre estructura, estilo y contenido, con herramientas y ejemplos prácticos.\n" + "• Asesoría y acompañamiento en procesos de publicación. Ofrecemos diferentes posibilidades de selección de editorial, así como de impresión y de distribución física y digital.\n" + "Contáctanos para diseñar juntos la mentoría que lleve tu obra al siguiente nivel.\n"
,
                IconoUrl = "/icons/asesoria.svg"
            },
            new ServicioModel
            {
                Id =2,
                Titulo = "Consultoría creativa",
                Descripcion = "Te orientamos en el proceso editorial y narrativo.",
                DescripcionLarga = "Te orientamos en el proceso editorial y narrativo."
                         + "Desde la concepción de la idea hasta la estructura final, te acompañamos para que tu proyecto tome forma con solidez y originalidad.",
                IconoUrl = "/icons/consultoria.svg"
            },
            new ServicioModel
            {
                Id = 3,
                Titulo = "Redacción",
                Descripcion = "Damos forma a textos precisos y atractivos.",
                DescripcionLarga = "Creamos textos  que comunican con claridad y despiertan el interés de tus lectores."
                         + "Desde artículos y blogs hasta contenidos web y copys publicitarios, transformamos tus ideas en palabras que conectan y persuaden a tu público.",
                IconoUrl = "/icons/redaccion.svg"
            },
            new ServicioModel
            {
                Id = 4,
                Titulo = "Corrección",
                Descripcion = "Pulimos tu texto para que brille.",
                DescripcionLarga = "Pulimos tu texto para que brille."
                         + "Aseguramos fluidez, claridad y coherencia, eliminando errores y mejorando la expresión." + "Tu mensaje será impecable y profesional, listo para cautivar a tu audiencia.",
                IconoUrl = "/icons/correccion.svg"
            },
            new ServicioModel
            {
                Id = 4,
                Titulo = "Diseño editorial",
                Descripcion = "Maquetamos tu obra con criterios visuales profesionales.",
                DescripcionLarga = "Maquetamos tu obra con criterios visuales profesionales."
                         + "Creamos diseños atractivos y funcionales que realzan tu contenido." + "Desde libros a revistas, tu publicación tendrá una estética pulcra y coherente, impactando visualmente.",  
                IconoUrl = "/icons/diseno.svg"
            },
            new ServicioModel
            {
                Id = 5,
                Titulo = "Publicación",
                Descripcion = "Te acompañamos en la publicación impresa o digital.",
                DescripcionLarga = "Te acompañamos en la publicación impresa o digital."
                         + "Gestionamos cada detalle para que tu obra vea la luz." + "Desde el ISBN hasta la distribución, aseguramos que tu trabajo llegue a manos de tus lectores, sea cual sea el formato.",
                IconoUrl = "/icons/publicacion.svg"
            },
            new ServicioModel
            {
                Id = 6,
                Titulo = "Gestión de proyectos de comunicación",
                Descripcion = "Planificamos y coordinamos cada etapa con visión estratégica.",
                DescripcionLarga = "Coordinamos integralmente las iniciativas de comunicación de tu organización."
                         + "Planificamos, ejecutamos y supervisamos cada etapa para asegurar resultados exitosos." + "Optimizamos recursos, tareas y tiempos, garantizando una estrategia comunicacional coherente y eficaz.",
                IconoUrl = "/icons/gestion.svg"
            },
            
        };

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