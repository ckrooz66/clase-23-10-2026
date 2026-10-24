using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class TareaEntity
    {
        public int Id { get; set; }

        public DateTime FechaRegistro { get; set; }

        public string DescripcionTarea { get; set; } = null!;

        public DateTime FechaTarea { get; set; }
    }
}
