using basicoEF.Context;
using basicoEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace basicoEF.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BasicosController : ControllerBase
{
    private readonly AppDbContext _context;

    public BasicosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetPruebas()
    {
        Prueba prueba = new Prueba
        {
            Descripcion = "Prueba 1",
            Activo = true,
            Fecha = DateTime.Now
        };

        _context.Pruebas.Add(prueba);
        await _context.SaveChangesAsync();

        List<Prueba> pruebas = new()
        {
            new Prueba
            {
                Descripcion = "Prueba 2",
                Activo = true,
                Fecha = DateTime.Now
            },
            new Prueba
            {
                Descripcion = "Prueba 3",
                Activo = true,
                Fecha = DateTime.Now
            }
        };

        _context.Pruebas.AddRange(pruebas);
        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> PutPrueba()
    {
        Prueba p1 = await _context.Pruebas.FirstAsync(p => p.PruebaId == 1);

        p1.Descripcion = "Prueba 1 Modificada";
        await _context.SaveChangesAsync();

        List<Prueba> pruebas = await _context.Pruebas.Where(p => p.PruebaId != 1).ToListAsync();
        pruebas.ForEach(p => p.Descripcion = p.Descripcion + " Modified xd");
        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete]
    public async Task<IActionResult> DeletePrueba()
    {
        List<Prueba> pruebas = await _context.Pruebas.ToListAsync();
        _context.Pruebas.RemoveRange(pruebas);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
