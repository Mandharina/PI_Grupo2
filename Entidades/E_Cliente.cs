using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Grupo2.Entidades
{
    public class E_Cliente
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Dni { get; set; }
        public DateTime Fecha_nac { get; set; }
        public string? Genero { get; set; }
        public string? NumCel { get; set; }
        public string? Domicilio { get; set; }
        public int NroCarnet { get; set; }
    }
}
