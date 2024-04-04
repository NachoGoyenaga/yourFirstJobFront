﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourFirstJobFront.Entidades.entities
{
    public class Empresa
    {
        public int idEmpresa { get; set; }
        public string nombreEmpresa { get; set; }
        public int telefonoEmpresa { get; set; }
        public int cedulaJuridica { get; set; }
        public Region region { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaRegistro { get; set; }
        public Boolean estado { get; set; }


    }
}
