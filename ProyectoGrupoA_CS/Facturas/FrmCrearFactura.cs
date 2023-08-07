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
    public partial class FrmCrearFactura : Form
    {
        public FrmCrearFactura()
        {
            InitializeComponent();
        }

        Datos datos = new Datos(); // Instancia de la clase Datos para utilizar los metodos
        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string insumosInput = txtInsumo.Text; // Contenido de la caja de texto
            string[] insumoIds = insumosInput.Split(','); // Separar los IDs utilizando la coma como separador
            try // Try para capturar errores de formato
            {
                foreach (string insumoId in insumoIds)
                {
                    DateTime fechaSeleccionada = DTPEmision.Value; //Aqui dentro obtenemos lo que es la transformacion de datapicker a string
                    string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd"); // Formato: AAAA-MM-DD
                    lblFechaSeleccionada.Text = fechaFormateada; //Aqui se muestra la fecha seleccionada en el DTP
                    datos.CrearFactura(TxtCodigo.Text, TxtCedula.Text, txtConductorID.Text, txtIDPaciente.Text, TxtAmbulancia.Text, txtInsumo.Text,
                        txtServicio.Text, fechaFormateada, txtDomicilio.Text, txtDescripcion.Text, Convert.ToDouble(txtSubtotal.Text));
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese correctamente la informacion"); // Mensaje de error de formato
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Mensaje de error
            }

            txtInsumo.Text = ""; // Limpiar la caja de texto
            TxtCodigo.Text= "";
            TxtCedula.Text = "";
            txtConductorID.Text = "";
            txtIDPaciente.Text = "";
            TxtAmbulancia.Text = "";
            txtServicio.Text = "";
            txtDomicilio.Text = "";
            txtDescripcion.Text = "";
            txtSubtotal.Text = "";
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenuFactura Menu = new FrmMenuFactura();
            Menu.Show();
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numeros", "Alerta",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
