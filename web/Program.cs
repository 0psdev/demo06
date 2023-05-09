using Microsoft.Extensions.Configuration;
using web.Services;
using web.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
var backend = "http://localhost:5179";
Uri convertedUri = new Uri(backend);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient<IWeatherForecastService, WeatherForecastService>(c => c.BaseAddress = new Uri("convertedUri"));

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
