using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insumos
{
    public partial class FrmMenuInsumos : Form
    {
        public FrmMenuInsumos()
        {
            InitializeComponent();
        }

        private void BtnIngresarInsumos_Click(object sender, EventArgs e)
        {
            Form formulario = new CrearInsumos();
            formulario.Show();
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            Form abrirListado = new ListarInsumos();
            abrirListado.Show();
            this.Hide();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Form Eliminan2 = new EliminarInsumo();
            Eliminan2.Show();
            this.Hide();
        }
    }
}
