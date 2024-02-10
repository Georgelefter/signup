using Microsoft.EntityFrameworkCore;
using PrimaWeb.Models;

public class dbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=database.db");

    public DbSet<Registrazione> Registrazioni{ get ; set; }
}