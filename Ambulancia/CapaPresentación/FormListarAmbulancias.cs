using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class FormListarAmbulancias : Form
    {
        CN_GetData objCapaNegocio = new CapaNegocios.CN_GetData();
        public FormListarAmbulancias()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarAmbulancia();
        }

        private void CargarAmbulancia()
        {
            dgvAmbulancia.DataSource = objCapaNegocio.ListarAmbulancia();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de salir de esta ventana?",
                    "Adevertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
