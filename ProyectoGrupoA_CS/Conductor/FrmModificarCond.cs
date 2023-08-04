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
    public partial class FrmModificarCond : Form
    {
        Datos datos = new Datos(); //Crea una instancia de la clase Datos para usar sus metodos
        public FrmModificarCond()
        {
            InitializeComponent();
            dgvConductores.DataSource = datos.ListarConductores(); //Lista a los conductores disponibles
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                datos.ActualizarConductor(txtId.Text, txtNombre.Text, txtCedula.Text, txtTelefono.Text, txtLicencia.Text, txtDireccion.Text, txtUnidad.Text, int.Parse(txtDiasLaborados.Text));
                //Se utiliza el metodo de la clase Datos para actualizar los datos del conductor
                MessageBox.Show("Conductor actualizado correctamente"); //Se muestra un mensaje de exito
            }
            catch(FormatException)
            {
                MessageBox.Show("Ingrese correctamente la informacion"); //Se muestra un mensaje de error en caso de que ocurra una excepcion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Se muestra un mensaje de error en caso de que ocurra una excepcion

            }
           
            finally
            { 
                dgvConductores.DataSource = datos.ListarConductores(); //Se actualiza el DGV
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
