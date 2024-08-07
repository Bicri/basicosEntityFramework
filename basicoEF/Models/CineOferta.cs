using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace basicoEF.Models;

[Table("CineOferta")]
public class CineOferta
{
    [Key]
    public int CineOfertaId { get; set; }
    public string NombreOferta { get; set; } = string.Empty;
    public decimal Descuento { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }

    //Llave foranea
    public int CineId { get; set; }
}
