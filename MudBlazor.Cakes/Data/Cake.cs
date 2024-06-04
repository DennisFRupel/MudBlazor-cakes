using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MudBlazor.Cakes.Data;

public class Cake
{
  public int Id { get; set; }
  [MaxLength(200)]
  public string? Name { get; set; }
  [MaxLength(300)]
  public string? Description { get; set; }
  [MaxLength(200)]
  public string? ImageUrl { get; set; }
  [Column(TypeName = "decimal(10,2)")]
  public decimal Price { get; set; }
}
