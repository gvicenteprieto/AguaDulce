using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// 1. Registrar servicios MVC
builder.Services.AddControllersWithViews();

// 2. Opcional: escuchar HTTP en cualquier IP puertos 5062
//    Así evitas problemas de Firewall/Defender al exponerlo en otra máquina.
builder.WebHost.UseUrls("http://*:5062");

var app = builder.Build();

// 3. Inyección de cabeceras seguras sin riesgo de duplicados
app.Use(async (context, next) =>
{
    context.Response.Headers["Cache-Control"] = "no-store";
    await next();
});

// 4. No redirigir a HTTPS en local/desarrollo
//    (si algún día quieres HTTPS en producción, mueve esto bajo un if)
// app.UseHttpsRedirection();

// 5. Static files, routing y endpoint MVC
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();