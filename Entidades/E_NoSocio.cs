namespace PI_Grupo2.Entidades
{
    public class E_NoSocio : E_Cliente
    {
        public int NroNoSocio { get; set; }

        public E_NoSocio() { }

        public E_NoSocio(string? nombre, string? apellido, int dni, DateTime fechaNac,
                       string? genero, string? numCel, string? domicilio, bool aptoFisico,
                       int nroNoSocio)
            : base(nombre, apellido, dni, fechaNac, genero, numCel, domicilio, aptoFisico)
        {
            NroNoSocio = nroNoSocio;
        }
    }
}
