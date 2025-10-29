using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Cliente:Persona
    {
        public Cliente(string nombre, int dni, string dir):base(nombre,dni,dir) { }
    }
}
