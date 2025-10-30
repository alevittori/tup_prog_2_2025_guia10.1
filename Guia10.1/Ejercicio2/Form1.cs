using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        CentroDeAtencion servicioAtencion = new CentroDeAtencion();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarReclamo_Click(object sender, EventArgs e)
        {
            try
            {
                string nombrePersona = tbNombrePersona.Text;
                string motivoReclamo = tbMotivoReclamo.Text;
                Reclamo nuevoReclamo = servicioAtencion.RecibirReclamo(nombrePersona, motivoReclamo);
                lbxVerReclamos.Items.Add(nuevoReclamo);


                tbMotivoReclamo.Clear();
                tbNombrePersona.Clear();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ups"); }

        }

        private void btnCrearOrden_Click(object sender, EventArgs e)
        {
            OrdenReparacion ordenAResolver = servicioAtencion.ResolverReclamo();

            if(ordenAResolver != null)
            {
                 lbxVerOrdenesAEjecutar.Items.Add(ordenAResolver);

            }
            else
            {

                MessageBox.Show("Cargue un reclamo para generar la orden", "No hay reclamos en lista");
            }

        }

        private void btnEjecutarOrden_Click(object sender, EventArgs e)
        {
            OrdenReparacion ordenResuelta = servicioAtencion.EjecutarOrdenDeTabajo();

            if(ordenResuelta != null )
            {
                 lbxVerOrdenesAEjecutar.Items.Remove(ordenResuelta);

            }
            else
            {

                MessageBox.Show("No hay orden a ejecutar", "Lista Vacia");
            }

        }
    }
}
