using System.Globalization;
using HastahaneIU.Extensions;
using HastahaneIU.Infratructer.Mapper;
using Microsoft.AspNetCore.Localization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();
builder.Services.AddControllersWithViews();

builder.Scoped();
builder.Services.AddAutoMapper(typeof(MapProfile).Assembly);
builder.Services.MapperScoped();
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

app.UseAuthentication();
app.UseAuthorization();

app.UseSession();
app.UseAuthorization();

     app.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Home}/{action=Index}/{id?}");
        
     app.MapAreaControllerRoute(
        name: "Personal",
        areaName: "Personal",
        pattern: "Personal/{controller=Home}/{action=Index}/{id?}");

    app.MapControllerRoute(name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();