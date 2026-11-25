using CursosApi.Models;
using CursosApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CursosApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CursosController : ControllerBase
{
    private readonly CursoService _servicio;

    public CursosController(CursoService servicio)
    {
        _servicio = servicio;
    }

    [HttpGet]
    public ActionResult<List<Curso>> Get() => Ok(_servicio.ObtenerTodos());

    [HttpGet("{id}")]
    public ActionResult<Curso> GetPorId(int id)
    {
        var curso = _servicio.ObtenerPorId(id);
        return curso == null ? NotFound() : Ok(curso);
    }

    [HttpPost]
    public ActionResult<Curso> Post(Curso curso)
    {
        var creado = _servicio.Agregar(curso);
        return CreatedAtAction(nameof(GetPorId), new { id = creado.Id }, creado);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Curso curso)
    {
        return _servicio.Actualizar(id, curso) ? NoContent() : NotFound();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return _servicio.Eliminar(id) ? NoContent() : NotFound();
    }
}