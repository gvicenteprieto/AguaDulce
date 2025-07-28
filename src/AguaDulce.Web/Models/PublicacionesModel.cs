//namespace AguaDulce.Web.Models
//{
//    public class PublicacionModel
//    {
//        // Identificador �nico para cada publicaci�n
//        public int Id { get; set; }

//        public required string Titulo { get; set; }
//        public required string Subtitulo { get; set; }
//        public required string ImagenUrl { get; set; }
//        public required string Pie { get; set; }

//        // Aqu� almacenas el cuerpo o contenido HTML/texto de la publicaci�n
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