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

namespace ProyectoGrupoA_CS
{
    public partial class MostrarFactura : Form
    {
        Datos datos = new Datos();
        public MostrarFactura()
        {
            InitializeComponent();
            dgvFacturas.DataSource = datos.ListarFactura();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void MostrarFactura_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvFacturas.SelectedRows[1];
            lblFactura.Text = dgvFacturas.CurrentRow.Cells["id_factura"].Value.ToString();
            lblConductor.Text = dgvFacturas.CurrentRow.Cells["nombre_conductor"].Value.ToString();
            lblPlaca.Text = dgvFacturas.CurrentRow.Cells["numero_placa"].Value.ToString();
            lblInsumos.Text = dgvFacturas.CurrentRow.Cells["insumo"].Value.ToString();
            lblServicios.Text = dgvFacturas.CurrentRow.Cells["nombre_servicio"].Value.ToString();
            lblDomicilio.Text = dgvFacturas.CurrentRow.Cells["domicilio"].Value.ToString();
            lblDescripcion.Text = dgvFacturas.CurrentRow.Cells["descripcion"].Value.ToString();
            lblDescripcion.Text = dgvFacturas.CurrentRow.Cells["emision"].Value.ToString();
            lblEmision.Text = dgvFacturas.CurrentRow.Cells["subtotal"].Value.ToString();
            lblSubtotalFactura.Text = dgvFacturas.CurrentRow.Cells["total"].Value.ToString();
        }
    }
}
