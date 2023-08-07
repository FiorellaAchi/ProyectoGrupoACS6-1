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
            dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Se selecciona toda la fila del DataGridView
            dgvPacientes.CellClick += dgvPacientes_CellClick; //Se activa el evento CellClick
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
                datos.ActualizarPaciente(txtCodigo.Text, txtNombre.Text, txtApellido.Text, txtEdad.Text, txtDireccion.Text, IngresoFormateado);
                dgvPacientes.DataSource = datos.ListarPacientes(); //Se repite la accion con el objetivo de mostrar cambios
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese correctamente la informacion");
            }
        }

        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que se haya seleccionado una fila válida
            { 
                DataGridViewRow row = dgvPacientes.Rows[e.RowIndex];
                txtCodigo.Text = row.Cells["id_Paciente"].Value.ToString();
                txtNombre.Text = row.Cells["nombre"].Value.ToString();
                txtApellido.Text = row.Cells["apellido"].Value.ToString(); 
                txtEdad.Text = row.Cells["edad"].Value.ToString();
                txtDireccion.Text = row.Cells["direccion"].Value.ToString(); 
            }
        }
    }
}
