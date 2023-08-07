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
        Datos datos = new Datos(); //Se crea una instancia de datos para poder acceder a los metodos de la clase Datos
        public CrearInsumos()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form formularioC = new FrmMenuInsumos(); //Con el boton regresar se cierra el formulario actual y se abre el menu de insumos
            formularioC.Show();
        }

        private void BtnAgregarInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                string estado = CmbEstado.SelectedItem.ToString(); //Se obtiene el estado del insumo seleccionado en el combobox
                DateTime fechaSeleccionada = DtpFechaIngresoInsumo.Value; //Se obtiene la fecha seleccionada en el datepicker
                string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd"); // Formato: AAAA-MM-DD //Se formatea la fecha para que sea compatible con la base de datos
                datos.InsertarInsumos(txtCodigo.Text, txtInsumo.Text, fechaFormateada, txtProveedor.Text, estado); //Se insertan los datos en la base de datos
                    
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese correctamente la informacion");
            }
            catch (Exception ex) //Se controlan las excepciones
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Insumo agregado correctamente");

            //Se limpian los campos de texto
            txtCodigo.Text = ""; 
            txtInsumo.Text = "";
            txtProveedor.Text = "";
            CmbEstado.Text = "";
        }
    }
}
