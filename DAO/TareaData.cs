using DAO.Models;
using ENTITIES;
using ENTITIES.Models;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TareaData
    {
        public void eliminarTarea(int idTarea)
        {
            try
            {
                using (var db = new ModeloTareaContext())
                {
                    Tarea tarea = db.Tareas.FirstOrDefault(e => e.Id == idTarea);
                    if (tarea != null)
                    {
                        db.Tareas.Remove(tarea);
                        db.SaveChanges();
                    }
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public TareaEntity getById(int idTarea)
        {
            try
            {
                using (var db = new ModeloTareaContext())
                {
                    Tarea tarea = db.Tareas.FirstOrDefault(e => e.Id == idTarea);
                    if(tarea!=null) return TareaMapper.MapToEntity(tarea);
                    else return null;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void modificarTarea(int idTarea,string descripcion,DateTime fechaTarea)
        {
            try
            {
                using (var db = new ModeloTareaContext())
                {
                    Tarea tarea = db.Tareas.FirstOrDefault(e => e.Id == idTarea);
                    if (tarea != null)
                    {
                        tarea.FechaTarea = fechaTarea;
                        db.SaveChanges();
                    }
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<TareaEntity> getAll()
        {
            try
            {
                using (var db = new ModeloTareaContext())
                {
                    List<Tarea> tareas = db.Tareas.ToList();
                    return TareaMapper.Map(tareas);
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
  

        public void save(TareaEntity tarea)
        {
            try
            {
                using (var db = new ModeloTareaContext())
                {
                    Tarea nuevaTarea = TareaMapper.Map(tarea);
                    db.Tareas.Add(nuevaTarea);
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
