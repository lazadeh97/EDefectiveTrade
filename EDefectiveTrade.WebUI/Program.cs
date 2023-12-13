using AutoMapper;
using EDefectiveTrade.Business.Profiles;
using EDefectiveTrade.Business.Services.Implementations;
using EDefectiveTrade.Business.Services.Interfaces;
using EDefectiveTrade.Business.Validators.Authenticate;
using EDefectiveTrade.Core.Interfaces;
using EDefectiveTrade.Data.DAL;
using EDefectiveTrade.Data.Implementations;
using EDefectiveTrade.WebUI.Extentions;
using Microsoft.EntityFrameworkCore;
using FluentValidation.AspNetCore;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServices();
builder.Services.AddControllersWithViews();

builder.Services.AddAutoMapper(typeof(CustomMapper));

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));
builder.Services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
builder.Services.AddScoped<IProductCategoryService, ProductCategoryService>();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();


builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddValidatorsFromAssembly(typeof(LoginDtoValidator).Assembly);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();




app.MapControllerRoute(
    name: "areas",
     pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
