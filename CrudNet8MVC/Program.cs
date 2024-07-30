<<<<<<< HEAD
using CrudNet8MVC.Datos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


//configuracion de la conexion a sql ser local 

builder.Services.AddDbContext<ApplicationDbContext>(opciones => 
opciones.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSql")));

=======
var builder = WebApplication.CreateBuilder(args);

>>>>>>> dbce2f87d8fe0341d40dd48142a024f637aae2e6
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
