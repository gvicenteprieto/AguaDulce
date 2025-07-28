namespace AguaDulce.Web.Models
{
    public class ServicioModel
    {
        public int Id { get; set; }

        // Asignamos valor por defecto para evitar CS8618
        public string Titulo { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public string DescripcionLarga { get; set; } = string.Empty;

        // Nueva propiedad para el icono
        public string IconoUrl { get; set; } = string.Empty;
    }
}