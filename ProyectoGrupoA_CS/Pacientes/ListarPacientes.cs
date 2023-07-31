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
    public partial class ListarPacientes : Form
    {
        Datos datos = new Datos(); //Se crea una instancia que obtiene los metodos de la clase Datos
        public ListarPacientes()
        {
            InitializeComponent();
            dgvPacientes.DataSource = datos.ListarPacientes(); //Se muestra la lista de pacientes en el DataGridView
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            FrmMenuPacientes frm = new FrmMenuPacientes();
            frm.Show(); //Nos regresa al menu de pacientes.
            this.Close(); //Nos cierra el formulario de listar pacientes.
        }
    }
}
