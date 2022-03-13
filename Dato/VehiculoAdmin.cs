using Curso_ASP.NET_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Curso_ASP.NET_CRUD.Dato
{
    public class VehiculoAdmin
    {
        /// <summary>
        /// Consulta todos los vehiculos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<vehiculo> Consultar()
        {
            using(RepasoDnEntities contexto = new RepasoDnEntities())
            {
                return contexto.vehiculo.AsNoTracking().ToList();
            }
        }

        /// <summary>
        /// Guarda un vehiculo en la base de datos
        /// </summary>
        /// <param name="modelo"></param>
        public void Guardar(vehiculo modelo)
        {
            using(RepasoDnEntities contexto = new RepasoDnEntities())
            {
                contexto.vehiculo.Add(modelo);
                contexto.SaveChanges();
            }
        }

        /// <summary>
        /// Consultar vehiculo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public vehiculo Consultar(int id)
        {
            using (RepasoDnEntities contexto = new RepasoDnEntities())
            {
                return contexto.vehiculo.FirstOrDefault(v=>v.Id==id);
            }
        }

        /// <summary>
        /// Modifica los datos del vehiculo
        /// </summary>
        /// <param name="modelo"></param>
        public void Modificar(vehiculo modelo)
        {
            using(RepasoDnEntities contexto = new RepasoDnEntities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        /// <summary>
        /// Elimina un vehiculo
        /// </summary>
        /// <param name="modelo"></param>
        public void Eliminar(vehiculo modelo)
        {
            using (RepasoDnEntities contexto = new RepasoDnEntities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

    }
}