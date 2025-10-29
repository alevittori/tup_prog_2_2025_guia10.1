using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Repartidor
    {
        int capacidad, ocupacion;
        Stack<Paquete> entregas;

        public int Capacidad { get => capacidad; private set => capacidad = value; }
        public int Ocupacion { get =>  ocupacion; private set => ocupacion = value; }
    
        public Repartidor(int capacidad)
        {
            Capacidad = capacidad;
            Ocupacion = 0;
        }

        public bool HayEspacio()
        {
            return (capacidad - ocupacion) > 0;
        }
    
        public void Cargar(Paquete paquete)
        {
            if (!HayEspacio())
                return;
            entregas.Push(paquete);
            Ocupacion++;
        }
        public Paquete Descargar()
        {
            Ocupacion--;
            return entregas.Pop();
        }

        public Paquete Revisar()
        {
            return entregas.Peek();
        }
    
    }
}
