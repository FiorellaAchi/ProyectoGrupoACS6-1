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
    public partial class FrmEliminarAmb : Form
    {
        // Crear una instancia de la clase Datos, que contiene los metodos
        Datos datos = new Datos();

        
        public FrmEliminarAmb()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual cuando se hace clic en el botón.
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Intenta eliminar una ambulancia en función del código proporcionado en "txtCodigo.Text".
                // La eliminación se realiza a través del objeto "datos" de la clase "Datos".
                //El método elimina ambulancias mediante su codigo.
                datos.EliminarAmbulancia(int.Parse(txtCodigo.Text));
            }
            catch (FormatException)
            {
                // Si se produce una excepción de formato al intentar convertir el texto del cuadro de texto "txtCodigo" a un número entero,
                // se muestra un mensaje de error indicando que el código debe ser un número entero.
                MessageBox.Show("El codigo debe ser un numero entero");
            }
            catch (Exception ex)
            {
                // Si ocurre alguna otra excepción diferente de FormatException, se muestra un mensaje de error con el mensaje de la excepción.
                MessageBox.Show(ex.Message);
            }
        }
    }
}