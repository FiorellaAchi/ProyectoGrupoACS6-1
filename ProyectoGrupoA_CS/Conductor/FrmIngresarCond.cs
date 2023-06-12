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
        Datos datos = new Datos();
        public FrmIngresarCond()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                datos.InsertarConductor(int.Parse(txtId.Text), txtNombre.Text, txtCedula.Text, txtTelefono.Text, txtLicencia.Text, txtDireccion.Text, txtUnidad.Text, int.Parse(txtDiasLaborados.Text));
            }
            catch(FormatException )
            {
                MessageBox.Show("Error en el formato de los datos");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
