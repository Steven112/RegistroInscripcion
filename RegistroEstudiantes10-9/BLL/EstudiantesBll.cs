using System;
using RegistroEstudiantes10_9.Entidades;
using RegistroEstudiantes10_9.DAL;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace RegistroEstudiantes10_9.BLL
{
    public class EstudiantesBLL
    {
        public static bool Guardar(Estudiantes estudiante)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Estudiante.Add(estudiante) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
        public static bool  Modificar(Estudiantes estudiante)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(estudiante).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
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
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Estudiante.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
       public static bool GuardaryBuscar(int id,int balance)
        {
            bool paso = false;
            Estudiantes estudent = new Estudiantes();
            Contexto db = new Contexto();

            try
            {
                Buscar(id);
                balance = estudent.Balance;
                db.Entry(estudent).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0); 
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;


        } 
        public static Estudiantes Buscar(int id)
        {

            Contexto db = new Contexto();
            Estudiantes estudiante = new Estudiantes();

            try { 
                estudiante = db.Estudiante.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return estudiante;
            
        }

        public static List<Estudiantes> GetList(Expression<Func<Estudiantes, bool>>estudiante)
        {
            List<Estudiantes> Lista = new List<Estudiantes>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Estudiante.Where(estudiante).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }
    }
}
