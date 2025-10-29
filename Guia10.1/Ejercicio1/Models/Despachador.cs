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

        public Paquete RecibirCorrespondencia(string nombre, int dni, string direc)
        {
            Paquete correspondencia = new Paquete(dni, nombre, direc);
            depositos.Enqueue(correspondencia);

            return correspondencia;
        }
        public Repartidor PrepararCamion(int capacidad)
        {
            this.camion = new Repartidor(capacidad);
            return camion;
        }
        public void CargarPaqueteAlCamion()
        {
            while (camion.HayEspacio())
            {
                camion.Cargar(depositos.Dequeue());
            }
        }
    }
}
