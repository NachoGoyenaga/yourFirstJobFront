﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourFirstJobFront.Entidades.entities
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string apellidos { get; set; }
        public string correo { get; set; }
        public int telefono { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public int idRegion { get; set; }
        public string contrasena { get; set; }
        public string sitioWeb { get; set; }
        public DateTime fechaRegistro { get; set; }
        public Boolean estado { get; set; }

        public Region region { get; set; }

        //agregar listas

        public List<Idiomas> listaIdiomas { get; set; }

        public List<Habilidades> listaHabilidades { get; set; }

        public List<Estudios> listaEstudios { get; set; }

        public List<ArchivosUsuario> listaArchivosUsuarios { get; set; }

        public List<ExperienciaLaboral> listaExperienciaLaboral { get; set; }

    }
}
