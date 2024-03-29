using Portafolio.Models.Interfaces;
using Portafolio.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IRepositorioProyectos, RepositorioProyectos>();
builder.Services.AddTransient<IServicioEmail, ServicioEmailSendGrid>();

//builder.Services.AddTransient<ServicioTransitorio>(); 
//builder.Services.AddScoped<ServicioDeLimitado>(); //tiempo de vida: siempre se va a conservar
//builder.Services.AddSingleton<ServicioUnico>(); //una unica vez



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
