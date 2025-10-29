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
        Stack<Paquete> entregas = new Stack<Paquete>();

        public int Capacidad { get => capacidad; private set => capacidad = value; }
        public int Ocupacion { get =>  entregas.Count; private set => ocupacion = value; }
    
        public Repartidor(int capacidad)
        {
            Capacidad = capacidad;
            
        }

        public bool HayEspacio()
        {
            return (Capacidad - Ocupacion) > 0;
        }
    
        public void Cargar(Paquete paquete)
        {
            if (!HayEspacio())
                return;
            entregas.Push(paquete);
            
        }
        public Paquete Descargar()
        {
            if(entregas.Count > 0)//con esto evito que me de una excepcion de pila vacia
                return entregas.Pop();
            return null;
        }

        public Paquete Revisar()
        {
           
            if(entregas.Count > 0) //con esto evito que me de una excepcion de pila vacia
                return entregas.Peek();
            return null;
        }
    
    }
}
