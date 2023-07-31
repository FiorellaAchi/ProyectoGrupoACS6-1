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

namespace Pacientes
{
    public partial class EditarPacientes : Form
    {
        Datos datos = new Datos(); //Se crea una instancia que obtiene los metodos de la clase Datos
        public EditarPacientes()
        {
            InitializeComponent();
            dgvPacientes.DataSource = datos.ListarPacientes(); //Se muestra la lista de pacientes en el DataGridView
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            FrmMenuPacientes menuPacientes = new FrmMenuPacientes();
            menuPacientes.Show(); //Nos muestra la pestaña de acceso a edicion de pacientes.
            this.Close();
        }

        private void BtnEditarPacientes_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = DateIngreso.Value;
            string IngresoFormateado = fechaSeleccionada.ToString("yyyy-MM-dd"); // Formato: AAAA-MM-DD
            try
            {
                datos.ActualizarPaciente(txtCodigo.Text, txtNombre.Text, txtApellido.Text, txtEdad.Text, txtDireccion.Text, IngresoFormateado, txtTutor.Text);
                dgvPacientes.DataSource = datos.ListarPacientes(); //Se repite la accion con el objetivo de mostrar cambios
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese correctamente la informacion");
            }
        }
    }
}
