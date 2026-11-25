using CursosApi.Models;

namespace CursosApi.Services;

public class CursoService
{
    private readonly List<Curso> _cursos = new()
    {
        new Curso { Id = 1, Nombre = "Desarrollo Web Avanzado", Docente = "Ing. Pérez", Activo = true },
        new Curso { Id = 2, Nombre = "Base de Datos", Docente = "Ing. Gómez", Activo = true },
        new Curso { Id = 3, Nombre = "Programación Orientada a Objetos", Docente = "Ing. Torres", Activo = false }
    };

    private int _siguienteId = 4;

    public List<Curso> ObtenerTodos() => _cursos;

    public Curso? ObtenerPorId(int id) => _cursos.FirstOrDefault(c => c.Id == id);

    public Curso Agregar(Curso curso)
    {
        curso.Id = _siguienteId++;
        _cursos.Add(curso);
        return curso;
    }

    public bool Actualizar(int id, Curso curso)
    {
        var existente = ObtenerPorId(id);
        if (existente == null) return false;

        existente.Nombre = curso.Nombre;
        existente.Docente = curso.Docente;
        existente.Activo = curso.Activo;
        return true;
    }

    public bool Eliminar(int id)
    {
        var curso = ObtenerPorId(id);
        if (curso == null) return false;

        _cursos.Remove(curso);
        return true;
    }
}