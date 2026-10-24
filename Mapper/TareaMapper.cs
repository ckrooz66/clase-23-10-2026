using ENTITIES;
using ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class TareaMapper
    {
        public static TareaEntity MapToEntity(Tarea tarea)
        {
            return new TareaEntity
            {
                Id = tarea.Id,
                FechaRegistro = tarea.FechaRegistro,
                DescripcionTarea = tarea.DescripcionTarea,
                FechaTarea = tarea.FechaTarea
            };
        }

        public static List<TareaEntity> Map(List<Tarea> tareas)
        {
            List<TareaEntity> tareasEntity = new List<TareaEntity>();
            foreach (var tarea in tareas)
            {
                tareasEntity.Add(MapToEntity(tarea));
            }
            return tareasEntity;
        }

        public static Tarea Map(TareaEntity tareaEntity)
        {
            return new Tarea
            {
                Id = tareaEntity.Id,
                FechaRegistro = tareaEntity.FechaRegistro,
                DescripcionTarea = tareaEntity.DescripcionTarea,
                FechaTarea = tareaEntity.FechaTarea
            };
        }
    }
}
