using System;

namespace Web.ej1;

public class Persona
{
    public string Name { get; set; }

    public string GetSaludo()
    {
        return $"Hola! Mi nombre es {Name}";
    }

    public static List<string> GetName (List<Persona> personas){
        return personas.Select(p => p.Name).ToList();
    }

}
