using Microsoft.AspNetCore.Mvc;
using AguaDulce.Web.Models;

namespace AguaDulce.Web.Controllers
{
    [Route("[controller]")]
    public class ContactoController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("Enviar")]
        [ValidateAntiForgeryToken]
        public IActionResult Enviar(ContactoFormModel modelo)
        {
            if (!ModelState.IsValid)
                return View("Index", modelo);

            // TODO: Procesar los datos del formulario (email, guardar en DB, etc.)

            TempData["MensajeEnviado"] = "Gracias por contactarnos. Te responderemos a la brevedad.";
            return RedirectToAction(nameof(Index));
        }
    }
}