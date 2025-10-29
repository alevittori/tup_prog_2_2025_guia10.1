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
        private void Form1_Load(object sender, EventArgs e)
        {
            btnEntragarPaquete.Enabled = false;
            gbEntregar.Enabled = false;

        }

        private void btnRecibirPaquete_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = tbNombre.Text;
                string direccion = tbDireccion.Text;
                int dni = Convert.ToInt32(tbDNI.Text);

                Paquete paquete = despachador.RecibirCorrespondencia(nombre, dni, direccion);



                lsbPaquetesRecibidos.Items.Add(paquete);

                tbNombre.Clear();
                tbDireccion.Clear();
                tbDNI.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error"); }

        }

        private void btnPrepararCamion_Click(object sender, EventArgs e)
        {
            FDatoCamion VCargarCamion = new FDatoCamion();
            int capacidad = 0;
            try
            {
                if (VCargarCamion.ShowDialog() == DialogResult.OK)
                {
                    capacidad = Convert.ToInt32(VCargarCamion.nupCapacidadCamion.Value);
                    despachador.PrepararCamion(capacidad);// crea el camion con cierta capacidad
                    lsbPaquetesAEntregar.Items.Clear();

                    Paquete paquete = null;
                    do
                    {
                        paquete = despachador.CargarPaqueteAlCamion();
                        if (paquete != null)
                        {
                            lsbPaquetesRecibidos.Items.Remove(paquete);

                            lsbPaquetesAEntregar.Items.Add(paquete);
                        }
                    } while (paquete != null);
                }

                /*
                for (int i = 0; i < capacidad; i++)//cargamos los paquetes hasta que de la capacidad del camion
                {
                    Paquete paquete = despachador.CargarPaqueteAlCamion();
                    if (paquete == null)// si no hay paquete pero si capacidad
                        return;
                    //remover el paquete de la lista en sector de embarque
                    lsbPaquetesRecibidos.Items.Remove(paquete);// no me esta borrando, creo que porque son referencias distintas

                    //AHORA DEBERIAMOS MOSTRAR LA CARGA DEL CAMION EN EL LISTADO A ENTREGAR EN LA TARE DE REPARTO
                    lsbPaquetesAEntregar.Items.Add(paquete);
                }*/


                //UNA VEZ CARGADO EL CAMION DEBERIAMOS INABILITAR EL BOTON, HASTA QUE NO TERMINE LA ENTREGA, SEGUN LA LOGICA DE ESTE PROBLEMA
                btnPrepararCamion.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnIniciarReparto_Click(object sender, EventArgs e)
        {
            //obtener con deep el ultimo  de la lista
            //agregar los datos en los campos
            //si apreta entrag paquete , desencolamos, sacamos del listbox
            //repetimos con el siguiente
            //una vez entregado todo, deberiamos volver a habilitar el boton preparar camion
            Paquete aEntregar = despachador.Camion.Revisar();
            btnEntragarPaquete.Enabled = true;
            if (aEntregar != null)
            {
                tbNombreEntrega.Text = aEntregar.Destinatario.Nombre;
                tbDniEntrega.Text = aEntregar.Destinatario.Dni.ToString();
                tbDirEntrega.Text = aEntregar.Destinatario.Direccion;
            }
            else
            {
                MessageBox.Show("No Hay paquetes para entregar", "Camion Vacio");
                btnEntragarPaquete.Enabled = false;
            }
        }

        private void btnEntragarPaquete_Click(object sender, EventArgs e)
        {
            Paquete entregado = despachador.Camion.Descargar();
            if (entregado != null)
            {
                lsbPaquetesAEntregar.Items.Remove(entregado);
                tbDirEntrega.Clear();
                tbNombreEntrega.Clear();
                tbDniEntrega.Clear();
            }
            else
            {
                btnEntragarPaquete.Enabled=false;
                //vuelvo a habilitar el boton cargarcamion
                btnPrepararCamion.Enabled=true;
                lsbPaquetesAEntregar.Items.Add("No hay mas paquetes para entregar - Camion Vacio");
            }
        }
    }
}
