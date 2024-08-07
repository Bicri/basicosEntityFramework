using System.ComponentModel.DataAnnotations;

namespace basicoEF.Models;

public class Prueba
{
    [Key]
    public int PruebaId { get; set; }
    public string? Descripcion { get; set; }
    public bool Activo { get; set; } = true;
    public DateTime Fecha { get; set; }
}
