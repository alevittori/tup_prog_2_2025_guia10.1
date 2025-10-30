using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    internal class Pedido
    {
        string telefono, direccion;

        public string Telefono { get => telefono; private set => telefono = value; }
        public string Direccion { get => direccion; private set => direccion = value; }
    
        public Pedido(string tel, string dir)
        {
            Telefono=tel;
            Direccion = dir;
        }

        public override string ToString()
        {
            return $"{Direccion} - Tel({Telefono}).";
        }
    
    }
}
