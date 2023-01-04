using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-V540I6U\\SQLEXPRESS;Database=Pronia;Trusted_Connection=True;Encrypt=falce");
        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Login_Register> Login_Registers { get; set; }
        public DbSet<Shop> Shops { get; set; }
    }
}
