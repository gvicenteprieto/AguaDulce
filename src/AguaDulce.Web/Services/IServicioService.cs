using AguaDulce.Web.Models;

namespace AguaDulce.Web.Services
{
    public interface IServicioService
    {
        List<ServicioModel> ObtenerServicios();
        ServicioModel? ObtenerServicioPorId(int id);
    }
}