namespace AguaDulce.Web.Models
{
    public class ServicioModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string DetalleSeccion { get; set; } = string.Empty;
        // Cambiamos de string a una lista de secciones/items
        public required List<DescripcionSeccion> DescripcionLarga { get; set; }
    }

    public class DescripcionSeccion
    {
        public string Mensaje { get; set; } = string.Empty;
        public required List<string> Items { get; set; }
        public string TituloSeccion { get; set; } = string.Empty;
        public string Contenido { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
    }
}
//namespace AguaDulce.Web.Models
//{

//    // Modelo que representa un servicio ofrecido
//    public class ServicioModel
//    {
//        public int Id { get; set; }

//        [Required(ErrorMessage = "El título es obligatorio")]
//        [StringLength(100, ErrorMessage = "El título no puede exceder los 100 caracteres")]
//        public string Titulo { get; set; } = string.Empty;

//        [Required(ErrorMessage = "La descripción es obligatoria")]
//        public string Descripcion { get; set; } = string.Empty;

//        public string? DetalleSeccion { get; set; }

//        [Required(ErrorMessage = "La descripción larga es obligatoria")]
//        public List<DescripcionSeccion> DescripcionLarga { get; set; } = new();
//    }

//    // Modelo que representa una sección de descripción detallada
//    public class DescripcionSeccion
//    {
//        public string? Mensaje { get; set; }

//        [Required(ErrorMessage = "Los items son obligatorios")]
//        public List<string> Items { get; set; } = new();

//        public string? TituloSeccion { get; set; }

//        public string Contenido { get; set; } = string.Empty;

//        public string Link { get; set; } = string.Empty;
//    }
//}