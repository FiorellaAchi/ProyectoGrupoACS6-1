using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void agregarAmbulanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarAmbulancia agregar = new FormAgregarAmbulancia();
            agregar.Show();
        }

        private void listarAmbulanciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListarAmbulancias listar = new FormListarAmbulancias();
            listar.Show();
        }

        private void modificarAmbulanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarAmbulancia modificar = new FormModificarAmbulancia();
            modificar.Show();
        }

        private void eliminarAmbulanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminarAmbulancia eliminar = new FormEliminarAmbulancia();
            eliminar.Show();
        }
    }
}
