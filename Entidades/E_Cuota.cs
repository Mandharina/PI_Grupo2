namespace PI_Grupo2.Entidades
{
    public class E_Cuota
    {
        public int NroSocio { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public double Importe { get; set; }
        public string MetodoPago { get; set; }
        public int CantCuotas { get; set; }
    }
}
