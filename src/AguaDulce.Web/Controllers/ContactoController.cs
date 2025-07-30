using AguaDulce.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace AguaDulce.Web.Controllers
{
    public class ContactoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new ContactoFormModel
            {
                Nombre = string.Empty,
                Email = string.Empty,
                Mensaje = string.Empty
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Enviar(ContactoFormModel model)
        {
            if (!ModelState.IsValid)
                return View("Index", model);

            try
            {
                var fromAddress = new MailAddress("tucorreo@gmail.com", model.Nombre);
                var toAddress = new MailAddress("destinatario@gmail.com", "AguaDulce");
                //const string fromPassword = "tu_contraseña";
                string subject = "Contacto desde AguaDulce";
                string body = $"De: {model.Nombre} ({model.Email})\n\n{model.Mensaje}";

//#if DEBUG
                var smtp = new SmtpClient
                {
                    Host = "localhost",
                    Port = 25,
                    EnableSsl = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = true
                };
//#else
//var smtp = new SmtpClient
//{
//    Host = "smtp.gmail.com",
//    Port = 587,
//    EnableSsl = true,
//    DeliveryMethod = SmtpDeliveryMethod.Network,
//    UseDefaultCredentials = false,
//    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
//};
//#endif

                using var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                };

                smtp.Send(message);
                //Console.WriteLine("Correo simulado enviado exitosamente:");
                //Console.WriteLine(body);


                TempData["Nombre"] = model.Nombre;
                TempData["Email"] = model.Email;
                TempData["Exito"] = $"¡Gracias, {model.Nombre}! Hemos recibido tu mensaje. Te responderemos pronto a {model.Email}.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"Error al enviar el correo: {ex.Message}");
                return View("Index", model);
            }
        }
    }
}