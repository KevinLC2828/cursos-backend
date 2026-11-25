# Gestión de Cursos - Backend (API)

API REST en ASP.NET Core Web API para consultar, registrar, actualizar y eliminar cursos usando una lista en memoria.
Proyecto integrador del primer parcial de **Desarrollo de Aplicaciones Web Avanzado**.

## Integrantes
- Kevin Lozada
- Andrea de los Angeles Moreira

## Estructura
- `Models/Curso.cs`: entidad con Id, Nombre, Docente y Activo
- `Services/CursoService.cs`: lista en memoria y operaciones CRUD
- `Controllers/CursosController.cs`: endpoints, con el servicio inyectado
- `Program.cs`: registro del servicio con `AddSingleton`

## Endpoints
| Método | Ruta | Descripción |
|---|---|---|
| GET | `/api/cursos` | Lista todos los cursos |
| GET | `/api/cursos/{id}` | Obtiene un curso por id |
| POST | `/api/cursos` | Crea un curso |
| PUT | `/api/cursos/{id}` | Actualiza un curso |
| DELETE | `/api/cursos/{id}` | Elimina un curso |

Ejemplo de cuerpo para POST y PUT:
```json
{
  "nombre": "Redes de Computadoras",
  "docente": "Ing. Ruiz",
  "activo": true
}
```

## Requisitos
- .NET SDK

## Cómo ejecutarlo
```bash
dotnet run
```
La API queda en http://localhost:5210

Los datos se guardan en memoria: al reiniciar la API vuelven a los 3 cursos iniciales.

## Repositorio del frontend
https://github.com/KevinLC2828/cursos-frontend