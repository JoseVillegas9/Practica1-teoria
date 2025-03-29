using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica1-teoria.Models
{
    public class BoletaModel
    {
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}