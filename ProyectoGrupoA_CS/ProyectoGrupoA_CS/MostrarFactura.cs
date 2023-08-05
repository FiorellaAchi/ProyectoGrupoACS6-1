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



        private void BtnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Servicios servicios = new Servicios();
            servicios.Show();
        }

        
        public void llenarFactura(int rowIndex)
        {
            DataGridViewRow selectedRow = dgvFacturas.Rows[rowIndex];
          
                

                lblFactura.Text = selectedRow.Cells["id_factura"].Value.ToString();
                lblConductor.Text = selectedRow.Cells["nombre_conductor"].Value.ToString();
                lblIDConductor.Text = selectedRow.Cells["id_conductor"].Value.ToString();
                lblIdAmbulancia.Text = selectedRow.Cells["codigo_ambulancia"].Value.ToString();
                lblPlaca.Text = selectedRow.Cells["numero_placa"].Value.ToString();
                lblIDInsumo.Text = selectedRow.Cells["id_Insumos"].Value.ToString();
                lblInsumos.Text = selectedRow.Cells["insumo"].Value.ToString();
                lblIDServicio.Text = selectedRow.Cells["codigo_servicio"].Value.ToString();
                lblServicios.Text = selectedRow.Cells["nombre_servicio"].Value.ToString();
                lblDomicilio.Text = selectedRow.Cells["domicilio"].Value.ToString();
                lblDescripcion.Text = selectedRow.Cells["descripcion"].Value.ToString();
                lblEmision.Text = selectedRow.Cells["emision"].Value.ToString();
                lblSubtotal.Text = selectedRow.Cells["subtotal"].Value.ToString();
                lblTotal.Text = selectedRow.Cells["total"].Value.ToString();
            
        }

        private void MostrarFactura_Load(object sender, EventArgs e)
        {
            if (dgvFacturas.Rows.Count > 0)
            {
                int rowIndexToSelect = 0; // Índice de la fila que deseas seleccionar
                dgvFacturas.Rows[rowIndexToSelect].Selected = true;

                // Luego puedes llamar a la función para mostrar los datos de la fila seleccionada
                llenarFactura(rowIndexToSelect);
            }

        }

        private void dgvFacturas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvFacturas.SelectedRows[0].Index;
                llenarFactura(selectedRowIndex);
            }
        }
    }
}
