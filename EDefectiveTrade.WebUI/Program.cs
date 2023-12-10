using AutoMapper;
using EDefectiveTrade.Data;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddServices();
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(Mapper));



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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
