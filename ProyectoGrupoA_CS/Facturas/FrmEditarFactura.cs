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
                DGVListarFacturas.DataSource = datos.ListarFacturas(); //Aqui presento las facturas que se han creado previamente en CrearFactura
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            FrmMenuFactura frmMenuFactura = new FrmMenuFactura(); //Aqui regreso al menu principal
            frmMenuFactura.Show();
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try //Aqui se edita la factura seleccionada
            {
                
                DateTime fechaSeleccionada = DTPEmision.Value;
                string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd"); // Formato: AAAA-MM-DD
                lblFechaSeleccionada.Text = fechaFormateada; //Aqui se muestra la fecha seleccionada en el DTP
                datos.ActualizarFacturas(TxtCodigo.Text, TxtCedula.Text, TxtNombre.Text, fechaFormateada, TxtTelefono.Text, TxtDomicilio.Text, TxtDescripcion.Text);
                MessageBox.Show("Factura editada correctamente");
                DGVListarFacturas.DataSource = datos.ListarFacturas(); //Tras actualizar la factura, se actualiza el DGV
            }
            catch (FormatException) //Aqui se valida que los campos no esten vacios o incorrectos
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

