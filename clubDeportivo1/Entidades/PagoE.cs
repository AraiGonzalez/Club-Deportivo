using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace clubDeportivo1.Entidades
{
    public class PagoE
    {
        public int IdPago { get; set; }
        public int IdInscripcion { get; set; }
        public string? FormaPago { get; set; }
        public string? Plan { get; set; }
        public double Monto { get; set; }
        public int Cuotas { get; set; }
        public string? Fecha { get; set; }

    }
}
