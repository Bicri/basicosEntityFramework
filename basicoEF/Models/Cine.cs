using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace basicoEF.Models;

[Table("Cine")]
public class Cine
{
    [Key]
    public int CineId { get; set; }
    public string NombreCine { get; set; } = string.Empty;

    public CineOferta? CineOferta { get; set; }

    public List<SalaCine> SalasCine { get; set; } = new List<SalaCine>();

    public List<Pelicula> Peliculas { get; set; }
}
