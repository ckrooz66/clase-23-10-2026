using System;
using System.Collections.Generic;

namespace ENTITIES.Models;

public  class Tarea
{
    public int Id { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string DescripcionTarea { get; set; } = null!;

    public DateTime FechaTarea { get; set; }
}
