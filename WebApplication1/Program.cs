using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(otp =>
            {
                otp.UseSqlServer(builder.Configuration.GetConnectionString("MSSQL"));
            });
            var app = builder.Build();
            app.UseRouting();
            app.UseStaticFiles();
            
            app.MapControllerRoute(name: "areas",pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");
            app.MapControllerRoute(name:"default",pattern:"{controller=Home}/{action=Index}/{id?}");
            app.MapControllerRoute(name: "Login_Register",pattern: "Login_Register",defaults:new {Controller="Home",Action= "Login_Register" });
            app.MapControllerRoute(name: "Cart", pattern: "Cart", defaults: new { Controller = "Home", Action = "Cart" });
            app.MapControllerRoute(name: "Index", pattern: "Index", defaults: new { Controller = "Home", Action = "Index" });
            app.MapControllerRoute(name: "Index2", pattern: "Index2", defaults: new { Controller = "Home", Action = "Index2" });
            app.MapControllerRoute(name: "Shop", pattern: "Shop", defaults: new { Controller = "Home", Action = "Shop" });
            app.MapControllerRoute(name: "Single_Product", pattern: "Single_Product", defaults: new { Controller = "Home", Action = "Single_Product" });
            app.Run();
        }
    }
}