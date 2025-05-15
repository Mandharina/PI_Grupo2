using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PI_Grupo2
{
    internal class Cliente
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string genero;
        private int numCel;
        private DateTime fechaNac;
        private string domicilio;
        private bool apto;

        public Cliente(string nombre, string apellido, int dni,string genero, int numCel, DateTime fechaNac, string domicilio, bool apto)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.genero = genero;
            this.numCel = numCel;
            this.fechaNac = fechaNac;
            this.domicilio = domicilio;
            this.apto = apto;
            
        }

        //para buscar cliente al realizar el pago
        public int getDni()
        {
            return dni;
        }

    }
}