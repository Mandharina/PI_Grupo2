using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Grupo2.Entidades
{
    public class E_Socio : E_Cliente
    {
        public DateTime FechaIngreso { get; set; }
        public DateTime VencCuota { get; set; }
        public bool EsActivo { get; set; } = true;
        public bool CarnetEntregado { get; set; } = true;

        public E_Socio() { }

        public E_Socio(string? nombre, string? apellido, int dni, DateTime fechaNac,
                     string? genero, string? numCel, string? domicilio, bool aptoFisico,
                     DateTime fechaIngreso, DateTime vencCuota, bool esActivo = true, bool carnetEntregado = true)
            : base(nombre, apellido, dni, fechaNac, genero, numCel, domicilio, aptoFisico)
        {
            FechaIngreso = fechaIngreso;
            VencCuota = vencCuota;
            EsActivo = esActivo;
            CarnetEntregado = carnetEntregado;
        }
    }
}
