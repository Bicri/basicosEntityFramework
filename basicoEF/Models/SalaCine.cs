using System.ComponentModel.DataAnnotations;

namespace basicoEF.Models;

public class SalaCine
{
    [Key]
    public int SalaId { get; set; }
    public decimal Precio { get; set; }

    public int CineId { get; set; }
    public Cine Cine { get; set; } = null!;
}
