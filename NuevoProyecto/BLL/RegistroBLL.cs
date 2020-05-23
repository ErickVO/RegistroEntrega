using Microsoft.EntityFrameworkCore;
using NuevoProyecto.DAL;
using NuevoProyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuevoProyecto.BLL
{
    public class RegistroBLL
    {
        public static bool Guardar(Datos datos)
        {
            if (!Existe(datos.Id))
            {
                return Insertar(datos);
            }
            else 
            {
                return Modificar(datos);
            }

           
        } 


        private static bool Insertar(Datos datos)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                db.Datos.Add(datos);
                paso = (db.SaveChanges() > 0);
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        private static bool Modificar (Datos datos)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                db.Entry(datos).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        
        }

        public static bool Eliminar(int id)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                var datos = db.Datos.Find(id);

                if(datos != null)
                {
                    db.Datos.Remove(datos);
                    paso = (db.SaveChanges() > 0);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose(); 
            }

            return paso;
        }


        public static bool Existe(int id)
        {
            Contexto db = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = db.Datos.Any(d => d.Id == id);
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return encontrado;
        }




    }
}
