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
      

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try // Try para capturar errores de formato
            {
               
                    DateTime fechaSeleccionada = DTPEmision.Value; //Aqui dentro obtenemos lo que es la transformacion de datapicker a string
                    string fechaFormateada = fechaSeleccionada.ToString("yyyy-MMM-ddd"); // Formato: AAAA-MM-DD
                    datos.CrearFactura(TxtCodigo.Text, TxtCedula.Text, txtConductorID.Text, TxtAmbulancia.Text, txtInsumo.Text,
                    txtServicio.Text, fechaFormateada, txtDomicilio.Text, txtDescripcion.Text, Convert.ToDouble(txtSubtotal.Text), txtIDPaciente.Text);
                    MessageBox.Show("Factura creada correctamente"); // Mensaje de confirmacion
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese correctamente la informacion"); // Mensaje de error de formato
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Mensaje de error
            }

            TxtCodigo.Clear();
            TxtCedula.Clear();
            txtConductorID.Clear();
            TxtAmbulancia.Clear();
            txtInsumo.Clear();
            txtServicio.Clear();
            txtDomicilio.Clear();
            txtDescripcion.Clear();
            txtSubtotal.Clear();
            txtIDPaciente.Clear();

           
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenuFactura Menu = new FrmMenuFactura();
            Menu.Show();
        }

        

        
    }
}
