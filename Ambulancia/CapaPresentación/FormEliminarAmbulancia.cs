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
    public partial class FormEliminarAmbulancia : Form
    {
        CN_GetData objCapaNegocio = new CapaNegocios.CN_GetData();
        public FormEliminarAmbulancia()
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAmbulancia.SelectedRows.Count > 0)
            {
                //Cargar información de la fila seleccionada del DataGridView en la cajas de texto
                int indice = dgvAmbulancia.CurrentCell.RowIndex;
                string codigoEliminar = dgvAmbulancia.Rows[indice].Cells[0].Value.ToString();
                objCapaNegocio.EliminarAmbulancia(codigoEliminar);
                MessageBox.Show("¡Registro Eliminado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("¡Debe seleccionar una fila!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            CargarAmbulancia();
        }
    }
}
