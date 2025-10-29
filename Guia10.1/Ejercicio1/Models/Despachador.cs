using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Despachador
    {
        Queue<Paquete> depositos = new Queue<Paquete>();
        Repartidor camion;

        internal Repartidor Camion { get => camion; private set => camion = value; }

        public Despachador()
        {
            this.camion = new Repartidor(10);
        }
        public Paquete RecibirCorrespondencia(string nombre, int dni, string direc)
        {
            Paquete correspondencia = new Paquete(dni, nombre, direc);
            depositos.Enqueue(correspondencia);

            return correspondencia;
        }
        public Repartidor PrepararCamion(int capacidad)
        {
            this.Camion = new Repartidor(capacidad);
            return Camion;
        }
        public Paquete CargarPaqueteAlCamion()
        {
            Paquete paquete = null;
            if (Camion.HayEspacio() == true && depositos.Count > 0)
            {
                paquete = depositos.Dequeue();
                Camion.Cargar(paquete);
            }
            return paquete;

            /*
            if (!camion.HayEspacio())
                return null;
            if (!(depositos.Count > 0))
                return null;

            Paquete paqueteACargar = depositos.Dequeue();
            camion.Cargar(paqueteACargar);
            return paqueteACargar;
            */
            
        }
    }
}
