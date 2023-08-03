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
    public partial class FrmIngresarAmb : Form
    {
        Datos datos = new Datos(); //Se llama a la clase datos en donde estan los metodos y la conexion a la base de datos
        public FrmIngresarAmb()
        {
            InitializeComponent();
            dgvAmbulancias.DataSource = datos.ListarAmbulancias(); //Se muestra la informacion de las ambulancias en el datagridview
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                datos.InsertarAmbulancia(int.Parse(txtCodigo.Text), txtMarca.Text, txtNumeroPlaca.Text, int.Parse(txtAño.Text), int.Parse(txtId.Text));
                //Se "atrapa" el metodo de la clase datos y se le pasan los parametros
                dgvAmbulancias.DataSource = datos.ListarAmbulancias(); //Se muestra la nueva ambulancia en el datagridview
            }
            catch(FormatException) //Si todo esta correcto, se ejecuta el metodo y el programa continua
            {
                MessageBox.Show("Ingrese correctamente la informacion"); // Se presenta el mensaje de que la ambulancia esta correctamente ingresada
            }
            catch(Exception ex) //Si ocurre un error, se muestra el mensaje de error
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); //Esto cierra el formulario
        }
    }
}
