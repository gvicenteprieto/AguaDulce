namespace AguaDulce.Web.Models
{
    //    public class ServicioModel
    //    {
    //        public int Id { get; set; }

    //        // Asignamos valor por defecto para evitar CS8618
    //        public string Titulo { get; set; } = string.Empty;

    //        public string Descripcion { get; set; } = string.Empty;

    //        public string DescripcionLarga { get; set; } = string.Empty;

    //        // Nueva propiedad para el icono
    //        public string IconoUrl { get; set; } = string.Empty;
    //    }
    //}

    public class ServicioModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string DetalleSeccion { get; set; } = string.Empty;// Opcional
        // Cambiamos de string a una lista de secciones/items
        public required List<DescripcionSeccion> DescripcionLarga { get; set; }
        //public string IconoUrl { get; set; } = string.Empty;
    }

    public class DescripcionSeccion
    {
        public string Mensaje { get; set; } = string.Empty;// Opcional
        public required List<string> Items { get; set; }
        public string TituloSeccion { get; set; } = string.Empty;// Opcional
        public string Contenido { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        //public required List<string> Items { get; set; } // Para listas con viñetas
    }
}