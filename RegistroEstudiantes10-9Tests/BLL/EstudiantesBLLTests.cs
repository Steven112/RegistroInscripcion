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
    public class EstudiantesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudianteId = 0;
            estudiante.Matricula = "2017-0605";
            estudiante.Nombres = "Steven";
            estudiante.Apellidos = " Caceres";
            estudiante.Cedula = "6486846";
            estudiante.Telefono = "68464684";
            estudiante.Celular = "jyghhgh";
            estudiante.FechaNacimiento = DateTime.Now;
            estudiante.Sexo = "Masculino";
            estudiante.Balance = 0;
            paso = EstudiantesBLL.Guardar(estudiante);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudianteId = 3;
            estudiante.Matricula = "2011-9999";

            paso = EstudiantesBLL.Modificar(estudiante);
            Assert.AreEqual(paso, true); 
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudianteId = 3;


            paso = EstudiantesBLL.Eliminar(estudiante.EstudianteId);
            Assert.AreEqual(paso, true);
        }

        

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso = false;
            Estudiantes estudiante = new Estudiantes();
            estudiante = EstudiantesBLL.Buscar(3);
            if (estudiante != null)
                paso = true;
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}