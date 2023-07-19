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

namespace Insumos
{
    public partial class EditarInsumos : Form
    {
        Datos datos = new Datos();
        public EditarInsumos()
        {
            InitializeComponent();
            try
            {
                DgvListadoEditar.DataSource = datos.ListarInsumos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string estado = cmbEstado.SelectedItem.ToString();
                DateTime fechaSeleccionada = DTPFecha.Value;
                string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd"); // Formato: AAAA-MM-DD
                datos.ActualizarInsumos(txtCodigoNew.Text, txtInsumo.Text, fechaFormateada, txtProveedor.Text, estado);

            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese correctamente la informacion");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Insumo agregado correctamente");
            DgvListadoEditar.DataSource = datos.ListarInsumos();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenuInsumos frmMenuInsumos = new FrmMenuInsumos();
            frmMenuInsumos.Show();
        }
    }
}
