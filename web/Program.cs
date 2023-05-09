using Microsoft.Extensions.Configuration;
using web.Services;
using web.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
var backendurl = Environment.GetEnvironmentVariable("backendserver");

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient<IWeatherForecastService, WeatherForecastService>(c => c.BaseAddress = new Uri("backendurl"));

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
