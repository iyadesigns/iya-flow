using IYA.Flow.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using IYA.Flow.Application.Interfaces.Repositories;
using IYA.Flow.Infrastructure.Repositories;
using IYA.Flow.Application.Interfaces.Services;
using IYA.Flow.Application.Services;
using AutoMapper;
using IYA.Flow.Application.Mappings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//registrat DbContext with connection string from appsettings.json

builder.Services.AddDbContext<IYAFlowDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

//registrar repositorio
builder.Services.AddScoped<IWorkspaceRepository, WorkspaceRepository>();

//registrar servicio
builder.Services.AddScoped<IWorkspaceService, WorkspaceService>();

//registrar automapper
// Registers AutoMapper and scans the Application assembly
builder.Services.AddAutoMapper(typeof(WorkspaceProfile));

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

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");
app.Run();
