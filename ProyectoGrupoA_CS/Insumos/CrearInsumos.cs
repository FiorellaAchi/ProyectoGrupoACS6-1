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
    public partial class CrearInsumos : Form
    {
        Datos datos = new Datos();
        public CrearInsumos()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formularioC = new FrmMenuInsumos();
            formularioC.Show();
        }

        private void BtnAgregarInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                string estado = CmbEstado.SelectedItem.ToString();
                DateTime fechaSeleccionada = DtpFechaIngresoInsumo.Value;
                string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd"); // Formato: AAAA-MM-DD
                datos.InsertarInsumos(txtCodigo.Text, txtInsumo.Text, fechaFormateada, txtProveedor.Text, estado);
                    
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
        }
    }
}
