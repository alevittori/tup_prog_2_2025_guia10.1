using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class OrdenReparacion
    {
        Reclamo reclamo;
        DateTime fecha;
        bool solucionado;

        public DateTime Fecha { get => fecha; private set => fecha = value; }
        public bool Solucionado { get => solucionado;  set => solucionado = value; }
        internal Reclamo Reclamo { get => reclamo; private set => reclamo = value; }

        public OrdenReparacion(Reclamo reclamo)
        {
            Reclamo = reclamo;
            Fecha = DateTime.Now;
            Solucionado = false;
        }

        public override string ToString()
        {
            return $"{reclamo.ToString()}";
        }
    }
}
