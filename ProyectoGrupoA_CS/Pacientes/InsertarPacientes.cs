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
    public partial class InsertarPacientes : Form
    {
        Datos datos = new Datos(); //Se crea una instancia que obtiene los metodos de la clase Datos
        public InsertarPacientes()
        {
            InitializeComponent();
            dgvPacientes.DataSource = datos.ListarPacientes(); //Se muestra la lista de pacientes en el DataGridView
        }

        private void BtnIngresarDatosPacientes_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = DateIngreso.Value;
            string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd"); // Formato: AAAA-MM-DD
            try
            {
                datos.InsertarPaciente(txtCodigo.Text, txtNombre.Text, txtApellido.Text, txtEdad.Text, txtDireccion.Text, fechaFormateada);
                MessageBox.Show("Paciente agregado correctamente");
                dgvPacientes.DataSource = datos.ListarPacientes();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese correctamente la informacion");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            FrmMenuPacientes frm = new FrmMenuPacientes();
            frm.Show(); //Nos muestra la pestaña de acceso a edicion de pacientes.
            this.Close(); //Nos cierra la pestaña de acceso a edicion de pacientes.
        }
    }
}
