using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    internal class CentralTaxis
    {
        Queue<Pedido> pedidosEnEspera = new Queue<Pedido>();
        LinkedList<Movil> listaDeMoviles = new LinkedList<Movil>();

        Queue<Movil> movilesDisponibles = new Queue<Movil>();
        List<Movil> movilesOcupados = new List<Movil>();

        public Pedido RecibirPedido(string direc, string tel)
        {
            Pedido nuevoPedido = new Pedido(tel,direc);

            pedidosEnEspera.Enqueue(nuevoPedido);
            return nuevoPedido;
        }

        public Movil AsignarCoche()
        {
            Movil cocheAsignado = movilesDisponibles.Dequeue();
            Pedido pedido = pedidosEnEspera.Dequeue();
            cocheAsignado.Pasajero = pedido;
            movilesOcupados.Add(cocheAsignado);
            return cocheAsignado;
        }

        public void LiberarVehiculo(int numero)
        {
            Movil movil = movilesOcupados.First(movilEnlista => movilEnlista.Numero == numero);
        }
    }
}
