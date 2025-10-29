using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Paquete
    {
        int numero;
        Cliente destinatario;

        public int Numero { get => numero; private set => numero = value; }
        internal Cliente Destinatario { get => destinatario; private  set => destinatario = value; }

        public Paquete(int dniRemitente, string nombreRemitente, string dirRemitente)
        {
            Destinatario = new Cliente( nombreRemitente,dniRemitente,dirRemitente);
        }

        public override string ToString()
        {
            return $"Paquete para {Destinatario.ToString()}";
        }


    }
}
