using Microsoft.EntityFrameworkCore;
namespace MudBlazor.Cakes.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
  public DbSet<Cake> Cakes { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Cake>().HasData(
      new Cake
      {
        Id = 1,
        Name = "Bolo de banana",
        Description = "Bolo de banana",
        Price = 23.00m,
        ImageUrl = "Images/bolo_banana.jpg"
      },
      new Cake
      {
        Id = 2,
        Name = "Bolo de Brigadeiro",
        Description = "Bolo de brigadeiro",
        Price = 31.50m,
        ImageUrl = "Images/bolo_brigadeiro.jpg"
      },
      new Cake
      {
        Id = 3,
        Name = "Bolo de Chocolate",
        Description = "Bolo de Chocolate",
        Price = 41.00m,
        ImageUrl = "Images/bolo_chocolate.jpg"
      },
      new Cake
      {
        Id = 4,
        Name = "Bolo de Laranja",
        Description = "Bolo de laranja",
        Price = 35.00m,
        ImageUrl = "Images/bolo_laranja.webp"
      }
    );
  }
}
