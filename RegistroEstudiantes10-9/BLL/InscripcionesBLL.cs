using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroEstudiantes10_9.DAL;
using RegistroEstudiantes10_9.Entidades;
using System.Linq.Expressions;
using System.Data.Entity;


namespace RegistroEstudiantes10_9.BLL
{
    public class InscripcionesBLL
    {
        public static bool Guardar(Inscripciones inscripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Inscripcion.Add(inscripcion) != null)
                    db.Estudiante.Find(inscripcion.EstudianteId).Balance += inscripcion.Balance;
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

        public static Inscripciones Buscar(int id)
        {

            Contexto db = new Contexto();
            Inscripciones estudiante = new Inscripciones();

            try
            {
                estudiante = db.Inscripcion.Find(id);
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

        public static bool Modificar(Inscripciones inscripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                Inscripciones InscrAnt = Buscar(inscripcion.IncripcioId);
                int resultado = inscripcion.Balance - InscrAnt.Balance;

                var Estudiante = db.Estudiante.Find(inscripcion.EstudianteId);
                Estudiante.Balance += resultado;
                EstudiantesBLL.Modificar(Estudiante);
                db.Entry(inscripcion).State = EntityState.Modified;
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
                var eliminar = db.Inscripcion.Find(id);
                db.Estudiante.Find(eliminar.EstudianteId).Balance -= eliminar.Balance;
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

        public static List<Inscripciones> GetList(Expression<Func<Inscripciones, bool>> inscripcion)
        {
            List<Inscripciones> Lista = new List<Inscripciones>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Inscripcion.Where(inscripcion).ToList();
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

        public static int CBalance(int monto, int deposito)
        {
            int resultado = 0;
            resultado = monto - deposito;

            return resultado;
        }

    }
}
