using System;
namespace Beans
{
    public class Reporte
    {
        public string CodigoReporte { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public Evento Evento { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string ReferenciaUbicacion { get; set; }
        public string Sector { get; set; }
        public Usuario Usuario { get; set; }
        public string FechaCreacion { get; set; }
        public string FechaAtencion { get; set; }

    }
}
