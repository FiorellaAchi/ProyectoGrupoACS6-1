using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conductor
{
    public partial class FrmIngresarCond : Form
    {
        Datos datos = new Datos(); //Se crea una instancia que obtiene los metodos de la clase Datos
        public FrmIngresarCond()
        {
            InitializeComponent();
            dgvConductores.DataSource = datos.ListarConductores(); //Se listan los conductores con el objetivo de mostrarlos en el DGV
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                datos.InsertarConductor(int.Parse(txtId.Text), txtNombre.Text, txtCedula.Text, txtTelefono.Text, txtLicencia.Text, txtDireccion.Text, txtUnidad.Text, int.Parse(txtDiasLaborados.Text));
                //Se utiliza el metodo de la clase Datos para insertar un nuevo conductor
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en el formato de los datos");
                //Obtiene la excepcion en caso de que el formato de los datos no sea el correcto
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                dgvConductores.DataSource = datos.ListarConductores();            
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); //Cierra el formulario
        }
    }
}
