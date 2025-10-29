using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Reclamo
    {
        int numero;
        string nombre, motivo;

        public int Numero { get => numero; private set => numero = value; }
        public string Nombre { get => nombre; private set => nombre = value; }
        public string Motivo { get => motivo; private set => motivo = value; }

        public Reclamo(int numero, string nombrePersona, string motivo)
        {
            Numero = numero;
            Nombre = nombrePersona;
            Motivo = motivo;
        }

        public override string ToString()
        {
            return $"{Numero} - {Nombre}: {Motivo}";
        }
    }
}
