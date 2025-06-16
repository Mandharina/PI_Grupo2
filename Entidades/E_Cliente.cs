namespace PI_Grupo2.Entidades
{
    public class E_Cliente
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Dni { get; set; }
        public DateTime FechaNac { get; set; }
        public string? Genero { get; set; }
        public string? NumCel { get; set; }
        public string? Domicilio { get; set; }
        public Boolean AptoFisico { get; set; }

        public E_Cliente() { }

        public E_Cliente(string? nombre, string? apellido, int dni, DateTime fechaNac,
                  string? genero, string? numCel, string? domicilio, bool aptoFisico)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            FechaNac = fechaNac;
            Genero = genero;
            NumCel = numCel;
            Domicilio = domicilio;
            AptoFisico = aptoFisico;
        }
    }
}
