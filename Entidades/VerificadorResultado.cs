using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Grupo2.Entidades
{
    public class VerificadorResultado
    {
        public bool Existe { get; set; }
        public bool EsSocio { get; set; }
        public int? NumeroIdentificador { get; set; } // NroCarnet o NroNoSocio
    }
}
