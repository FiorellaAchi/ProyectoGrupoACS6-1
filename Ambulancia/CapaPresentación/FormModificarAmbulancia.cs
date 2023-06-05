using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{

    public partial class FormModificarAmbulancia : Form
    {
        CN_GetData objCapaNegocio = new CapaNegocios.CN_GetData();
        public FormModificarAmbulancia()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarAmbulancia();
        }

        private void CargarAmbulancia()
        {
            dgvAmbulancia.DataSource = objCapaNegocio.ListarAmbulancia();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAmbulancia.SelectedRows.Count > 0)
            {
                //Cargar información de la fila seleccionada del DataGridView en la cajas de texto
                int indice = dgvAmbulancia.CurrentCell.RowIndex;
                txtCod.Text = dgvAmbulancia.Rows[indice].Cells[0].Value.ToString();
                txtMarca.Text = dgvAmbulancia.Rows[indice].Cells[1].Value.ToString();
                txtNumPlaca.Text = dgvAmbulancia.Rows[indice].Cells[2].Value.ToString();
                txtAnio.Text = dgvAmbulancia.Rows[indice].Cells[3].Value.ToString();
                txtConductor.Text = dgvAmbulancia.Rows[indice].Cells[4].Value.ToString();

            }
            else
            {
                MessageBox.Show("¡Debe seleccionar una fila!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objCapaNegocio.ModificarAmbulancia(txtCod.Text, txtMarca.Text, txtNumPlaca.Text, txtAnio.Text, txtConductor.Text);
            MessageBox.Show("¡Registro Actualizado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarAmbulancia();
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
