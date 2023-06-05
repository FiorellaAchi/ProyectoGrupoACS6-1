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
    public partial class FormModificarCond : Form
    {
        Datos datos = new Datos();
        public FormModificarCond()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datos.ActualizarConductor(int.Parse(txtId.Text), txtNombre.Text, txtCedula.Text, txtTelefono.Text, txtLicencia.Text, txtDireccion.Text, txtUnidad.Text, int.Parse(txtDiasLaborados.Text));
        }
    }
}
