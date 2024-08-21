using System;
using Microsoft.AspNetCore.Mvc;
using Web.ej1;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Ej1Controller : ControllerBase
{
    
    private static List<Persona> personas = new List<Persona>
    {
        new Persona { Name = "Pedro" },
        new Persona { Name = "Luis" },
        new Persona { Name = "Jose" }
    };

   
    [HttpGet("nombres")]
    public ActionResult<List<string>> GetNombrePersona()
    {
        var nombres = personas.Select(p => p.Name).ToList();
        return Ok(nombres);
    }

    
    [HttpGet("saludos")]
    public ActionResult<List<string>> GetSaludoPersona()
    {
        var saludos = personas.Select(p => p.GetSaludo()).ToList();
        return Ok(saludos);
    }
}