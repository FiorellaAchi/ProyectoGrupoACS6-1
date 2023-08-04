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

namespace Ambulancias
{
    public partial class FrmEliminarAmbulancia : Form
    {
        Datos data = new Datos();
        public FrmEliminarAmbulancia()
        {
            InitializeComponent();
            dgvAmbulancia.DataSource = data.ListarAmbulancias();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                data.EliminarAmbulancia(txtCodigoAEliminar.Text); //Elimina la ambulancia
            }catch(Exception ex)
            {
                MessageBox.Show("Error al eliminar la ambulancia: " + ex.Message);
            }
            
        }
    }
}
