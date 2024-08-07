using basicoEF.Models;
using Microsoft.EntityFrameworkCore;

namespace basicoEF.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Prueba> Pruebas { get; set; }
    public DbSet<Cine> Cines { get; set; }
    public DbSet<CineOferta> CineOfertas { get; set; }
    public DbSet<Pelicula> Peliculas { get; set; }
}
