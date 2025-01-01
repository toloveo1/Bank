using Microsoft.EntityFrameworkCore;
using Bank.Models;

var builder = WebApplication.CreateBuilder(args);

// Agregar configuración para el DbContext
builder.Services.AddDbContext<BankDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// aqui metemos las cookies para la autenticacion
builder.Services.AddAuthentication("CookieAuth")
    .AddCookie("CookieAuth", options =>
    {
        options.LoginPath = "/Account/Login"; // aqui la ruta donde el usuario será redirigido si no está autenticado
    });

// Agregar servicios de controladores
builder.Services.AddControllers();

var app = builder.Build();

// Configuración del pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    /* ahora tiene 30 dias por defecto hsts. cambiar el valor a 365 dias con:
    
     if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(hsts => hsts.MaxAge(TimeSpan.FromDays(365)));
}*/

    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Activar autenticación y autorización en el middleware
app.UseAuthentication(); // verifica si el usuario ha iniciado sesión
app.UseAuthorization();  //Esto aplica las restricciones de acceso a los endpoints

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
