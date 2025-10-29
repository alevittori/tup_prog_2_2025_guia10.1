using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    abstract class Persona:IComparable<Persona>
    {
        string nombre, direccion;
        int dni;

        public string Nombre { get => nombre; protected set => nombre = value; }
        public string Direccion { get => direccion; protected set => direccion = value; }
        public int Dni { get => dni; protected set => dni = value; }

        public Persona() { }
        public Persona(string nombre, int dni, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
            Dni = dni;
        }

        public int CompareTo(Persona other)
        {
            if(other == null)
                return -1;

            return this.dni.CompareTo(other.dni);
        }

        public override string ToString()
        {
            return $"{Nombre} ({Dni}) - {Direccion}";
        }


    }
}
