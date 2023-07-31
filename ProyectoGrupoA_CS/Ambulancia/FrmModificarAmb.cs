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

namespace Ambulancia
{
    public partial class FrmModificarAmb : Form
    {
        Datos datos = new Datos(); //se instancia a la clase datos para poder utilizar sus metodos
        public FrmModificarAmb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                datos.ActualizarAmbulancia(int.Parse(txtCodigo.Text), txtMarca.Text, txtNumeroPlaca.Text, int.Parse(txtAño.Text), int.Parse(txtId.Text));
                //Se "atrapa" el metodo de la clase datos y se le pasan los parametros para poder actualizar la informacion
            }
            catch(FormatException)
            {
                MessageBox.Show("Ingrese correctamente la informacion"); // Se presenta el mensaje de que la informacion actualizada de la ambulancia esta correctamente ingresada
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //Si ocurre un error, se muestra el mensaje de error
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); //Cierra el formulario
        }
    }
}
