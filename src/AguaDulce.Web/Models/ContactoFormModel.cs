using System.ComponentModel.DataAnnotations;

namespace AguaDulce.Web.Models
{
    public class ContactoFormModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public required string Nombre { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "Email no válido")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "El mensaje no puede estar vacío")]
        public required string Mensaje { get; set; }
    }
}