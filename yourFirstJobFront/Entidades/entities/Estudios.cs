﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourFirstJobFront.Entidades.entities
{
    public class Estudios
    {
        public int idEstudios { get; set; }
        // public Usuario usuario { get; set; }
        public string nombreInstitucion { get; set; }
        public string gradoAcademico { get; set; }
        //   public Profesion profesion { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinalizacion { get; set; }
    }
}
