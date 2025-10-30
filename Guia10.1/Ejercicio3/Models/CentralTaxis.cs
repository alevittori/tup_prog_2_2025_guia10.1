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


        int numero = 1;
        public void CrearMoviles()
        {
            for (int i = 1; i <= 10; i++)
            {
                Movil nuevoMovil = new(i);
                listaDeMoviles.AddLast(nuevoMovil);
            }
        }
        public void cargarMovilesDisponibles()
        {
            foreach(Movil coche in listaDeMoviles)
            {
                movilesDisponibles.Enqueue(coche);
            }
        }



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
            if (movilesDisponibles.Count < 1)
                return null;//trow new MovilException("No hay moviles disponibles");
            if (pedidosEnEspera.Count < 1)
                return null; //trow new PedidoException("No hay pedidos disponibles");
            Movil cocheAsignado = movilesDisponibles.Dequeue();
            Pedido pedido = pedidosEnEspera.Dequeue();
            cocheAsignado.Pasajero = pedido;
            movilesOcupados.Add(cocheAsignado);
            return cocheAsignado;
        }

        public void LiberarVehiculo(int numero)
        {
            Movil movil = movilesOcupados.First(movilEnlista => movilEnlista.Numero == numero); // seleccionamos el movil de la lista  de moviles ocupado segun el numero de movil
            movilesDisponibles.Enqueue(movil); // retornamos a la cola de moviles disponibles
            movilesOcupados.Remove(movil);// lo borramos de la lista de moviels ocupados 
        }
    }
}
