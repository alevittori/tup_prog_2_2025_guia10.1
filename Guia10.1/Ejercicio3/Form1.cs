using Ejercicio3.Models;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        CentralTaxis remiseria = new CentralTaxis();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            remiseria.CrearMoviles(); //hacordeo de los moviles
            remiseria.cargarMovilesDisponibles(); //carga los moviles hacordeados a la cola de moviles disponibles
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            try
            {
                string telPersona = tbTel.Text;
                string dirPersona = tbDir.Text;
                Pedido nuevoPedido = remiseria.RecibirPedido(dirPersona, telPersona);
                if (nuevoPedido != null)
                    lbxPedidosEntrantes.Items.Add(nuevoPedido);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ups"); }

        }

        private void btnAsignarCoche_Click(object sender, EventArgs e)
        {
            Movil coche = remiseria.AsignarCoche();
            if (coche == null)
            {
                MessageBox.Show("No hay pedidos, o coches disponibles", "No hay disponibilidad"); // aca puedo crearme una excepciones personalizadas para lanzar si es por falta de movil  o por falta de pedidos
                return;
            }
            lbxOcupado.Items.Add(coche);
            lbxDisponibles.Items.Remove(coche);
        }

        private void btnLiberarConche_Click(object sender, EventArgs e)
        {
            int numMovil = Convert.ToInt32(nupNumMovil.Value);
            remiseria.LiberarVehiculo(numMovil);

        }
    }
}
