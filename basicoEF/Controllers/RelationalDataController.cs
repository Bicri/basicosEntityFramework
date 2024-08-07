using basicoEF.Context;
using basicoEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace basicoEF.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RelationalDataController : ControllerBase
{
    private readonly AppDbContext _context;

    public RelationalDataController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("obtenerPeliculas")]
    public async Task<IActionResult> GetPeliculas()
    {
        List<Pelicula> peliculas = await _context.Peliculas
                                    .Include(p => p.Cines)
                                    .ToListAsync();

        //List<Cine> cines = await _context.Entry(peliculas[0]).Collection(p => p.Cines).Query().ToListAsync();
        return Ok(peliculas);
    }
}
