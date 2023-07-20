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

namespace Facturas
{
    public partial class FrmEditarFactura : Form
    {
        Datos datos = new Datos();
        public FrmEditarFactura()
        {
            InitializeComponent();
            try
            {
                DGVListarFacturas.DataSource = datos.ListarFacturas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            FrmMenuFactura frmMenuFactura = new FrmMenuFactura();
            frmMenuFactura.Show();
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                
                DateTime fechaSeleccionada = DTPEmision.Value;
                string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd"); // Formato: AAAA-MM-DD
                datos.ActualizarFacturas(TxtCodigo.Text, TxtCedula.Text, TxtNombre.Text, fechaFormateada, TxtTelefono.Text, TxtDomicilio.Text, TxtDescripcion.Text);
                MessageBox.Show("Factura editada correctamente");
                DGVListarFacturas.DataSource = datos.ListarFacturas();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese correctamente la informacion");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

    }
}

