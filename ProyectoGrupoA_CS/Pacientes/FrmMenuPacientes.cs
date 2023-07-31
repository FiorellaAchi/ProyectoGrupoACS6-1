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
    public partial class FrmMenuPacientes : Form
    {
        public FrmMenuPacientes()
        {
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            InsertarPacientes frm = new InsertarPacientes();
            frm.Show(); //Nos muestra la pestaña de acceso a edicion de pacientes.
            this.Hide();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close(); //Nos cierra la pestaña de acceso a edicion de pacientes.
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ListarPacientes listarPacientes = new ListarPacientes();
            listarPacientes.Show(); //Nos muestra la pestaña de acceso a listado de pacientes.
            this.Hide();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            EditarPacientes editarPacientes = new EditarPacientes();
            editarPacientes.Show(); //Nos muestra la pestaña de acceso a edicion de pacientes.
            this.Hide();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarPacientes JohnnyWalkerUnElissir = new EliminarPacientes();
            JohnnyWalkerUnElissir.Show(); //Nos permite ir al formulario de eliminacion de pacientes.
        }
    }
}
