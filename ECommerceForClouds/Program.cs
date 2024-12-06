using BLL.Abstract_Services;
using BLL.Concrete_Services;
using BLL.MapperProfiles;
using DAL.Abstarct_Repositories;
using DAL.Concerete_Repositories;
using DAL.DATA;
using ECommerceForClouds.MapperProfilesForMVC;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IUserService),typeof(UserService));
builder.Services.AddScoped(typeof(IProductService),typeof(ProductService));
builder.Services.AddScoped(typeof(IUserBasketService),typeof(UserBasketService));
builder.Services.AddAutoMapper(typeof(AutoMapperProfile),typeof(AutoMapperProfileForUi));
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
