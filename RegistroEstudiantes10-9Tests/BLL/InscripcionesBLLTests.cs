using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroEstudiantes10_9.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroEstudiantes10_9.Entidades;

namespace RegistroEstudiantes10_9.BLL.Tests
{
    [TestClass()]
    public class InscripcionesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;

            Inscripciones inscripcion = new Inscripciones();
            inscripcion.IncripcioId = 4;
            inscripcion.Fecha = DateTime.Now;
            inscripcion.EstudianteId = 2;
            inscripcion.Comentario = "Nada";
            inscripcion.Monto = 10;
            inscripcion.Deposito = 5;
            inscripcion.Balance = (inscripcion.Monto - inscripcion.Deposito);
            paso = InscripcionesBLL.Guardar(inscripcion);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso = false;
            Inscripciones inscripcion = new Inscripciones();
            inscripcion = InscripcionesBLL.Buscar(1);
            if (inscripcion != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            
            Inscripciones inscripcion = new Inscripciones();
            inscripcion.IncripcioId = 2;
            inscripcion.Fecha = DateTime.Now;
            inscripcion.EstudianteId = 2;
            inscripcion.Comentario = "True";
            inscripcion.Monto = 10;
            inscripcion.Deposito = 8;
            inscripcion.Balance = (inscripcion.Monto - inscripcion.Deposito);
            paso = InscripcionesBLL.Guardar(inscripcion);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;

            Inscripciones inscripcion = new Inscripciones();
            inscripcion.IncripcioId = 2;
            paso = InscripcionesBLL.Eliminar(inscripcion.IncripcioId);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CBalanceTest()
        {
            Assert.Fail();
        }
    }
}