using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clubDeportivo1.Entidades
{
    public class InscripcionE
    {
        public int IdInscripcion { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int DNI { get; set; }
        public bool Aptitud { get; set; }
    }
}