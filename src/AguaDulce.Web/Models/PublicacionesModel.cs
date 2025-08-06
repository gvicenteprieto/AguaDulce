namespace AguaDulce.Web.Models
{
    public class PublicacionModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = "";
        
        public string Descripcion  { get; set; } = "";
        public string Subtitulo { get; set; } = "";
        public string ImagenUrl { get; set; } = "";
        public string Pie { get; set; } = "";
        public string Contenido { get; set; } = "";
    }
}