using AutoMapper;
using EDefectiveTrade.Business.Validators.Authenticate;
using EDefectiveTrade.Data.DAL;
using EDefectiveTrade.WebUI.Extentions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddServices();
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(Mapper));
//builder.Services.AddValidatorsFromAssemblyContaining<LoginDtoValidator>();

//builder.Services.AddFluentValidation(conf =>
//{
//    conf.RegisterValidatorsFromAssembly(typeof(Program).Assembly);
//    conf.AutomaticValidationEnabled = false;
//});
//builder.Services.AddDbContext<AppDbContext>(opts => {

//    opts.UseSqlServer(builder.Configuration.GetConnectionString("SQLServerConnStr"));
//});

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
