using DAO;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSS
{
    public class TareaBussines
    {
        private TareaData tareaData= new TareaData();
        public void save(TareaEntity tarea)
        {
            try
            {
                if (tarea.DescripcionTarea.Length < 5)
                {
                    throw new Exception("La descripcion debe ser de al menos 5 caracteres.");
                }
                if (tarea.FechaTarea < DateTime.Today)
                {
                    throw new Exception("La fecha de validez es anterior a la fecha de hoy");
                }

                tarea.FechaRegistro = DateTime.Now;
                tareaData.save(tarea);

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
                return tareaData.getAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void eliminarTarea(int idTarea)
        {
            try
            {
                TareaEntity tarea = tareaData.getById(idTarea);
                if (tarea == null)
                {
                    throw new Exception("No existe la tarea indicada.");
                }
                tareaData.eliminarTarea(idTarea);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void modificar(int idTarea,string descripcion,DateTime nuevaFecha)
        {
            try
            {
                if (idTarea <= 0)
                {
                    throw new Exception("El ID debe ser mayor que cero");
                }

                if (descripcion.Length < 5)
                {
                    throw new Exception("La descripcion debe ser de al menos 5 caracteres.");
                }

                TareaEntity tareadb = tareaData.getById(idTarea);
                if (tareadb == null)
                {
                    throw new Exception("No existe la entrada indicada");
                }

                if (nuevaFecha.Date < DateTime.Now.Date)
                {
                    throw new Exception("No se permite ingresar una fecha anterior a la fecha actual");
                } 

                TareaEntity tarea = new TareaEntity
                {
                    Id = idTarea,
                    DescripcionTarea = descripcion,
                    FechaTarea = nuevaFecha
                };
                tareaData.modificarTarea(tarea);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
         
    }

}
