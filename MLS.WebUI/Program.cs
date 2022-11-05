using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MLS.Infrastructure;
using MLS.WebUI.Models.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddIdentity<AppUser,AppIdentityRole>(i=>
{
    i.User.RequireUniqueEmail = true;
    //c.User.AllowedUserNameCharacters = "qwertyuiopasdfghjklzxcvbnmPOIUYTREWQLKJHGFDSAMNBVCXZ";
    i.Password.RequireDigit = false;
    i.Password.RequiredLength = 6;
    i.Password.RequireNonAlphanumeric = false;
    i.Password.RequireUppercase = false;
    i.Password.RequiredUniqueChars = 1;
    i.Password.RequireLowercase = false;
}).AddEntityFrameworkStores<UserDbContext>();

builder.Services.AddDbContext<UserDbContext>(c =>
c.UseSqlServer(builder.Configuration.GetConnectionString("AppIdentity")));

builder.Services.AddScoped<IPasswordValidator<AppUser>, AppPasswordValidator>();
builder.Services.AddScoped<IUserValidator<AppUser>, AppUserValidator>();    

var connectionString = builder.Configuration.GetConnectionString("MLSdb");
ConfigureServices.Configure(builder.Services, connectionString);



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

app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
