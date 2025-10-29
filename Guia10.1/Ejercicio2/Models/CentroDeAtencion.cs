using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class CentroDeAtencion
    {
        Queue<Reclamo> reclamosPendientes = new Queue<Reclamo>();
        Queue<OrdenReparacion> trabajosPendientes = new Queue<OrdenReparacion> ();

        int numeroReclamoGen = 0;

        public Reclamo RecibirReclamo(string nombrePersona, string motivo)
        {
            numeroReclamoGen++;
            Reclamo nuevoReclamo = new Reclamo(numeroReclamoGen, nombrePersona, motivo);

            reclamosPendientes.Enqueue(nuevoReclamo);
            return nuevoReclamo;

        }
        public OrdenReparacion ResolverReclamo()
        {
            Reclamo reclamoAResolver = reclamosPendientes.Dequeue();

            OrdenReparacion nuevaOrden = new OrdenReparacion(reclamoAResolver);
            trabajosPendientes.Enqueue(nuevaOrden);
            return nuevaOrden;
        }

        public OrdenReparacion EjecutarOrdenDeTabajo()
        {
            OrdenReparacion ordenAEjecutar = trabajosPendientes.Dequeue();
            return ordenAEjecutar;
        }

    }
}
