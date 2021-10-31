using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6._5.Entidades
{
    public class Aportes
    {
        public int AportesId { get; set; }
        public DateTime Fecha { get; set; }
        public int PersonaId { get; set; }
        public string Concepto { get; set; }
        public int Monto { get; set; }
    }
}
