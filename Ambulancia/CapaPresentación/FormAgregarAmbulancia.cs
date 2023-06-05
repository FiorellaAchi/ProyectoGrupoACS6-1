using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
namespace CapaPresentación
{
    public partial class FormAgregarAmbulancia : Form
    {
        CN_GetData objCapaNegocio = new CapaNegocios.CN_GetData();
        public FormAgregarAmbulancia()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objCapaNegocio.agregarAmbulancia(txtCod.Text, txtMarca.Text, txtNumPlaca.Text, txtAnio.Text, txtConductor.Text);
            MessageBox.Show("¡Registro Insertado con éxito!");
            LimpiarFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de cancelar el ingreso del registro?",
                    "Adevertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void LimpiarFormulario()
        {
            txtCod.Text = "";
            txtMarca.Text = "";
            txtNumPlaca.Text = "";
            txtAnio.Text = "";
            txtConductor.Text = "";

        }
    }
}
