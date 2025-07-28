//namespace AguaDulce.Web.Models
//{
//    public class PublicacionModel
//    {
//        // Identificador único para cada publicación
//        public int Id { get; set; }

//        public required string Titulo { get; set; }
//        public required string Subtitulo { get; set; }
//        public required string ImagenUrl { get; set; }
//        public required string Pie { get; set; }

//        // Aquí almacenas el cuerpo o contenido HTML/texto de la publicación
//        public string Contenido { get; set; } = string.Empty;
//    }
//}

namespace AguaDulce.Web.Models
{
    public class PublicacionModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = "";
        public string Subtitulo { get; set; } = "";
        public string ImagenUrl { get; set; } = "";
        public string Pie { get; set; } = "";
        public string Contenido { get; set; } = "";
    }
}