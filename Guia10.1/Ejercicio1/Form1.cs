using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        //clase controladora
        Despachador despachador = new Despachador();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRecibirPaquete_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = tbNombre.Text;
                string direccion = tbDireccion.Text;
                int dni = Convert.ToInt32(tbDNI.Text);

                Paquete paquete = despachador.RecibirCorrespondencia(nombre, dni, direccion);

                lsbPaquetesRecibidos.Items.Add(paquete.ToString());

                tbNombre.Clear();
                tbDireccion.Clear();
                tbDNI.Clear();
            }catch(Exception ex) {MessageBox.Show(ex.Message, "Error"); }

        }
    }
}
