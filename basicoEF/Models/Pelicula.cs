namespace basicoEF.Models;

public class Pelicula
{
    public int PeliculaId { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public DateTime FechaEstreno { get; set; }

    public List<Cine> Cines { get; set; } = new();
}
