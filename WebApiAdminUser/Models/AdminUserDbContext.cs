using Microsoft.EntityFrameworkCore;

namespace WebApiAdminUser.Models;

public class AdminUserDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-D84DF12\\SQLEXPRESS01;Database=Northwnd;Trusted_Connection=True;trustservercertificate=true");
    }

    public DbSet<AdminUser> AdminUsers { get; set; }
}
