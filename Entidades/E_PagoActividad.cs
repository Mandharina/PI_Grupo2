using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Grupo2.Entidades
{
    public class E_PagoActividad
    {
        public int NoSocio { get; set; }
        public int Actividad { get; set; }
        public double Monto { get; set; }
        public DateTime FechaPago { get; set; }
    }
}
