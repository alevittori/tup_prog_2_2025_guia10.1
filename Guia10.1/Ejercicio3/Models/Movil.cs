using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    internal class Movil:IComparable<Movil>
    {
        Pedido pasajero;
        int numero;

        public int Numero { get => numero; private set => numero = value; }
        internal Pedido Pasajero { get => pasajero;  set => pasajero = value; }

        public Movil(int numero)
        {
            Numero = numero;
        }

        public int CompareTo(Movil other)
        {
            if (other == null) return -1;
            return this.Numero.CompareTo(other.Numero);
        }

        public override string ToString()
        {
            return $"Movil {Numero}";
        }
    }
}
