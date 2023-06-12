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
        Datos datos = new Datos();
        public FrmModificarCond()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                datos.ActualizarConductor(int.Parse(txtId.Text), txtNombre.Text, txtCedula.Text, txtTelefono.Text, txtLicencia.Text, txtDireccion.Text, txtUnidad.Text, int.Parse(txtDiasLaborados.Text));
            }
            catch(FormatException)
            {
                MessageBox.Show("Ingrese correctamente la informacion");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Modificado correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
