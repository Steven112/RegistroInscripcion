﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroEstudiantes10_9.Entidades;
using System.Data.Entity;

namespace RegistroEstudiantes10_9.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Estudiantes> Estudiante { get; set; }
        public DbSet<Inscripciones> Inscripcion { get; set; }

        public Contexto(): base("ConStr")
        {

        }

    }
}
