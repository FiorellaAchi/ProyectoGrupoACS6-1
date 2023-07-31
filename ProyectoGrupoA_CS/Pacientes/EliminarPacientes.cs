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
    public partial class EliminarPacientes : Form
    {
        Datos datos = new Datos(); //Se crea una instancia que obtiene los metodos de la clase Datos
        public EliminarPacientes()
        {
            InitializeComponent();
            dgvPacientes.DataSource = datos.ListarPacientes(); //Se muestra la lista de pacientes en el DataGridView
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            datos.EliminarPaciente(txtNombre.Text);
            try
            {
                dgvPacientes.DataSource = datos.ListarPacientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            FrmMenuPacientes frm = new FrmMenuPacientes();
            frm.Show(); //Nos muestra la pestaña de acceso a edicion de pacientes.
            this.Close(); //Nos cierra la pestaña de acceso a edicion de pacientes.
        }
    }
}
