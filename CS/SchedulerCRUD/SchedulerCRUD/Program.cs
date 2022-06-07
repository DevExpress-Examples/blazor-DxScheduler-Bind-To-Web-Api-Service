using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SchedulerCRUD.Data;
using DevExpress.Blazor;
using DevExpress.Blazor.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddDevExpressBlazor();
builder.Services.AddDevExpressBlazor(configure => configure.BootstrapVersion = BootstrapVersion.v5);

builder.Services.AddHttpClient();
// Server Side Blazor doesn't register HttpClient by default

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

//app.UseEndpoints(endpoints => {
//    endpoints.MapControllers();

//    endpoints.MapFallbackToPage("/_Host");
//});

app.Run();
