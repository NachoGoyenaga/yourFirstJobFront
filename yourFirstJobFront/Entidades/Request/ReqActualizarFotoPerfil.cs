﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourFirstJobFront.Entidades.Request
{
    public class ReqActualizarFotoPerfil
    {
        public int idUsuario { get; set; }
        public int idArchivo { get; set; }
        public byte[] archivo { get; set; }

    }
}
